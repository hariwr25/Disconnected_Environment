using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environment
{
    public partial class Form2 : Form
    {
        private string stringConnection = "data source=LAPTOP-LJKOSKIC;" + "database=DBact6;User ID=sa;Password=Hwr25112001";
        SqlConnection koneksi;

        private void refreshform()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
        }
        public Form2()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
