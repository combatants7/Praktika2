using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Praktika2.Models;
using System.Windows.Forms;

namespace Praktika2.Repos
{
    class GroupRepos
    {
        string con = "Data Source=DESKTOP-0M1N0GR\\SQLEXPRESS;Initial Catalog=PraktikaDB;Integrated Security=True";

        private static List<Group> groupList;

        public Group InsertGroup(Group group)
        {

            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Group] WHERE GroupName=@GroupName", sqlCon);
            cmd.Parameters.AddWithValue("@GroupName",group.GroupName);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                MessageBox.Show("The Group Name you chosen already exists, please choose different Group Name !");
                return null;
            }
            dr.Close();
            SqlCommand sql = new SqlCommand("INSERT INTO [Group] (GroupName)" +
                            " VALUES (@GroupName)", sqlCon);
            sql.Parameters.AddWithValue("@GroupName", group.GroupName);

            MessageBox.Show("Group Created Successfuly!");
            MessageBox.Show("Now you can assign students to this group.");

            sql.ExecuteNonQuery();
            sqlCon.Close();
            return group;
        }

    }
}
