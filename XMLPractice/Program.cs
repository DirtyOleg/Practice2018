using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateXMLFile();
            ModifyXMLFile();
        }

        private static void ModifyXMLFile()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Student.xml");

            XmlElement order = doc.DocumentElement;
            order["CustomerName"].InnerText = "Cindy";

            string name = "Umbrella";
            XmlNode orderItemNode1 = doc.SelectSingleNode($"/Order/Items/OrderItem[@Name='{name}']");
            orderItemNode1.Attributes["Count"].Value = "999";

            XmlNode orderItemNode2 = doc.SelectSingleNode($"/Order/Items/OrderItem[@Name='Fruit']");
            orderItemNode2.Attributes.RemoveNamedItem("Count");

            XmlNode itemsNode = doc.SelectSingleNode("/Order/Items");
            itemsNode.RemoveChild(doc.SelectSingleNode("/Order/Items/OrderItem[@Name='Meter']"));
                       

            doc.Save("Student.xml");

        }

        private static void CreateXMLFile()
        {
            XmlDocument doc = new XmlDocument();

            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            XmlElement order = doc.CreateElement("Order");
            doc.AppendChild(order);

            XmlElement customerName = doc.CreateElement("CustomerName");
            customerName.InnerText = "David";
            order.AppendChild(customerName);

            XmlElement orderNumber = doc.CreateElement("OrderNumber");
            orderNumber.InnerText = "01";
            order.AppendChild(orderNumber);

            XmlElement items = doc.CreateElement("Items");
            order.AppendChild(items);

            XmlElement orderItem1 = doc.CreateElement("OrderItem");
            orderItem1.SetAttribute("Count", "1");
            orderItem1.SetAttribute("Name", "Umbrella");
            items.AppendChild(orderItem1);

            XmlElement orderItem2 = doc.CreateElement("OrderItem");
            orderItem2.SetAttribute("Count", "10001");
            orderItem2.SetAttribute("Name", "Meter");
            items.AppendChild(orderItem2);

            XmlElement orderItem3 = doc.CreateElement("OrderItem");
            orderItem3.SetAttribute("Count", "1234");
            orderItem3.SetAttribute("Name", "Fruit");
            items.AppendChild(orderItem3);

            doc.Save("student.xml");
            Console.WriteLine("Save Success");
            Console.Read();
        }
    }
}
