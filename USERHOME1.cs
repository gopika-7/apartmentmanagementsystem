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
    public partial class USERHOME1 : Form
    {
        public USERHOME1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           USERHOME1 uSERHOME1 = new USERHOME1();
            uSERHOME1.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LOGIN lOGIN =new LOGIN();
            lOGIN.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            usercontact User = new usercontact();
            User.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            USERPAYMENT1 uSERPAYMENT1 = new USERPAYMENT1();
            uSERPAYMENT1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            USERGALLERY1 uSERGALLERY1 = new USERGALLERY1();
            uSERGALLERY1.Show();
            this.Hide();
        }
    }
}
