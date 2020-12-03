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

namespace Praktika2
{
    public partial class Student_Screen : Form
    {
        User user;
        
        UserRepos repos;
        public Student_Screen(User user)
        {
            InitializeComponent();
            this.user = user;
            repos = new UserRepos();
            studentGrade();
            
        }
        private void studentGrade()
        {
            DataTable dta = repos.DisplayStudentMarks(user.ID);
            DataGridView1.DataSource = dta;
        }
    }
}
