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
    class UserRepos
    {
        string con = "Data Source=DESKTOP-0M1N0GR\\SQLEXPRESS;Initial Catalog=PraktikaDB;Integrated Security=True";

        private static List<User> userList;

        // CHECK IF NONSENSE BELOW WORKS
        public Student InsertStudent(Student user)
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [tblStudent] WHERE Username=@Username", sqlCon);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                MessageBox.Show("The Username you chosen already exists, please select different username !");
                return null;
            }

            dr.Close();
            SqlCommand sql = new SqlCommand("INSERT INTO [tblStudent] (Name,Lastname,Username,Password)" +
                            " VALUES (@Name,@Lastname,@Username,@Password)", sqlCon);
            sql.Parameters.AddWithValue("@Name", user.Name);
            sql.Parameters.AddWithValue("@Lastname", user.Lastname);
            sql.Parameters.AddWithValue("@Username", user.Name);
            sql.Parameters.AddWithValue("@Password", user.Lastname);

            MessageBox.Show("Student Registered Successfuly!");
            MessageBox.Show("Now you can assign student to a group.");

            sql.ExecuteNonQuery();
            sqlCon.Close();
            return user;
        }

        public Lecturer InsertLecturer(Lecturer user)
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Staff] WHERE Username=@Username", sqlCon);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                MessageBox.Show("The Username you chosen already exists, please select different username !");
                return null;
            }

            dr.Close();
            SqlCommand sql = new SqlCommand("INSERT INTO [Staff] (Role,Name,Lastname,Username,Password)" +
                            " VALUES (@Role,@Name,@Lastname,@Username,@Password)", sqlCon);
            sql.Parameters.AddWithValue("@Name", user.Name);
            sql.Parameters.AddWithValue("@Lastname", user.Lastname);
            sql.Parameters.AddWithValue("@Username", user.Name);
            sql.Parameters.AddWithValue("@Password", user.Lastname);
            sql.Parameters.AddWithValue("@Role", user.Role);

            MessageBox.Show("Lecturer Registered Successfuly!");
            MessageBox.Show("Now you can assign Lecturer to a subject.");

            sql.ExecuteNonQuery();
            sqlCon.Close();
            return user;
        }

        public User StaffLogin(string Username, string Password)
        {
            Console.WriteLine("check");
            User staffLogin = new User();
            try
            {
                SqlConnection sqlCon = new SqlConnection(con);

                SqlCommand cmd = new SqlCommand("SELECT * FROM [Staff] WHERE Username=@Username AND Password=@Password", sqlCon);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                sqlCon.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = int.Parse(dr["StaffID"].ToString());
                    string role = dr["Role"].ToString();
                    string firstname = dr["Name"].ToString();
                    string lastname = dr["Lastname"].ToString();
                    string username = dr["Username"].ToString();
                    string password = dr["Password"].ToString();


                    staffLogin.ID = id;
                    staffLogin.Role = role;
                    staffLogin.Name = firstname;
                    staffLogin.Lastname = lastname;
                    staffLogin.Username = username;
                    staffLogin.Password = password;

                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            return staffLogin;
        }

        public User StudentLogin(string Username, string Password)
        {
            Console.WriteLine("check");
            User studentLogin = new User();
            try
            {
                SqlConnection sqlCon = new SqlConnection(con);

                SqlCommand cmd = new SqlCommand("SELECT * FROM [tblStudent] WHERE Username=@Username AND Password=@Password", sqlCon);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                sqlCon.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = int.Parse(dr["ID"].ToString());
                    string firstname = dr["Name"].ToString();
                    string lastname = dr["Lastname"].ToString();
                    string username = dr["Username"].ToString();
                    string password = dr["Password"].ToString();

                    studentLogin.ID = id;
                    studentLogin.Name = firstname;
                    studentLogin.Lastname = lastname;
                    studentLogin.Username = username;
                    studentLogin.Password = password;
                    
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            return studentLogin;
        }

        public Student StudentToGroup(int SID, int GID)
        {
            Student sToGroup = new Student();
            SqlConnection sqlCon = new SqlConnection(con);
            try
            {
                sqlCon.Open();
                //SqlCommand cmd = new SqlCommand("SELECT tblStudent.ID, tblStudent.Name, tblStudent.Lastname, Group.Name FROM [tblStudent] INNER JOIN [Group] ON tblStudent.Group_ID = @Group", sqlCon);
                //SqlCommand cmd = new SqlCommand("SELECT * FROM [tblStudent] INNER JOIN [Group] ON tblStudent.Group_Name = Group.Name", sqlCon);
                SqlCommand cmd = new SqlCommand("UPDATE [tblStudent] SET GroupID=@GroupID WHERE ID=@ID", sqlCon);
                cmd.Parameters.AddWithValue("@ID", SID);
                cmd.Parameters.AddWithValue("@GroupID", GID);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    MessageBox.Show("The Group or Student doesnt exist, select a valid Student and Group !");
                    return null;
                }
                dr.Close();
                //cmd = new SqlCommand("INSERT INTO [tblStudent] (Group_ID) VALUES Group.ID WHERE Group.ID=@Group AND tblStudent.Group_ID=@GroupName", sqlCon);
                //cmd.Parameters.AddWithValue("@Group", GID);
                //cmd.Parameters.AddWithValue("@GroupName", SID);

                MessageBox.Show("Student Successfuly added to " + GID + " Group.");
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            return sToGroup;
        }

        public DataTable DisplayStudentMarks(int studentId)
        {
            SqlConnection sqlCon = new SqlConnection(con);
            
            try
            {
                MessageBox.Show(studentId.ToString());
                sqlCon.Open();
                string newSql = "Select tblStudent.ID,[Name], Lastname, FinalGrade, Marks.SubjectID, SubjectName from tblStudent inner join Marks on tblStudent.ID= Marks.StudentID inner join StudySubject on Marks.SubjectID= StudySubject.ID where tblStudent.ID=@Id ORDER BY FinalGrade DESC";
                SqlCommand cmd = new SqlCommand(newSql, sqlCon);
                cmd.Parameters.AddWithValue("@Id", studentId);
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
                dadapter.Fill(dta);

                sqlCon.Close();
                return dta;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
    }

