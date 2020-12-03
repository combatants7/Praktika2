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
    public partial class Lecturer_Screen : Form
    {
        string con = "Data Source=DESKTOP-0M1N0GR\\SQLEXPRESS;Initial Catalog=PraktikaDB;Integrated Security=True";
        UserRepos repos;
        User user;
        SubjectRepos sRepos;
        List<Subject> subjectList = new List<Subject>();
        List<Group> groupList = new List<Group>();
        List<Student> studentList = new List<Student>();
        Marks marks;
        public Lecturer_Screen(User user)
        {
            InitializeComponent();
            this.user = user;
            
            repos = new UserRepos();
            sRepos = new SubjectRepos();
            subjectList = sRepos.LecturerSubjectList(user.ID);
            groupList = sRepos.LecturerGroup(user.ID);
            for(int i = 0; i<subjectList.Count; i++)
            {
                subjectBox.Items.Add(subjectList[i].Subjectname);
                aSubjectBox.Items.Add(subjectList[i].Subjectname);
            }
            for(int i=0;i<groupList.Count;i++)
            {
                groupComboBox.Items.Add(groupList[i].GroupName);
                aGroupBox.Items.Add(groupList[i].GroupName);
            }
            showStudents();
        }

        private void insertGradeBtn_Click(object sender, EventArgs e)
        {
            Marks marks = new Marks();

            int subjectSelectedIndex = subjectBox.SelectedIndex;
            int subjectID = subjectList[subjectSelectedIndex].ID;

            int studentSelect = aStudentBox.SelectedIndex;
            int studentID = studentList[studentSelect].ID;

            if (marks.FinalGrade <= 10)
            {

                marks.StudentID = studentID;
                marks.SubjectID = subjectID;
                marks.FinalGrade = int.Parse(gradeTxt.Text);

                sRepos.InsertGrade(marks);
            }
            else
            {
                MessageBox.Show("Grade can't be more than 10");
            }

        }
        private void showStudents()
        {
            MessageBox.Show(user.ID.ToString());
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name, Lastname, GroupID, SubjectID,FinalGrade FROM tblStudent s FULL JOIN Marks m ON s.ID = m.StudentID FULL JOIN StudySubject ss ON m.SubjectID = ss.ID WHERE s.GroupID = '14'", sqlCon);
            cmd.ExecuteNonQuery();
            sqlCon.Close();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LecturerSubjectList.DataSource = dt;
        }

        private void displayGBtn_Click(object sender, EventArgs e)
        {
            if (subjectList.Count > 0)
            {
                int groupSelectedIndex = groupComboBox.SelectedIndex;
                int GroupID = groupList[groupSelectedIndex].GroupID;

                int subjectSelectedIndex = subjectBox.SelectedIndex;
                int SubjectID = subjectList[subjectSelectedIndex].ID;
                DataTable dt = sRepos.DisplayGrades(SubjectID, GroupID);
                LecturerSubjectList.DataSource = dt;
                //MessageBox.Show(SubjectID.ToString());
                //MessageBox.Show(GroupID.ToString());
            }
            else
            {
                MessageBox.Show("Select Subjects And Groups To Display First");
            }
        }

        private void getStudentsBtn_Click(object sender, EventArgs e)
        {
            int groupSelect = aGroupBox.SelectedIndex;
            int GroupId = groupList[groupSelect].GroupID;

            studentList = sRepos.GetStudentsOfGroup(GroupId);
            
            for(int i = 0; i<studentList.Count;i++)
            {
                aStudentBox.Items.Add(studentList[i].Name + " " + studentList[i].Lastname);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Marks marks = new Marks();
            
            int subjectSelectedIndex = subjectBox.SelectedIndex;
            int subjectID = subjectList[subjectSelectedIndex].ID;

            int studentSelect = aStudentBox.SelectedIndex;
            int studentID = studentList[studentSelect].ID;
            marks.MarkID = int.Parse(markTxt.Text);
            marks.StudentID = studentID;
            marks.SubjectID = subjectID;
            marks.FinalGrade = int.Parse(gradeTxt.Text);

            sRepos.UpdateMark(marks);
        }
    }
}
