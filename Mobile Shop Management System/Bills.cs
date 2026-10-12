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
    public partial class Bills : Form
    {
        public Bills()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elite\Documents\Mobile.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            String query = "select brand,model,price from Mobile ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            MobileDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Apopulate()
        {
            Con.Open();
            String query = "select Abrand,items,Aprice from Accessories ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            AccDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            populate();
            Apopulate();
        }

        private void AccDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productb.Text = AccDGV.SelectedRows[0].Cells[0].Value.ToString() + AccDGV.SelectedRows[0].Cells[1].Value.ToString();
            priceb.Text = AccDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void MobileDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productb.Text = MobileDGV.SelectedRows[0].Cells[0].Value.ToString() + AccDGV.SelectedRows[0].Cells[1].Value.ToString();
            priceb.Text = MobileDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int n = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (quantityb.Text == "" || priceb.Text == "")
            {
                MessageBox.Show("");
            }
            else
            {
                int total = Convert.ToInt32(quantityb.Text) * Convert.ToInt32(priceb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = productb.Text;
                newRow.Cells[2].Value = priceb.Text;
                newRow.Cells[3].Value = quantityb.Text;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);
                n++;

            }
        }
        int prodid, prodqty, prodprice, tottal, os = 60;

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        string prodname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(" Money receipt", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL",new Font("Century Gothic",10,FontStyle.Bold),Brushes.Red,new Point(26,40));
            foreach(DataGridViewRow row in BillDGV.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname =""+ row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                tottal= Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, os));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, os));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120, os));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, os));
                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, os));
                os = os + 20;

            }
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            os = 100;
            n = 0;
        }
        
        private void PRINT_Click(object sender, EventArgs e)
        {
           
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 283, 600);

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }
    }
}
