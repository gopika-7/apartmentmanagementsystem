using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace apartmentmanagementsystem
{
    public partial class USERPAYMENT1 : Form
    {
        public USERPAYMENT1()
        {
            InitializeComponent();
        }
         private void button6_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gopika.DESKTOP-1PT1MN5\\Desktop\\newproject\\apartmentmanagementsystem\\apartmentmanagementsystem\\apartaddhouse.accdb;Persist Security Info=True");
            string rno = textBox1.Text;
            string paymet = comboBox2.Text;
            string name=label11.Text;
            string rcat=label12.Text;
            string var = label16.Text;
            string price=label13.Text;
            string query = $"INSERT Into paymenthistory(name,rno,rcat,var,paymet,price) VALUES('{name}','{rno}','{rcat}','{var}','{paymet}','{price}')";
            try
            {
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox2.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label16.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LOGIN lOGIN = new LOGIN();
            lOGIN.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            USERHOME1 lOGIN = new USERHOME1();
            lOGIN.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            USERGALLERY1 lOGIN = new USERGALLERY1();
            lOGIN.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            USERPAYMENT1 lOGIN = new USERPAYMENT1();
            lOGIN.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            usercontact User = new usercontact();
            User.Show();
            this.Hide();
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gopika.DESKTOP-1PT1MN5\\Desktop\\newproject\\apartmentmanagementsystem\\apartmentmanagementsystem\\apartaddhouse.accdb;Persist Security Info=True");
            con.Open();
            string rno = textBox1.Text;
             string query = "SELECT * FROM paymentdetails WHERE rno = @rno";
            
            using (OleDbCommand command = new OleDbCommand(query, con))
            {
                command.Parameters.AddWithValue("@rno", rno);
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string name = reader["name"].ToString();
                    string rcat = reader["rcat"].ToString();
                    string var = reader["var"].ToString();
                    string price = reader["price"].ToString();
                    label11.Text = $"{name}";
                    label12.Text = $"{rcat}";
                    label13.Text = $"{price}"; 
                    label16.Text= $"{var}";
                }
                else
                {
                    label14.Text = "Room Number is not found.";
                }

                reader.Close();
                con.Close();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            com com = new com();
            com.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LOGIN log = new LOGIN();
            log.Show();
            this.Hide();
        }
    }
}
