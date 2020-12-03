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
    class SubjectRepos
    {
        string con = "Data Source=DESKTOP-0M1N0GR\\SQLEXPRESS;Initial Catalog=PraktikaDB;Integrated Security=True";

        private static List<Subject> subjectList;

        public Subject InsertSubject(Subject subject)
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [StudySubject] WHERE SubjectName=@Name", sqlCon);
            cmd.Parameters.AddWithValue("@Name", subject.Subjectname);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                MessageBox.Show("The Subject Name you chosen already exists, please select different Subject Name !");
                return null;
            }

            dr.Close();
            SqlCommand sql = new SqlCommand("INSERT INTO [StudySubject] (SubjectName)" +
                            " VALUES (@Name)", sqlCon);
            sql.Parameters.AddWithValue("@Name", subject.Subjectname);
           

            MessageBox.Show("Subject Created Successfuly!");
            MessageBox.Show("Now you can assign Lecturer to this Subject.");

            sql.ExecuteNonQuery();
            sqlCon.Close();
            return subject;
        }
        public LecturerSubject LecturerToSubject(string LID, string SID, string GID)
        {
            LecturerSubject ltoGroup = new LecturerSubject();
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            try {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [LecturerSubject] WHERE StaffID=@LID AND SubjectID=@SID AND GroupID=@GID", sqlCon);
            cmd.Parameters.AddWithValue("@LID", LID);
            cmd.Parameters.AddWithValue("@SID", SID);
            cmd.Parameters.AddWithValue("@GID", GID);

                SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                MessageBox.Show("This Already Exists !");
                return null;
            }
                dr.Close();

                cmd = new SqlCommand("SELECT * FROM [Group] WHERE ID=@GID", sqlCon);
                cmd.Parameters.AddWithValue("@GID", GID);
                dr = cmd.ExecuteReader();
                if(dr.Read()==false)
                {
                    MessageBox.Show("Invalid Group Value");
                    return null;
                }
                dr.Close();

                cmd = new SqlCommand("SELECT * FROM [Staff] WHERE StaffID=@LID AND StaffID!=1", sqlCon);
                cmd.Parameters.AddWithValue("@LID", LID);
                dr = cmd.ExecuteReader();
                if (dr.Read() == false)
                {
                    MessageBox.Show("Invalid Lecturer Value");
                    return null;
                }
                dr.Close();

                cmd = new SqlCommand("SELECT * FROM [StudySubject] WHERE ID=@SID", sqlCon);
                cmd.Parameters.AddWithValue("@SID", SID);
                dr = cmd.ExecuteReader();
                if (dr.Read() == false)
                {
                    MessageBox.Show("Invalid Subject Value");
                    return null;
                }
                dr.Close();

                cmd = new SqlCommand("INSERT INTO [LecturerSubject] (StaffID,SubjectID,GroupID) VALUES(@LID,@SID,@GID)",sqlCon);
                cmd.Parameters.AddWithValue("@LID", LID);
                cmd.Parameters.AddWithValue("@SID", SID);
                cmd.Parameters.AddWithValue("@GID", GID);
                cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            return ltoGroup;
        }
       /* public LecturerSubject SubjectToGroup(LecturerSubject subject)
        {
            LecturerSubject subjects = new LecturerSubject();
            SqlConnection sqlCon = new SqlConnection(con);
            try
            {
                sqlCon.Open();
                //SqlCommand cmd = new SqlCommand("SELECT tblStudent.ID, tblStudent.Name, tblStudent.Lastname, Group.Name FROM [tblStudent] INNER JOIN [Group] ON tblStudent.Group_ID = @Group", sqlCon);
                //SqlCommand cmd = new SqlCommand("SELECT * FROM [tblStudent] INNER JOIN [Group] ON tblStudent.Group_Name = Group.Name", sqlCon);
                //SqlCommand cmd = new SqlCommand("INSERT [StudySubject] SET GroupID=@GroupID, StudentID=@StudentID WHERE ID=@ID", sqlCon);
                SqlCommand cmd = new SqlCommand("INSERT INTO [StudySubject] (GroupID,StudentID,SubjectID) VALUES (@StudentID,@GroupID,@ID)", sqlCon);
                cmd.Parameters.AddWithValue("@StudentID",subjects.StaffID);
                cmd.Parameters.AddWithValue("@GroupID", subjects.GroupID);
                cmd.Parameters.AddWithValue("@ID", subjects.ID);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    MessageBox.Show("The Group or Study Subject doesnt exist, select a valid Study Subject and Group !");
                    return null;
                }
                dr.Close();
                //cmd = new SqlCommand("INSERT INTO [tblStudent] (Group_ID) VALUES Group.ID WHERE Group.ID=@Group AND tblStudent.Group_ID=@GroupName", sqlCon);
                //cmd.Parameters.AddWithValue("@Group", GID);
                //cmd.Parameters.AddWithValue("@GroupName", SID);

                MessageBox.Show("Study Subject Successfuly added to " + subjects.GroupID + " Group.");
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            return subjects;
        }*/
       public List<Group> LecturerGroup (int LecturerID)
        {
            
            List<Group> groupList = new List<Group>();
            try
            {
                SqlConnection  sqlCon= new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("Select [Group].ID,GroupName from [Group] inner join LecturerSubject on [Group].ID=LecturerSubject.GroupID where StaffID=@ID", sqlCon);
                cmd.Parameters.AddWithValue("@ID", LecturerID);
                sqlCon.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int groupId = int.Parse(reader["ID"].ToString());
                    string Name = reader["GroupName"].ToString();
                    Group newGroup = new Group();
                    newGroup.GroupID = groupId;
                    newGroup.GroupName = Name;
                    groupList.Add(newGroup);
                }
                sqlCon.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                return null;
            }

            return groupList;
        }
        public List<Subject> LecturerSubjectList(int LecturerID)
        {
            
            List<Subject> subjectList = new List<Subject>();
            try
            {
                SqlConnection sqlCon = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("Select StudySubject.ID,SubjectName from StudySubject inner join LecturerSubject on StudySubject.ID=LecturerSubject.SubjectID where StaffID=@ID", sqlCon);
                cmd.Parameters.AddWithValue("@ID", LecturerID);
                sqlCon.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int SubjectId = int.Parse(reader["ID"].ToString());
                    string Title = reader["SubjectName"].ToString();
                    Subject nSubject = new Subject();
                    nSubject.ID = SubjectId;
                    nSubject.Subjectname = Title;
                    subjectList.Add(nSubject);
                }
                sqlCon.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                return null;
            }

            return subjectList;
        }

        public DataTable DisplayGrades(int SubjectID, int GroupID)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();
                string newSql = "Select Marks.ID,SubjectName,[Name],Lastname,FinalGrade from Marks inner join tblStudent on Marks.StudentID=tblStudent.ID inner join StudySubject on Marks.SubjectID = StudySubject.ID where StudySubject.ID=@SubjectID and tblStudent.GroupID=@GroupID";
                SqlCommand cmd = new SqlCommand(newSql, sqlCon);
                cmd.Parameters.AddWithValue("@SubjectID", SubjectID);
                cmd.Parameters.AddWithValue("@GroupID", GroupID);
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
                dadapter.Fill(dta);

                sqlCon.Close();
                return dta;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<Student> GetStudentsOfGroup(int GroupID)
        {
            List<Student> studentsList = new List<Student>();
            Console.WriteLine(GroupID);
            try
            {
                SqlConnection sqlCon = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("Select tblStudent.ID,Name,Lastname from tblStudent inner join [Group] on tblStudent.GroupID=[Group].ID where tblStudent.GroupID=@ID", sqlCon);
                cmd.Parameters.AddWithValue("@ID", GroupID);
                sqlCon.Open();
                SqlDataReader reader = cmd.ExecuteReader();//execute command and read rows of data that we get
                while (reader.Read())//while reader can read, while there are rows of data that it can read
                {
                    int StudentId = int.Parse(reader["ID"].ToString());
                    string FirstName = reader["Name"].ToString();
                    string LastName = reader["Lastname"].ToString();
                    Student newStudent = new Student();
                    newStudent.ID = StudentId;
                    newStudent.Name = FirstName;
                    newStudent.Lastname = LastName;
                    studentsList.Add(newStudent);
                }

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                return null;
            }
            return studentsList;
        }

        public void InsertGrade(Marks mark)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("Insert into Marks(StudentID,SubjectID,FinalGrade) VALUES(@StudentID,@SubjectID,@FinalGrade)", sqlCon);
                cmd.Parameters.AddWithValue("@StudentID", mark.StudentID);
                cmd.Parameters.AddWithValue("@SubjectID", mark.SubjectID);
                cmd.Parameters.AddWithValue("@FinalGrade", mark.FinalGrade);

                sqlCon.Open();
                cmd.ExecuteNonQuery();
                sqlCon.Close();

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }
        public void UpdateMark(Marks marks)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(con);
                SqlCommand cmd = new SqlCommand("Update Marks SET FinalGrade=@FinalGrade WHERE ID=@MarkId", sqlCon);
                cmd.Parameters.AddWithValue("@FinalGrade", marks.FinalGrade);
                cmd.Parameters.AddWithValue("@MarkID", marks.MarkID);
                sqlCon.Open();
                cmd.ExecuteNonQuery();
                sqlCon.Close();

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }

        }
    }
}
