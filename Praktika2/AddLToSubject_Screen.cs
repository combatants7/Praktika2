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
    public partial class AddLToSubject_Screen : Form
    {
        SubjectRepos repos;
        string con = "Data Source=DESKTOP-0M1N0GR\\SQLEXPRESS;Initial Catalog=PraktikaDB;Integrated Security=True";
        public AddLToSubject_Screen()
        {
            InitializeComponent();
            repos = new SubjectRepos();
            showLecturers();
            showSubjects();
            showLSView();
            showGroups();
        }

        private void LToSubjectBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LIDtxt.Text) && string.IsNullOrEmpty(SIDtxt.Text) && string.IsNullOrEmpty(GIDtxt.Text))
            {
                MessageBox.Show("Fill in all blanks !");
            }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(con))
                {
                    sqlCon.Open();

                    LecturerSubject subject = new LecturerSubject();
                    subject.StaffID = Int32.Parse(LIDtxt.Text.Trim());
                    subject.GroupID = Int32.Parse(SIDtxt.Text.Trim());

                    LecturerSubject subjects = repos.LecturerToSubject(LIDtxt.Text.Trim(), SIDtxt.Text.Trim(),GIDtxt.Text.Trim());
                }
                lecturerListView.DataSource = null;
                showLecturers();
                LecturerSubjectView.DataSource = null;
                showLSView();
                GroupListView.DataSource = null;
                showGroups();
            }
        }

        private void showLecturers()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT StaffID, Name, Lastname FROM [Staff] WHERE Role!='A'", sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lecturerListView.DataSource = dt;
        }
        private void showSubjects()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [StudySubject]", sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            subjectListView.DataSource = dt;
        }
        private void showLSView()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [LecturerSubject]", sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LecturerSubjectView.DataSource = dt;
        }
        private void showGroups()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Group]", sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GroupListView.DataSource = dt;
        }

        private void RemoveLSBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(con);

            try
            {
                sqlCon.Open();
                //SqlCommand cmd = new SqlCommand("DELETE LecturerSubject WHERE SubjectID=@ID", sqlCon);
                //cmd.Parameters.AddWithValue("@ID", lsIDtxt.Text.Trim());
                //cmd.ExecuteNonQuery();

                SqlCommand cmd = new SqlCommand("DELETE [LecturerSubject] WHERE ID=@ID", sqlCon);
                cmd.Parameters.AddWithValue("@ID", lsIDtxt.Text.Trim());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Lecturer Subject Has been deleted");
                sqlCon.Close();


                LecturerSubjectView.DataSource = null;
                showLSView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
