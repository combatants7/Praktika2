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


namespace Praktika2
{
    public partial class RemoveGroup_Screen : Form
    {
        string con = "Data Source=DESKTOP-0M1N0GR\\SQLEXPRESS;Initial Catalog=PraktikaDB;Integrated Security=True";
        public RemoveGroup_Screen()
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

                SqlCommand cmd = new SqlCommand("UPDATE [tblStudent] SET GroupID=NULL WHERE GroupID=@ID", sqlCon);
                cmd.Parameters.AddWithValue("@ID", removeGTxt.Text.Trim());
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("UPDATE [LecturerSubject] SET GroupID=NULL WHERE GroupID=@ID", sqlCon);
                cmd.Parameters.AddWithValue("@ID", removeGTxt.Text.Trim());
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("DELETE FROM [Group] WHERE ID=@ID", sqlCon);
                cmd.Parameters.AddWithValue("@ID", removeGTxt.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Group Has been deleted");
                sqlCon.Close();

                GroupInfoGrid.DataSource = null;
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
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Group]", sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GroupInfoGrid.DataSource = dt;
        }
    }
}
