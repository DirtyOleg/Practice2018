using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Simulator
{
    public partial class CashierFrm : Form
    {
        public static int orderID = 0;

        public CashierFrm()
        {
            InitializeComponent();
            InitialDiscountType();            
        }

        private void InitialDiscountType()
        {
            cbb_discount.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_discount.SelectedIndex = 0;
        }

        private void btn_exportXML_Click(object sender, EventArgs e)
        {
            float totalPriceBeforeDiscount = 0f;
            float totalPriceAftereDiscount = 0f;
            string discountType = cbb_discount.SelectedItem.ToString().Trim();
            List<ProductInfo> productInfoList = GatherProductInfo(out totalPriceBeforeDiscount);

            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf8", null);

            //set root element, Order
            XmlElement order = doc.CreateElement("Order");
            order.SetAttribute("ID", orderID.ToString());
            doc.AppendChild(order);

            //set elements for all product sold
            XmlElement productList = doc.CreateElement("ProductList");
            int productID = 0;
            foreach (ProductInfo item in productInfoList)
            {
                productID++;
                XmlElement product = doc.CreateElement("Product");
                productList.AppendChild(product);

                XmlElement productName = doc.CreateElement("Name");
                productName.InnerText = item.ProductName;
                product.AppendChild(productName);

                XmlElement productPrice = doc.CreateElement("Price");
                productPrice.InnerText = item.ProductPrice.ToString();
                product.AppendChild(productPrice);

                XmlElement productSerialID = doc.CreateElement("SerialID");
                productSerialID.InnerText = item.ProductGuid.ToString();
                product.AppendChild(productSerialID);

                productList.AppendChild(product);
            }
            order.AppendChild(productList);

            //set element for total price before discount
            XmlElement priceBeforeDiscount = doc.CreateElement("TotalPriceBeforeDiscount");
            priceBeforeDiscount.InnerText = totalPriceBeforeDiscount.ToString();
            order.AppendChild(priceBeforeDiscount);

            //set element for discount used
            XmlElement discount = doc.CreateElement("Discount");
            discount.InnerText = discountType;
            order.AppendChild(discount);

            //set element for total price after discount
            XmlElement FinalPrice = doc.CreateElement("FinalPrice");
            totalPriceAftereDiscount = PriceCalculation.CalculateFinalPriceAfterDiscount(totalPriceBeforeDiscount, discountType);
            FinalPrice.InnerText = totalPriceAftereDiscount.ToString();
            order.AppendChild(FinalPrice);

            //Save XML to local direcoty
            doc.Save("Receipt");
            MessageBox.Show("Receipt Saved");
        }

        private List<ProductInfo> GatherProductInfo(out float totalPriceBeforeDiscount)
        {
            List<ProductInfo> productInfoList = new List<ProductInfo>();
            totalPriceBeforeDiscount = 0f;
            //dummy data
            ProductInfo p1 = new ProductInfo();
            p1.ProductName = "Phone";
            p1.ProductPrice = 5000;
            p1.ProductGuid = Guid.NewGuid();
            productInfoList.Add(p1);
            totalPriceBeforeDiscount += p1.ProductPrice;

            ProductInfo p2 = new ProductInfo();
            p2.ProductName = "Laptop";
            p2.ProductPrice = 7500;
            p2.ProductGuid = Guid.NewGuid();
            productInfoList.Add(p2);
            totalPriceBeforeDiscount += p2.ProductPrice;

            ProductInfo p3 = new ProductInfo();
            p3.ProductName = "PC";
            p3.ProductPrice = 12000;
            p3.ProductGuid = Guid.NewGuid();
            productInfoList.Add(p3);
            totalPriceBeforeDiscount += p3.ProductPrice;

            ProductInfo p4 = new ProductInfo();
            p4.ProductName = "Headphone";
            p4.ProductPrice = 550;
            p4.ProductGuid = Guid.NewGuid();
            productInfoList.Add(p4);
            totalPriceBeforeDiscount += p4.ProductPrice;

            ddv_orderList.DataSource = productInfoList;
            //dummy data end

            return productInfoList;
        }

        private void cbb_discount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
