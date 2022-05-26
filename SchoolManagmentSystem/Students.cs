using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SchoolManagmentSystem
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            DisplayStudent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\empty\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayStudent()
        {
            Con.Open();
            string Query = "Select * from StudentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StudentsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void save_button_Click_1(object sender, EventArgs e)
        {
            if (name_tb.Text == "" || fees_tb.Text == "" || address_rtb.Text == "" || gender_cb.SelectedIndex == -1 || class_cb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into StudentTbl(StName,StGen,StDOB,StClass,StFees,StAdd) values (@SName,@SGen,@SDob,@SClass,@SFees,@SAdd)", Con);
                    cmd.Parameters.AddWithValue("@SName", name_tb.Text);
                    cmd.Parameters.AddWithValue("@SGen", gender_cb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDob", dateTimePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", class_cb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SFees", fees_tb.Text);
                    cmd.Parameters.AddWithValue("@SAdd", address_rtb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student successfully added");
                    Con.Close();
                    DisplayStudent();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        

        //private void Students_Load(object sender, EventArgs e)
        //{
        ////    // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDbDataSet.StudentTbl". При необходимости она может быть перемещена или удалена.
        //    this.studentTblTableAdapter.Fill(this.schoolDbDataSet.StudentTbl);
        //}

        int Key = 0;

       /* private void StudentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name_tb.Text = StudentsDGV.SelectedRows[0].Cells[1].Value.ToString();
            gender_cb.SelectedItem = StudentsDGV.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker.Text = StudentsDGV.SelectedRows[0].Cells[3].Value.ToString();
            class_cb.SelectedItem = StudentsDGV.SelectedRows[0].Cells[4].Value.ToString();
            address_rtb.Text = StudentsDGV.SelectedRows[0].Cells[5].Value.ToString();
            fees_tb.Text = StudentsDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (name_tb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(StudentsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        } */

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Student");
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("delete from studentTbl where StId=@StKey");
                    cmd.Parameters.AddWithValue("@StKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student successfully deleted");
                    DisplayStudent();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
    }
}
