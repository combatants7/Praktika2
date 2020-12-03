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
    public partial class AddSToGroup_Screen : Form
    {
        UserRepos repos;
        string con = "Data Source=DESKTOP-0M1N0GR\\SQLEXPRESS;Initial Catalog=PraktikaDB;Integrated Security=True";

        public AddSToGroup_Screen()
        {
            InitializeComponent();
            repos = new UserRepos();
            showStudents();
            showGroups();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SIDtxt.Text) && string.IsNullOrEmpty(GIDtxt.Text))
            {
                MessageBox.Show("Fill in all blanks !");
            }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(con))
                {
                    sqlCon.Open();

                    Student student = new Student();
                    student.ID = Int32.Parse(SIDtxt.Text.Trim());
                    student.GroupID = Int32.Parse(GIDtxt.Text.Trim());

                    Student insertGrop = repos.StudentToGroup(student.ID, student.GroupID);
                }

                studentListView.DataSource = null;
                showStudents();
            }
        }

        private void showStudents()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT ID, GroupID, Name, Lastname FROM [tblStudent]", sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            studentListView.DataSource = dt;
        }
        private void showGroups()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Group]", sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            groupListView.DataSource = dt;

        }
    }
}
