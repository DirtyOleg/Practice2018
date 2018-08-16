using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_cashier_Click(object sender, EventArgs e)
        {
            CashierFrm cashierFrm = new CashierFrm();
            cashierFrm.Show();
        }
    }
}
