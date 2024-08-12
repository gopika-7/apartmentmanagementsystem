using apartmentmanagementsystem;
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
namespace apartmentmanagementsystem
{
    public partial class ADMINPAYMENTDETAILS1 : Form
    {
        public ADMINPAYMENTDETAILS1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ADMINHOME1 aDMINHOME1 = new ADMINHOME1();
            aDMINHOME1.Show();
            this.Hide();
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

        private void button8_Click(object sender, EventArgs e)
        {
            ADMINPAYMENTDETAILS1 aDMINPAYMENTDETAILS = new ADMINPAYMENTDETAILS1();
            aDMINPAYMENTDETAILS.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMINADDHOUSE1 aDMINADDHOUSE = new ADMINADDHOUSE1();
            aDMINADDHOUSE.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr = cmd.ExecuteReader();
            dataGridView1.DataSource = dr;

        }

        
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.paymenthistoryTableAdapter.FillBy(this.apartaddhouseDataSet3.paymenthistory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ADMINPAYMENTDETAILS1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartaddhouseDataSet3.paymenthistory' table. You can move, or remove it, as needed.
            this.paymenthistoryTableAdapter.Fill(this.apartaddhouseDataSet3.paymenthistory);

        }

        private void button1_Click(object sender, EventArgs e)
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
