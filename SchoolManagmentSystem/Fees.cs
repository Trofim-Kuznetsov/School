using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagmentSystem
{
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
            DisplayFees();
        }

        // cделать фисы и сумму

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= E:\C#\git hub\School\SchoolManagmentSystem\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayFees()
        {
            Con.Open();
            string Query = "Select * from FeesTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FeesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (FName_tb.Text == "" || FAmount_tb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into FeesTbl(Name,Date,Amt) values (@Name,@Date,@Amt)", Con);
                    cmd.Parameters.AddWithValue("@Name", FName_tb.Text);
                    cmd.Parameters.AddWithValue("@Date", FDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Amt", FAmount_tb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fees successfully paid");
                    Con.Close();
                    DisplayFees();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
