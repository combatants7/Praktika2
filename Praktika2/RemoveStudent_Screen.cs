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
    public partial class RemoveStudent_Screen : Form
    {
        string con = "Data Source=DESKTOP-0M1N0GR\\SQLEXPRESS;Initial Catalog=PraktikaDB;Integrated Security=True";
        
        public RemoveStudent_Screen()
        {
            InitializeComponent();
            showData();
        }

        private void removeSBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(con);

            try
            {

                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("DELETE [Marks] WHERE StudentID=@ID", sqlCon);
                cmd.Parameters.AddWithValue("@ID", removeSTxt.Text.Trim());
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("DELETE FROM [tblStudent] WHERE ID=@ID", sqlCon);
                cmd.Parameters.AddWithValue("@ID", removeSTxt.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Has been deleted");
                sqlCon.Close();

                StudentInfoGrid.DataSource = null;
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
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [tblStudent]",sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StudentInfoGrid.DataSource = dt;
        }
    }
}
