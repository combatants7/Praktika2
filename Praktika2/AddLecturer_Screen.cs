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
    public partial class AddLecturer_Screen : Form
    {
        string con = "Data Source=DESKTOP-0M1N0GR\\SQLEXPRESS;Initial Catalog=PraktikaDB;Integrated Security=True";
        private UserRepos repos;
        public AddLecturer_Screen()
        {
            InitializeComponent();
            repos = new UserRepos();
        }

        private void SaveLecturerBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(con))
            {
                sqlCon.Open();

                Lecturer user = new Lecturer();
                user.Name = FirstnameTxt.Text.Trim();
                user.Lastname = LastnameTxt.Text.Trim();
                user.Username = FirstnameTxt.Text.Trim();
                user.Password = LastnameTxt.Text.Trim();
                user.Role = "L";

                User registeredUser = repos.InsertLecturer(user);
            }
        }
    }
}
