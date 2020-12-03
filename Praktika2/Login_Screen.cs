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
    public partial class Login_Screen : Form
    {
        public string utype;
        private UserRepos repos;

        public Login_Screen()
        {
            InitializeComponent();
            repos = new UserRepos();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(LoginTypeBox.Text=="Student")
                {
                    User user = repos.StudentLogin(txtUsername.Text, txtPassword.Text);
                    if (user.Username != null)
                    {
                        this.Hide();
                        Student_Screen s = new Student_Screen(user);
                        s.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password.");
                    }
                }
                else if(LoginTypeBox.Text=="Staff")
                {
                    User user = repos.StaffLogin(txtUsername.Text, txtPassword.Text);
                    if (user.Username != null)
                    {
                        MessageBox.Show(user.Role.ToString());
                        if (user.Role.Trim() != "L")
                        {
                            this.Hide();
                            Admin_Screen a = new Admin_Screen(user);
                            a.ShowDialog();
                            this.Close();
                        }
                        else if (user.Role.Trim() != "A")
                        {
                            this.Hide();
                            Lecturer_Screen l = new Lecturer_Screen(user);
                            l.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("You're not member of the Staff!");
                            MessageBox.Show("Select different Log in Method!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password.");
                    }
                }

            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
    }
}
