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
    public partial class chart : MetroFramework.Forms.MetroForm
    {
        public chart()
        {
            InitializeComponent();
        }

        private void chart_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("delivery_boy.xml");
            XmlNodeList list = doc.GetElementsByTagName("delivery_boy");
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList c = list[i].ChildNodes;
                string name = c[0].InnerText;
                int num_of_orders = int.Parse(c[3].InnerText);
                chart1.Series["Delivery Boy"].Points.AddXY(name,num_of_orders);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
