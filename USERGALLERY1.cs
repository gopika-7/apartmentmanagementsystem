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
    public partial class USERGALLERY1 : Form
    {
        public USERGALLERY1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            USERHOME1 uSERHOME1 = new USERHOME1();
            uSERHOME1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            USERGALLERY1 uSER = new USERGALLERY1();
                uSER.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            com com = new com();
            com.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            usercontact User = new usercontact();
            User.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LOGIN lOGIN = new LOGIN();
            lOGIN.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            USERPAYMENT1 pAYMENTDETAILS = new USERPAYMENT1();
            pAYMENTDETAILS.Show();
            this.Hide();
        }
    }
}
