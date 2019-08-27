using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_file
{
    public partial class item : UserControl
    {
        private int id;
        private double price;
        private string name;
        public item(int id, string name, double price)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.price = price;
            load_data();
        }

        private void load_data()
        {
            label1.Text = id.ToString();
            label2.Text = name;
            label3.Text = price.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
