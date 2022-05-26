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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
            DisplayEvent();
        }
        
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= E:\C#\git hub\School\SchoolManagmentSystem\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayEvent()
        {
            Con.Open();
            string Query = "Select * from EventsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EventsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (EDescTb.Text == "" || EdurationTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into EventsTbl(EDesc,EDate,Eduration) values (@EvDesc,@EvDate,@EvDur)", Con);
                    cmd.Parameters.AddWithValue("@EvDesc", EDescTb.Text);
                    cmd.Parameters.AddWithValue("@EvDate", EDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EvDur", EdurationTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event successfully added");
                    Con.Close();
                    DisplayEvent();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        int Key = 0;

       /* private void EventsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EDescTb.Text = EventsDGV.SelectedRows[0].Cells[0].Value.ToString();
            EDate.Text = EventsDGV.SelectedRows[0].Cells[1].Value.ToString();        
            EdurationTb.Text = EventsDGV.SelectedRows[0].Cells[2].Value.ToString(); 
            if (EDescTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EventsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
       */

        private void Reset()
        {
            EdurationTb.Text = "";
            EDescTb.Text = "";
        }

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
                    SqlCommand cmd = new SqlCommand("delete from eventsTbl where EId=@EKey",Con);
                    cmd.Parameters.AddWithValue("@EKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event successfully deleted");
                    Con.Close();
                    DisplayEvent();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }

}
