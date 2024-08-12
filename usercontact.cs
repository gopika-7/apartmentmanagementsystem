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
    public partial class usercontact : Form
    {
        public usercontact()
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
            LOGIN lOGIN= new LOGIN();
            lOGIN.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            USERHOME1 lOGIN= new USERHOME1();
            lOGIN.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            USERGALLERY1 uSERGALLERY1 = new USERGALLERY1();
            uSERGALLERY1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            USERPAYMENT1 aYMENTDETAILS = new USERPAYMENT1();
            aYMENTDETAILS.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            usercontact Usercontact = new usercontact();
            Usercontact.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            com com = new com();
            com.Show();
            this.Hide();
        }
    }
}
