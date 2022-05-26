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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        readonly SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= E:\C#\git hub\School\SchoolManagmentSystem\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
        
        private void CountStudents()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Count(*) from StudentTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountTeachers()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Count(*) from TeacherTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TeachersLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountEvents()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Count(*) from EventsTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            EventsLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            CountEvents();
            CountTeachers();
            CountStudents();
        }
    }

}
