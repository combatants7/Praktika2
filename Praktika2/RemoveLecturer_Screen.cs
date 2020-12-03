using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Praktika2.Models;
using Praktika2.Repos;
using System.Data.SqlClient;

namespace Praktika2
{
    public partial class RemoveLecturer_Screen : Form
    {
        string con = "Data Source=DESKTOP-0M1N0GR\\SQLEXPRESS;Initial Catalog=PraktikaDB;Integrated Security=True";

        public RemoveLecturer_Screen()
        {
            InitializeComponent();
            showData();
        }

        private void RemoveLecturerBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(con);

            try
            {

                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [LecturerSubject] WHERE StaffID=@ID", sqlCon);
                cmd.Parameters.AddWithValue("@ID", removeLTxt.Text.Trim());
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("DELETE FROM [Staff] WHERE StaffID=@ID", sqlCon);
                cmd.Parameters.AddWithValue("@ID", removeLTxt.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lecturer Has been deleted");
                sqlCon.Close();

                LecturerInfoGrid.DataSource = null;
                showData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showData()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Staff] WHERE Role!='A'", sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LecturerInfoGrid.DataSource = dt;
        }

        private void RemoveLecturer_Screen_Load(object sender, EventArgs e)
        {

        }
    }
}
