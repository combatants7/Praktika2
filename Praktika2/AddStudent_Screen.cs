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
    public partial class AddStudent_Screen : Form
    {
        string con = "Data Source=DESKTOP-0M1N0GR\\SQLEXPRESS;Initial Catalog=PraktikaDB;Integrated Security=True";
        private UserRepos repos;

        public AddStudent_Screen()
        {
            InitializeComponent();
            repos = new UserRepos();
        }

        private void SaveStdntBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(con))
            {
                sqlCon.Open();

                Student user = new Student();
                user.Name = FirstNameTxt.Text.Trim();
                user.Lastname = LastNameTxt.Text.Trim();
                user.Username = FirstNameTxt.Text.Trim();
                user.Password = LastNameTxt.Text.Trim();

                User registeredUser = repos.InsertStudent(user);
            }
        }
    }
}
