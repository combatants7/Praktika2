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
using Praktika2.Models;
using Praktika2.Repos;

namespace Praktika2
{
    public partial class RemoveSubject_Screen : Form
    {
        string con = "Data Source=DESKTOP-0M1N0GR\\SQLEXPRESS;Initial Catalog=PraktikaDB;Integrated Security=True";
        public RemoveSubject_Screen()
        {
            InitializeComponent();
            showData();
        }

        private void deleteSubjectBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(con);

            try
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("DELETE LecturerSubject WHERE SubjectID=@ID", sqlCon);
                cmd.Parameters.AddWithValue("@ID", subjectIDtxt.Text.Trim());
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("DELETE [Marks] WHERE SubjectID=@ID", sqlCon);
                cmd.Parameters.AddWithValue("@ID", subjectIDtxt.Text.Trim());
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("DELETE [StudySubject] WHERE ID=@ID", sqlCon);
                cmd.Parameters.AddWithValue("@ID", subjectIDtxt.Text.Trim());
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Subject Has been deleted");
                sqlCon.Close();
                

                subjectListView.DataSource = null;
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
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [StudySubject]", sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            subjectListView.DataSource = dt;
        }
    }
}
