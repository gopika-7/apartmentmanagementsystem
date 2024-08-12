using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace apartmentmanagementsystem
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string uname = textBox1.Text;
            string pass = textBox2.Text;
            if (uname == "gopika" && pass == "gopika77")
            {
                ADMINHOME1 f = new ADMINHOME1();
                f.Show();
                this.Hide();
            }
            else if (uname == "srividhya" && pass == "srividhya77")
            {
                USERHOME1 anotherform = new USERHOME1();
                anotherform.Show();
                this.Hide();

            }
            else
            {
                string message = "Contact Staff to register your login address";
                string title = "User login not found";
                MessageBox.Show(message, title);
            }
        }
    }
}
