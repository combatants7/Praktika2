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
using Praktika2;

namespace Praktika2
{
    public partial class Admin_Screen : Form
    {
        User user;
        public Admin_Screen(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            AddStudent_Screen a = new AddStudent_Screen();
            a.ShowDialog();
        }

        private void ProfessorAdd_Click(object sender, EventArgs e)
        {
            AddLecturer_Screen al = new AddLecturer_Screen();
            al.ShowDialog();
        }

        private void RemoveStudent_Click(object sender, EventArgs e)
        {
            RemoveStudent_Screen rs = new RemoveStudent_Screen();
            rs.ShowDialog();
        }

        private void RemoveProfessor_Click(object sender, EventArgs e)
        {
            RemoveLecturer_Screen rl = new RemoveLecturer_Screen();
            rl.ShowDialog();
        }

        private void AddGroup_Click(object sender, EventArgs e)
        {
            AddGroup_Screen ag = new AddGroup_Screen();
            ag.ShowDialog();
        }

        private void sGroupAddBtn_Click(object sender, EventArgs e)
        {
            AddSToGroup_Screen astg = new AddSToGroup_Screen();
            astg.ShowDialog();
        }

        private void RemoveGroup_Click(object sender, EventArgs e)
        {
            RemoveGroup_Screen rgs = new RemoveGroup_Screen();
            rgs.ShowDialog();
        }

        private void AddSubjectBtn_Click(object sender, EventArgs e)
        {
            AddSubject_Screen a = new AddSubject_Screen();
            a.ShowDialog();
        }

        private void RemoveSubjectBtn_Click(object sender, EventArgs e)
        {
            RemoveSubject_Screen rs = new RemoveSubject_Screen();
            rs.ShowDialog();
        }

        private void LectorToSubjectBtn_Click(object sender, EventArgs e)
        {
            AddLToSubject_Screen a = new AddLToSubject_Screen();
            a.ShowDialog();
        }
    }
}
