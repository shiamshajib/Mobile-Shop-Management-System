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
    public partial class Accessories : System.Windows.Forms.Form
    {
        public Accessories()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elite\Documents\Mobile.mdf;Integrated Security=True;Connect Timeout=30");
        private void Apopulate()
        {
            Con.Open();
            String query = "select * from Accessories ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            AccDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        
        private void Accessories_Load(object sender, EventArgs e)
        {
            Apopulate();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            if (Aid.Text == "" || Abrand.Text == "" ||  items.Text =="" || Aprice.Text == "" || Astock.Text == "" )
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    String sql = "INSERT INTO Accessories VALUES (" + Aid.Text + ",'"+Abrand.Text+ "', '" + items.Text + "', " +
Aprice.Text + ",  "+
Astock.Text + " )";

                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Accessories Added Successfully");
                    Con.Close();
                    Apopulate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            Aid.Text = "";
            Abrand.Text = "";
            items.Text = "";
            Astock.Text = "";
            Aprice.Text = "";
        }

        private void AccDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AccDGV.SelectedRows.Count == 0)
                return;
            Aid.Text = AccDGV.SelectedRows[0].Cells[0].Value.ToString();
            Abrand.Text = AccDGV.SelectedRows[0].Cells[1].Value.ToString();
            items.Text = AccDGV.SelectedRows[0].Cells[2].Value.ToString();
            Aprice.Text = AccDGV.SelectedRows[0].Cells[3].Value.ToString();
            Astock.Text = AccDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (Aid.Text == "")
            {
                MessageBox.Show(" Enter the Accessories id  To  delete .");
            }
            else
            {
                try
                {
                    Con.Open();
                    String query = " delete from Accessories where Aid=" + Aid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Accessories data has been deleted.");
                    Con.Close();
                    Apopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (Aid.Text == "" || Abrand.Text == "" || items.Text == "" || Aprice.Text == "" || Astock.Text == "" )
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string sql = "UPDATE Accessories SET Abrand='" + Abrand.Text +
             "', items='" + items.Text +
             "', Aprice='" + Aprice.Text +
             "', Astock=" + Astock.Text +
             " WHERE Aid=" + Aid.Text + ";";

                    SqlCommand cmd = new SqlCommand(sql, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Accessories list Updated Successfully");
                    Con.Close();
                    Apopulate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Aid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
