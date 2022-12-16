using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorldCup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> jerseyNo = new List<int>();
            for(int i = 0; i < 100; i++)
            {
                jerseyNo.Add(i);
            }
            comboBox2.DataSource = jerseyNo;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source =\\sqlexpress;Initial Catalog = WorldCup; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("insert into Player value('"+textBox1.Test+"','"+comboBox1.Text+"', "+Convert.ToInt32(ComboBox2.Text)+",1)",conn);
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
    }
}
