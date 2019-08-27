using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Project_file
{
    class customer
    {
        public void add_customer()
        {

        }

        internal bool search(TextBox txt_phone)
        {
            bool found = false;
            XmlDocument doc = new XmlDocument();
            doc.Load("customer.xml");
            XmlNodeList list = doc.GetElementsByTagName("customer");



            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList c = list[i].ChildNodes;


                string phoneVal = c[1].InnerText;

                int list_orders = int.Parse(c[4].InnerText);



                if (phoneVal.Equals(txt_phone.Text))
                {
                    found = true;
                    list_orders = list_orders + 1;
                    c[4].InnerText = list_orders.ToString();
                    doc.Save("customer.xml");





                }


            }
            return found;
        }

        internal void Add(TextBox txt_name, TextBox txt_phone, TextBox txt_address, object selectedItem, string num_orders, string money)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("customer.xml");

            XmlElement customer = doc.CreateElement("customer");

            XmlElement c1 = doc.CreateElement("Name");
            c1.InnerText = txt_name.Text;
            customer.AppendChild(c1);


            XmlElement c2 = doc.CreateElement("Phone");
            c2.InnerText = txt_phone.Text;
            customer.AppendChild(c2);

            XmlElement c3 = doc.CreateElement("Address");
            c3.InnerText = txt_address.Text;
            customer.AppendChild(c3);

            XmlElement c4 = doc.CreateElement("Area");
            c4.InnerText = selectedItem.ToString();
            customer.AppendChild(c4);

            XmlElement c5 = doc.CreateElement("Number_orders");
            c5.InnerText = num_orders;
            customer.AppendChild(c5);

            XmlElement c6 = doc.CreateElement("Money");
            c6.InnerText = money;
            customer.AppendChild(c6);

            XmlElement c7 = doc.CreateElement("Discount");
            c7.InnerText = "0";
            customer.AppendChild(c7);
            XmlElement root = doc.DocumentElement;
            root.AppendChild(customer);
            doc.Save("customer.xml");
        }

        internal void Addnew(TextBox txt_name, TextBox txt_phone, TextBox txt_address, object selectedItem, string num_orders, string money)
        {

            XmlWriter x = XmlWriter.Create("customer.xml");

            x.WriteStartDocument();
            x.WriteStartElement("Table");
            x.WriteAttributeString("Name", "customer");
            x.WriteStartElement("customer");

            x.WriteStartElement("Name");
            x.WriteString(txt_name.Text);
            x.WriteEndElement();

            x.WriteStartElement("Phone");
            x.WriteString(txt_phone.Text);
            x.WriteEndElement();

            x.WriteStartElement("Address");
            x.WriteString(txt_address.Text);
            x.WriteEndElement();


            x.WriteStartElement("Area");
            x.WriteString(selectedItem.ToString());
            x.WriteEndElement();


            x.WriteStartElement("Number_orders");
            x.WriteString(num_orders);
            x.WriteEndElement();

            x.WriteStartElement("Money");
            x.WriteString(money);
            x.WriteEndElement();

            x.WriteStartElement("Discount");
            x.WriteString("0");
            x.WriteEndElement();

            x.WriteEndElement();
            x.WriteEndElement();

            x.WriteEndDocument();
            x.Close();
        }
    }
}
