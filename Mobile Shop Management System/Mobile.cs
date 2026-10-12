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
    public partial class Mobile : System.Windows.Forms.Form
    {
        public Mobile()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elite\Documents\Mobile.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            String query = "select * from Mobile ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            MobileDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
       
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || brand.Text == "" || model.Text == "" || price.Text == "" || stock.Text == "" || mp.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    String sql = "INSERT INTO Mobile VALUES (" + id.Text + ", '" +
brand.Text + "', '" +
model.Text + "', " +
price.Text + ", " +
stock.Text + ", '" +
ram.SelectedItem.ToString() + "', '" +
rom.SelectedItem.ToString() + "', " +
mp.Text + ")";

                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mobile Added Successfully");
                    Con.Close();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Mobile_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void MobileDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MobileDGV.SelectedRows.Count == 0)
                return;
            id.Text = MobileDGV.SelectedRows[0].Cells[0].Value.ToString();
            model.Text = MobileDGV.SelectedRows[0].Cells[1].Value.ToString();
            brand.Text = MobileDGV.SelectedRows[0].Cells[2].Value.ToString();
            price.Text = MobileDGV.SelectedRows[0].Cells[3].Value.ToString();
            stock.Text = MobileDGV.SelectedRows[0].Cells[4].Value.ToString();
            ram.Text = MobileDGV.SelectedRows[0].Cells[5].Value.ToString();
            rom.Text = MobileDGV.SelectedRows[0].Cells[6].Value.ToString();
            mp.Text = MobileDGV.SelectedRows[0].Cells[7].Value.ToString();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            id.Text = "";
            model.Text = "";
            brand.Text = "";
            price.Text = "";
            ram.Text = "";
            rom.Text = "";
            stock.Text = "";
            mp.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                MessageBox.Show(" Enter the mobile id  To  delete .");
            }
            else
            {
                try
                {
                    Con.Open();
                    String query = " delete from Mobile where id=" + id.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mobile has been deleted.");
                    Con.Close();
                    populate();
                }catch(Exception Ex)
                {

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || brand.Text == "" || model.Text == "" || price.Text == "" || stock.Text == "" || mp.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    String sql = "Update Mobile set brand='" + brand.Text + "',model='" + model.Text + "',price='" + price.Text + "',stock='" + stock.Text + "',ram=" + ram.SelectedItem.ToString() + ",rom=" + rom.SelectedItem.ToString() + ",mp=" + mp.Text + " where id=" + id.Text + "; ";


                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mobile Updated Successfully");
                    Con.Close();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        
    }
}
