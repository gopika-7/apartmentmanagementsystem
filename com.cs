using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace apartmentmanagementsystem
{
    public partial class com : Form
    {
        public com()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            USERHOME1 home = new USERHOME1();
            home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            USERGALLERY1 uSERGALLERY1 = new USERGALLERY1();
            uSERGALLERY1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            com comm = new com();
            comm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            USERPAYMENT1 uSERPAYMENT1 = new USERPAYMENT1();
            uSERPAYMENT1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            usercontact usercontact = new usercontact();
            usercontact.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LOGIN lOGIN = new LOGIN();
            lOGIN.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gopika.DESKTOP-1PT1MN5\\Desktop\\newproject\\apartmentmanagementsystem\\apartmentmanagementsystem\\apartaddhouse.accdb;Persist Security Info=True");
            string name = textBox1.Text;
            string email = textBox4.Text;
            string complaint = textBox4.Text;
            string query = $"INSERT Into com(name,email,complaint) VALUES('{name}','{email}','{complaint}')";
            try
            {
                OleDbConnection conn = new OleDbConnection();
                con.Open();
                MessageBox.Show("Connection Open");
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Save Data Successfully .....& Connection Closed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
