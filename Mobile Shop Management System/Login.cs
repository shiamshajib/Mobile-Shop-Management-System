using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MshopM
{
    public partial class Login : System.Windows.Forms.Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Uid.Text == ""|| Pass.Text == "")
            {
                MessageBox.Show("Enter User Name And Password");
            }
            else if(Uid.Text == "Shiam" && Pass.Text == "Shajib") {

                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else if (Uid.Text == "Hridi" && Pass.Text == "Zaman")
            {
                Home home = new Home();
                home.Show();
                this.Hide();

            }
            else if (Uid.Text == "Tasnia" && Pass.Text == "Nishat")
            {
                Home home = new Home();
                home.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show(" Worng User Name or Password ");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
