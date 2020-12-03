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
    public partial class AddGroup_Screen : Form
    {
        string con = "Data Source=DESKTOP-0M1N0GR\\SQLEXPRESS;Initial Catalog=PraktikaDB;Integrated Security=True";
        private GroupRepos repos;
        public AddGroup_Screen()
        {
            InitializeComponent();
            repos = new GroupRepos();
        }

        private void CreateGroupBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(con))
            {
                sqlCon.Open();

                Group group = new Group();
                group.GroupName = GroupNameTxt.Text.Trim();
                Group registerGroup = repos.InsertGroup(group);
                sqlCon.Close();
            }
        }
    }
}
