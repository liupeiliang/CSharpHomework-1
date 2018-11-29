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
    public partial class Form1 : Form
    {
        public OrderService service = new OrderService();
        public string KeyWord { get; set; }
        public string delId;

        public Form1()
        {
            InitializeComponent();

            orderBindingSource.DataSource = service.orderObject;
            textBox1.DataBindings.Add("Text", this, "KeyWord");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            delId = Convert.ToString(dataGridView1.CurrentRow.Cells["id"].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = service.searchOrder(Convert.ToInt32(KeyWord));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            service.deleteOrder(Convert.ToInt32(delId));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(service.orderObject);
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(service.orderObject);
            form3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            service.Export();
        }
    }
}
