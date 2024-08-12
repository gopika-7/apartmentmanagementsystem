using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apartmentmanagementsystem
{
    public partial class ten : Form
    {
        public ten()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ten_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartaddhouseDataSet3.reg' table. You can move, or remove it, as needed.
            this.regTableAdapter.Fill(this.apartaddhouseDataSet3.reg);
            // TODO: This line of code loads data into the 'apartaddhouseDataSet3.reg' table. You can move, or remove it, as needed.
            this.regTableAdapter.Fill(this.apartaddhouseDataSet3.reg);
            // TODO: This line of code loads data into the 'apartaddhouseDataSet3.reg' table. You can move, or remove it, as needed.
            this.regTableAdapter.Fill(this.apartaddhouseDataSet3.reg);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reg reg = new reg();
            reg.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ADMINHOME1 aDMINHOME1 = new ADMINHOME1();
            aDMINHOME1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ten te = new ten();
            te.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            acom acom = new acom();
            acom.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ADMINADDHOUSE1 aDMINADDHOUSE1 = new ADMINADDHOUSE1();
            aDMINADDHOUSE1.Show();
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

        private void button6_Click(object sender, EventArgs e)
        {
            LOGIN lOGIN = new LOGIN();
            lOGIN.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
