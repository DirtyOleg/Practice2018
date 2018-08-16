using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OperationFather;
using System.Reflection;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private List<Operation> operationList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeOperationList();
            InitializeAllButton();
        }

        private void InitializeAllButton()
        {
            int x = 90;
            for (int i = 0; i < operationList.Count; i++)
            {
                Button btn = new Button();
                btn.Location = new Point(x, 210);
                x += 100;
                btn.Size = new Size(90, 35);
                btn.Text = operationList[i].OperationSign.ToString();

                btn.Click += btn_Click;

                this.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            char operationSign = Convert.ToChar(btn.Text);
            Operation operation = operationList.Find(op => op.OperationSign == operationSign);

            if (string.IsNullOrWhiteSpace(txt_numOne.Text) || string.IsNullOrWhiteSpace(txt_numTwo.Text))
            {
                txt_numOne.Text = "0";
                txt_numTwo.Text = "0";
                return;
            }
            else
            {
                int num1 = Convert.ToInt32(txt_numOne.Text.Trim());
                int num2 = Convert.ToInt32(txt_numTwo.Text.Trim());
                int result = operation.GetResult(num1, num2);

                lbl_result.Text = result.ToString();
            }
            lbl_operation.Text = operationSign.ToString();
        }

        private void InitializeOperationList()
        {
            operationList = new List<Operation>();

            //all the operation defined in the List
            string[] operationSignList = File.ReadAllLines("OperationList.txt");

            //all the operation DLL provided
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Operation DLL");
            string[] operationDLLFiles = Directory.GetFiles(path, "*.dll");


            foreach (string singleOperation in operationSignList)
            {
                bool isFound = false;

                //iterate each DLL file
                foreach (string singleDLLFile in operationDLLFiles)
                {
                    if (isFound)
                    {
                        break;
                    }

                    Assembly ass = Assembly.LoadFile(singleDLLFile);
                    Type[] types = ass.GetExportedTypes();

                    //iterate each class in one DLL file
                    foreach (Type type in types)
                    {
                        //there maybe other irrelevant class defined in the DLL file, we do not want to instantialize those class, so check the type is Inherit from Operation and if it is abstract
                        if (type.IsSubclassOf(typeof(Operation)) && !type.IsAbstract)
                        {
                            Operation instance = Activator.CreateInstance(type) as Operation;

                            //make sure we get the right class based on the operation sign we are looking for
                            if (instance.OperationSign == Convert.ToChar(singleOperation.Trim()))
                            {
                                operationList.Add(instance);
                                isFound = true;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
