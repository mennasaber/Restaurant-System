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
namespace Project_file
{
    public partial class recommended_items : MetroFramework.Forms.MetroForm
    {
        public recommended_items()
        {
            InitializeComponent();
        }

        private void recommended_items_Load(object sender, EventArgs e)
        {
            int max,index;
            List<String> id = new List<string>();
            List<String> name = new List<string>();
            List<String> price = new List<string>();
            List<int> ordered = new List<int>();
            XmlDocument doc = new XmlDocument();
            doc.Load("item.xml");
            XmlNodeList list = doc.GetElementsByTagName("item");
            for(int i = 0; i < list.Count; i++)
            {
                XmlNodeList childrens = list[i].ChildNodes;
                id.Add(childrens[0].InnerText);
                name.Add(childrens[1].InnerText);
                price.Add(childrens[2].InnerText);
                ordered.Add(int.Parse(childrens[3].InnerText));
            }
           
                max = ordered.Max();
                index = ordered.IndexOf(max);
                label1.Text=id[index];
                label3.Text = name[index];
                label5.Text = price[index];
                label15.Text = ordered[index].ToString();

                id.RemoveAt(index);
                name.RemoveAt(index);
                price.RemoveAt(index);
                ordered.RemoveAt(index);
               index = ordered.IndexOf(ordered.Max());
                label7.Text = id[index];
               label6.Text = name[index];
               label9.Text = price[index];
               label17.Text = ordered[index].ToString();

                id.RemoveAt(index);
                name.RemoveAt(index);
                price.RemoveAt(index);
                ordered.RemoveAt(index);
                index = ordered.IndexOf(ordered.Max());
                label10.Text = id[index];
                label12.Text = name[index];
                label13.Text = price[index];
                label18.Text = ordered[index].ToString();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
