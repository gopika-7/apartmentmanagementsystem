using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apartmentmanagementsystem
{
    public partial class ADMINCONTACT1 : Form
    {
        public ADMINCONTACT1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("cmd", "/c start https://goo.gl/maps/LpAQ2hkZuPVf5uNXA");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening the link: {ex.Message}");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           LOGIN lOGIN = new LOGIN();
            lOGIN.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ADMINCONTACT1 aDMINCONTACT = new ADMINCONTACT1();   
            aDMINCONTACT.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADMINPAYMENTDETAILS1 aDMINPAYMENTDETAILS = new ADMINPAYMENTDETAILS1();
            aDMINPAYMENTDETAILS.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ADMINADDHOUSE1 aDMINADDHOUSE = new ADMINADDHOUSE1();
            aDMINADDHOUSE.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
           ADMINHOME1 aDMIN1ADDHOUSE = new ADMINHOME1();
            aDMIN1ADDHOUSE.Show();
            this.Hide();
        }

        private void ADMINCONTACT1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            reg reg = new reg();
            reg.Show();
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
    }
}
