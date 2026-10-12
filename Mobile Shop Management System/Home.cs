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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Mobile mob = new Mobile();
            mob.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accessories Acc = new Accessories();
            Acc.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bills bill = new Bills();
            bill.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cusinfo cusi = new cusinfo();
            cusi.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
