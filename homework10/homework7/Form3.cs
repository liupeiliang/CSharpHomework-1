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
    public partial class Form3 : Form
    {
        Form1 form1 = new Form1();
        public string oldId { get; set; }
        public string newClient { get; set; }
        public string newName { get; set; }
        public string newId { get; set; }
        public int newPrice { get; set; }
        public Form3(BindingList<Order> orderObject)
        {
            InitializeComponent();
            form1.service.orderObject = orderObject;
            textBox1.DataBindings.Add("Text", this, "newId");
            textBox2.DataBindings.Add("Text", this, "newName");
            textBox3.DataBindings.Add("Text", this, "newClient");
            textBox4.DataBindings.Add("Text", this, "newPrice");
            form1.orderBindingSource.DataSource = form1.service.orderObject;
            orderBindingSource.DataSource = form1.service.orderObject;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            oldId = Convert.ToString(dataGridView1.CurrentRow.Cells["id"].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = form1.service.changeOrder(oldId, newClient, newName, newId, newPrice);
        }
    }
}
