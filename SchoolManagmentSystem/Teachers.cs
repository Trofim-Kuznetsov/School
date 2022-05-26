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

namespace SchoolManagmentSystem
{
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
            DisplayTeachers();
        }



        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= E:\C#\git hub\School\SchoolManagmentSystem\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayTeachers()
        {
            Con.Open();
            string Query = "Select * from TeacherTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TeachersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (Tname_tb.Text == "" || TPhone_tb.Text == "" || address_rtb.Text == "" || Tgender_cb.SelectedIndex == -1 || TSub_tb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into TeacherTbl(TName,TGen,TPhone,TSub,TAdd,TDOB) values (@TName,@TGen,@TPhone,@TSub,@TAdd,@TDOB)", Con);
                    cmd.Parameters.AddWithValue("@TName", Tname_tb.Text);
                    cmd.Parameters.AddWithValue("@TGen", Tgender_cb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TPhone", TPhone_tb.Text);
                    cmd.Parameters.AddWithValue("@TSub", TSub_tb.Text);
                    cmd.Parameters.AddWithValue("@TAdd", address_rtb.Text);
                    cmd.Parameters.AddWithValue("@TDOB", dateTimePicker.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher successfully added");
                    Con.Close();
                    DisplayTeachers();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        

        private void Reset()
        {
            Tname_tb.Text = "";
            TSub_tb.Text = "";
            Tgender_cb.SelectedIndex = 0;
            address_rtb.Text = "";
            TPhone_tb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
        int Key = 0;

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
                    SqlCommand cmd = new SqlCommand("delete from teacherTbl where StId=@StKey");
                    cmd.Parameters.AddWithValue("@StKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher deleted");
                    DisplayTeachers();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        
    }
}

