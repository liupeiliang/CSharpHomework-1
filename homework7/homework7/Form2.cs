using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using homework6;
namespace homework7
{
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1();
        public string client { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public int price { get; set; }
        public Form2(BindingList<Order> orderObject)
        {
            InitializeComponent();
            form1.service.orderObject = orderObject;
            textBox1.DataBindings.Add("Text", this, "id");
            textBox2.DataBindings.Add("Text", this, "name");
            textBox3.DataBindings.Add("Text", this, "client");
            textBox4.DataBindings.Add("Text", this, "price");
            form1.orderBindingSource.DataSource = form1.service.orderObject;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.service.addOrder(client, name, id, price);
        }
    }
}
