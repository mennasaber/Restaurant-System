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
using System.Xml;

namespace Project_file
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static string current_customer;
        bool found = false;
        customer c = new customer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            items();
            delivery_boys();
            delivery();
        }

        private void delivery()
        {
            if (!File.Exists("delivery.xml"))
            {
                XmlWriter x = XmlWriter.Create("delivery.xml");

                x.WriteStartDocument();
                x.WriteStartElement("Table");
                x.WriteAttributeString("Name", "deliveries");
                //1
                x.WriteStartElement("delivery");

                x.WriteStartElement("area_code");
                x.WriteString("elmarg");
                x.WriteEndElement();

                x.WriteStartElement("name");
                x.WriteString("mazen");
                x.WriteEndElement();

                x.WriteStartElement("phone");
                x.WriteString("01002587848");
                x.WriteEndElement();

                x.WriteStartElement("numoforders");
                x.WriteString("0");
                x.WriteEndElement();

                x.WriteEndElement();
                //2
                x.WriteStartElement("delivery");

                x.WriteStartElement("area_code");
                x.WriteString("khalafawy");
                x.WriteEndElement();

                x.WriteStartElement("name");
                x.WriteString("mina");
                x.WriteEndElement();

                x.WriteStartElement("phone");
                x.WriteString("01112587848");
                x.WriteEndElement();

                x.WriteStartElement("numoforders");
                x.WriteString("0");
                x.WriteEndElement();

                x.WriteEndElement();
                //3
                x.WriteStartElement("delivery_boy");

                x.WriteStartElement("area_code");
                x.WriteString("shobra");
                x.WriteEndElement();

                x.WriteStartElement("name");
                x.WriteString("Mohamed");
                x.WriteEndElement();

                x.WriteStartElement("phone");
                x.WriteString("01265489609");
                x.WriteEndElement();

                x.WriteStartElement("numoforders");
                x.WriteString("0");
                x.WriteEndElement();

                x.WriteEndElement();

                //4
                x.WriteStartElement("delivery_boy");

               
                x.WriteStartElement("area_code");
                x.WriteString("m3ady");
                x.WriteEndElement();

                x.WriteStartElement("name");
                x.WriteString("Ahmed");
                x.WriteEndElement();

                x.WriteStartElement("phone");
                x.WriteString("01043245456");
                x.WriteEndElement();

                x.WriteStartElement("numoforders");
                x.WriteString("0");
                x.WriteEndElement();

                x.WriteEndElement();

                //5
                x.WriteStartElement("delivery_boy");

             
                x.WriteStartElement("area_code");
                x.WriteString("nasr city");
                x.WriteEndElement();

                x.WriteStartElement("name");
                x.WriteString("Ali");
                x.WriteEndElement();

                x.WriteStartElement("phone");
                x.WriteString("01000686785");
                x.WriteEndElement();

                x.WriteStartElement("numoforders");
                x.WriteString("0");
                x.WriteEndElement();

                x.WriteEndElement();
                //6
                x.WriteStartElement("delivery_boy");
  

                x.WriteStartElement("area_code");
                x.WriteString("helwan");
                x.WriteEndElement();

                x.WriteStartElement("name");
                x.WriteString("mourad");
                x.WriteEndElement();

                x.WriteStartElement("phone");
                x.WriteString("01232487848");
                x.WriteEndElement();

                x.WriteStartElement("numoforders");
                x.WriteString("4");
                x.WriteEndElement();

                x.WriteEndElement();

                x.WriteEndElement();
                x.WriteEndDocument();
                x.Close();
            }
        }

        private void delivery_boys()
        {
            if (!File.Exists("delivery_boy.xml"))
            {
                XmlWriter x = XmlWriter.Create("delivery_boy.xml");

                x.WriteStartDocument();
                x.WriteStartElement("Table");
                x.WriteAttributeString("Name", "delivery_boys");
                //first 
                x.WriteStartElement("delivery_boy");

                x.WriteStartElement("name");
                x.WriteString("mazen");
                x.WriteEndElement();

                x.WriteStartElement("area_code");
                x.WriteString("elmarg");
                x.WriteEndElement();

                x.WriteStartElement("phone");
                x.WriteString("01002587848");
                x.WriteEndElement();

                x.WriteStartElement("numoforders");
                x.WriteString("0");
                x.WriteEndElement();

                x.WriteEndElement();
                //second
                x.WriteStartElement("delivery_boy");

                x.WriteStartElement("name");
                x.WriteString("mina");
                x.WriteEndElement();

                x.WriteStartElement("area_code");
                x.WriteString("khalafawy");
                x.WriteEndElement();

                x.WriteStartElement("phone");
                x.WriteString("01112587848");
                x.WriteEndElement();

                x.WriteStartElement("numoforders");
                x.WriteString("0");
                x.WriteEndElement();

                x.WriteEndElement();
                //3
                x.WriteStartElement("delivery_boy");

                x.WriteStartElement("name");
                x.WriteString("Mohamed");
                x.WriteEndElement();

                x.WriteStartElement("area_code");
                x.WriteString("shobra");
                x.WriteEndElement();

                x.WriteStartElement("phone");
                x.WriteString("01265489609");
                x.WriteEndElement();

                x.WriteStartElement("numoforders");
                x.WriteString("0");
                x.WriteEndElement();

                x.WriteEndElement();
                //4
                x.WriteStartElement("delivery_boy");

                x.WriteStartElement("name");
                x.WriteString("Ahmed");
                x.WriteEndElement();

                x.WriteStartElement("area_code");
                x.WriteString("m3ady");
                x.WriteEndElement();

                x.WriteStartElement("phone");
                x.WriteString("01043245456");
                x.WriteEndElement();

                x.WriteStartElement("numoforders");
                x.WriteString("0");
                x.WriteEndElement();

                x.WriteEndElement();
                //5
                x.WriteStartElement("delivery_boy");

                x.WriteStartElement("name");
                x.WriteString("Ali");
                x.WriteEndElement();

                x.WriteStartElement("area_code");
                x.WriteString("nasr city");
                x.WriteEndElement();

                x.WriteStartElement("phone");
                x.WriteString("01000686785");
                x.WriteEndElement();

                x.WriteStartElement("numoforders");
                x.WriteString("0");
                x.WriteEndElement();

                x.WriteEndElement();
                //6
                x.WriteStartElement("delivery_boy");

                x.WriteStartElement("name");
                x.WriteString("mourad");
                x.WriteEndElement();

                x.WriteStartElement("area_code");
                x.WriteString("helwan");
                x.WriteEndElement();

                x.WriteStartElement("phone");
                x.WriteString("01232487848");
                x.WriteEndElement();

                x.WriteStartElement("numoforders");
                x.WriteString("4");
                x.WriteEndElement();

                x.WriteEndElement();

                x.WriteEndElement();
                x.WriteEndDocument();
                x.Close();
            }
        }

        private void items()
        {
            
            items i = new items();
            i.add_items();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            current_customer = txt_phone.Text;
            string num_orders = "1";
            string money = "0";
            if (!File.Exists("customer.xml"))
            {
                c.Addnew(txt_name, txt_phone, txt_address, combo_area.SelectedItem, num_orders, money);

                
              
            }
            else
            { 
                bool check = c.search(txt_phone);
                if (!check)
                {
                    c.Add(txt_name, txt_phone, txt_address, combo_area.SelectedItem, num_orders, money);
                  

                }

                MessageBox.Show("Welcome!");
            }
           
            order o = new order();
            o.Show();
        }


       

                   

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart chart = new chart();
            chart.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int max, index;
            List<int> orders = new List<int>();
            List<String> names = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.Load("delivery_boy.xml");
            XmlNodeList list = doc.GetElementsByTagName("delivery_boy");
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList childrens = list[i].ChildNodes;

                names.Add(childrens[0].InnerText);
                orders.Add(Convert.ToInt32(childrens[3].InnerText));

            }
            max = orders.Max();
           index = orders.IndexOf(max);
           MessageBox.Show("Best Delivery Boy is: " + names[index]);
        }

        private void combo_area_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
