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
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gopika.DESKTOP-1PT1MN5\\Desktop\\newproject\\apartmentmanagementsystem\\apartmentmanagementsystem\\apartaddhouse.accdb;Persist Security Info=True");
            string rno = textBox2.Text;
            string name = textBox1.Text;
            string gender = comboBox1.Text;
            string famno = textBox3.Text;
            string rcat = comboBox2.Text;
            string email = textBox4.Text;
            string psw = textBox5.Text; 
            string query = $"INSERT Into reg(rno,name,gender,famno,rcat,email,psw) VALUES('{rno}','{name}','{gender}', '{famno}','{rcat}','{email}','{psw}')";
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

        private void button9_Click(object sender, EventArgs e)
        {
            ADMINADDHOUSE1 aDMINADDHOUSE = new ADMINADDHOUSE1();
            aDMINADDHOUSE.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ADMINHOME1 aDMINHOME = new ADMINHOME1();
            aDMINHOME.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reg re = new reg();
            re.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ten ten = new ten();
            ten.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            acom acom = new acom();
            acom.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ADMINPAYMENTDETAILS1 aDMINPAYMENTDETAILS1 = new ADMINPAYMENTDETAILS1();
            aDMINPAYMENTDETAILS1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ADMINCONTACT1 aDMINCONTACT1 = new ADMINCONTACT1();
            aDMINCONTACT1.Show();
            this.Hide();
        }

        private void reg_Load(object sender, EventArgs e)
        {

        }
    }
}
