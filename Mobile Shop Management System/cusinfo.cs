using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MshopM
{
    public partial class cusinfo : Form
    {
        public cusinfo()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elite\Documents\Mobile.mdf;Integrated Security=True;Connect Timeout=30");
        private void customer()
        {
            Con.Open();
            String query = "select * from cus ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            cus.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || number.Text == "" || email.Text == "" || address.Text == "" )
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    String sql = "INSERT INTO cus VALUES ('" +
name.Text + "', " +
number.Text + ", '" +
email.Text + ", '" +
address.Text + "')";

                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mobile Added Successfully");
                    Con.Close();
                    customer();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void cus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cus.SelectedRows.Count == 0)
                return;
            name.Text = cus.SelectedRows[0].Cells[0].Value.ToString();
            number.Text = cus.SelectedRows[0].Cells[1].Value.ToString();
            email.Text = cus.SelectedRows[0].Cells[2].Value.ToString();
            address.Text = cus.SelectedRows[0].Cells[3].Value.ToString();
           
        }

        private void cusinfo_Load(object sender, EventArgs e)
        {
            customer();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}


