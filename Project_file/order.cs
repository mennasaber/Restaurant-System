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
    public partial class order : MetroFramework.Forms.MetroForm
    {
        double bill = 0;


        public order()
        {
            InitializeComponent();


            listBox1.Items.Add("name" + "     " + "price" + "     " + "quantity");

        }

        private void order_Load(object sender, EventArgs e)
        {


            Load_item();
        }

        private void Load_item()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("item.xml");
            XmlNodeList list = doc.GetElementsByTagName("item");
            for (int j = 0; j < list.Count; j++)
            {

                XmlNodeList childerns = list[j].ChildNodes;
                item i = new item(int.Parse(childerns[0].InnerText), childerns[1].InnerText, int.Parse(childerns[2].InnerText));
                flowLayoutPanel1.Controls.Add(i);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getName_price();
            count_total_price();

        }

        public void count_total_price()
        {
            string id = textBox1.Text;
            float quant = float.Parse(textBox2.Text);
            float price = 0;
            bool found = false;

            XmlDocument doc = new XmlDocument();
            doc.Load("item.xml");
            XmlNodeList list = doc.GetElementsByTagName("item");

            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList childrens = list[i].ChildNodes;
                string id_xml = childrens[0].InnerText;

                if (id == id_xml)
                {
                    found = true;
                    price = float.Parse(childrens[2].InnerText);

                }
            }


            if (found)
            {
                bill += price * quant;
            }
            else
            {
                MessageBox.Show("This ID isn't Exist, Please Enter Valid id ");
            }
            textBox1.Clear();
            textBox2.Clear();


        }
        public void getName_price()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("item.xml");
            XmlNodeList list = doc.GetElementsByTagName("item");



            for (int i = 0; i < list.Count; i++)
            {

                XmlNodeList it = list[i].ChildNodes;


                string idValue = it[0].InnerText;



                if (idValue.Equals(textBox1.Text))
                {

                    String nameValue = it[1].InnerText;
                    String priceValue = it[2].InnerText;
                    listBox1.Items.Add(nameValue + "        " + priceValue + "         " + textBox2.Text);
                    int ordered = int.Parse(it[3].InnerText);
                    ordered++;
                    it[3].InnerText = ordered.ToString();
                }


            }
            doc.Save("item.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            listBox1.Items.Add("Total Price =" + bill);
            XmlDocument doc = new XmlDocument();
            doc.Load("customer.xml");
            XmlNodeList list = doc.GetElementsByTagName("customer");



            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList c = list[i].ChildNodes;
                double discount = 0;
                string phoneValue = c[1].InnerText;
                double money = double.Parse(c[5].InnerText);
                string area_code = c[3].InnerText;
                int num_orders = int.Parse(c[4].InnerText);
                if (phoneValue.Equals(Form1.current_customer))
                {
                    if (num_orders > 3)
                    {
                        MessageBox.Show("Your Discount is 5%");
                        discount = bill * 0.05;
                        bill = bill - (bill * 0.05);
                        listBox1.Items.Add("With Discount  =" + bill);
                        money += bill;
                    }
                    
                    else
                    {
                        money += bill;
                        discount = 0;
                      
                    }
                        c[5].InnerText = money.ToString();
                        c[6].InnerText = discount.ToString();
                    delivery_boy b = new delivery_boy();
                    b.assign_delivery_boy(area_code);
                }
            }
            doc.Save("customer.xml");
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            MessageBox.Show("Your Order Has Been Submitted Successfully");
        }

       /* private void assign_delivery_boy(string area_code)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("delivery.xml");
            XmlNodeList list = doc.GetElementsByTagName("delivery");
            for(int i =0;i<list.Count;i++)
            {
                XmlNodeList c = list[i].ChildNodes;
                if(c[0].InnerText==area_code)
                {
                    int num = int.Parse(c[3].InnerText);
                    num++;
                    c[3].InnerText = num.ToString();
                }
            }
            doc.Save("delivery.xml");

            XmlDocument doc2 = new XmlDocument();
            doc.Load("delivery_boy.xml");
            XmlNodeList list2 = doc.GetElementsByTagName("delivery_boy");
            for (int i = 0; i < list2.Count; i++)
            {
                XmlNodeList c = list2[i].ChildNodes;
                if (c[1].InnerText == area_code)
                {
                    int num = int.Parse(c[3].InnerText);
                    num++;
                    c[3].InnerText = num.ToString();
                }
            }
            doc.Save("delivery_boy.xml");
        }*/

        private void button3_Click(object sender, EventArgs e)
        {
            recommended_items re = new recommended_items();
                re.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
