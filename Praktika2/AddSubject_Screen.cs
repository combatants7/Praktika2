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
    public partial class AddSubject_Screen : Form
    {
        string con = "Data Source=DESKTOP-0M1N0GR\\SQLEXPRESS;Initial Catalog=PraktikaDB;Integrated Security=True";
        SubjectRepos repos;
        public AddSubject_Screen()
        {
            InitializeComponent();
            showSubjects();
            repos = new SubjectRepos();
        }

        private void nSubjectBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(subjectNameTxt.Text.Trim()))
            {
                MessageBox.Show("Fill in all blanks !");
            }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(con))
                {
                    sqlCon.Open();

                    Subject subject = new Subject();
                    subject.Subjectname = subjectNameTxt.Text.Trim();


                    Subject createdSubject = repos.InsertSubject(subject);
                    subjectListView.DataSource = null;
                    showSubjects();
                }
            }
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

    
    }
}
