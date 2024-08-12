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
    public partial class ADMINADDHOUSE1 : Form
    {
        public ADMINADDHOUSE1()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            LOGIN lOGIN = new LOGIN();
            lOGIN.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADMINHOME1 aDMINHOME1 = new ADMINHOME1();
            aDMINHOME1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADMINADDHOUSE1 aDMINADDHOUSE = new ADMINADDHOUSE1();
            aDMINADDHOUSE.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ADMINPAYMENTDETAILS1 aDMINPAYMENTDETAILS = new ADMINPAYMENTDETAILS1();
            aDMINPAYMENTDETAILS.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ADMINCONTACT1 aDMINCONTACT = new ADMINCONTACT1();
            aDMINCONTACT.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gopika.DESKTOP-1PT1MN5\\Desktop\\newproject\\apartmentmanagementsystem\\apartmentmanagementsystem\\apartaddhouse.accdb;Persist Security Info=True");
            string rno = textBox1.Text;
            string name = textBox3.Text;
            string rcat = comboBox1.Text;
            string var = comboBox2.Text;
            string price = textBox2.Text;
            string query = $"INSERT Into paymentdetails(name,rno,rcat,price,var) VALUES('{name}','{rno}','{rcat}', '{price}', '{var}')";
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

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            reg reg = new reg();
            reg.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ten ten = new ten();
            ten.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            acom acom = new acom();
            acom.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
