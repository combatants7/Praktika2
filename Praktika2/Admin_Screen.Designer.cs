namespace Praktika2
{
    partial class Admin_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddStudent = new System.Windows.Forms.Button();
            this.ProfessorAdd = new System.Windows.Forms.Button();
            this.AddGroup = new System.Windows.Forms.Button();
            this.RemoveStudent = new System.Windows.Forms.Button();
            this.RemoveProfessor = new System.Windows.Forms.Button();
            this.RemoveGroup = new System.Windows.Forms.Button();
            this.sGroupAddBtn = new System.Windows.Forms.Button();
            this.list_Students = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LectorToSubjectBtn = new System.Windows.Forms.Button();
            this.AddSubjectBtn = new System.Windows.Forms.Button();
            this.RemoveSubjectBtn = new System.Windows.Forms.Button();
            this.list_Students.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(6, 29);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(155, 49);
            this.AddStudent.TabIndex = 0;
            this.AddStudent.Text = "Add new Student";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // ProfessorAdd
            // 
            this.ProfessorAdd.Location = new System.Drawing.Point(6, 29);
            this.ProfessorAdd.Name = "ProfessorAdd";
            this.ProfessorAdd.Size = new System.Drawing.Size(168, 49);
            this.ProfessorAdd.TabIndex = 1;
            this.ProfessorAdd.Text = "Add new Lecturer";
            this.ProfessorAdd.UseVisualStyleBackColor = true;
            this.ProfessorAdd.Click += new System.EventHandler(this.ProfessorAdd_Click);
            // 
            // AddGroup
            // 
            this.AddGroup.Location = new System.Drawing.Point(6, 28);
            this.AddGroup.Name = "AddGroup";
            this.AddGroup.Size = new System.Drawing.Size(155, 49);
            this.AddGroup.TabIndex = 2;
            this.AddGroup.Text = "Add new Group";
            this.AddGroup.UseVisualStyleBackColor = true;
            this.AddGroup.Click += new System.EventHandler(this.AddGroup_Click);
            // 
            // RemoveStudent
            // 
            this.RemoveStudent.Location = new System.Drawing.Point(6, 84);
            this.RemoveStudent.Name = "RemoveStudent";
            this.RemoveStudent.Size = new System.Drawing.Size(155, 49);
            this.RemoveStudent.TabIndex = 3;
            this.RemoveStudent.Text = "Remove existing Student";
            this.RemoveStudent.UseVisualStyleBackColor = true;
            this.RemoveStudent.Click += new System.EventHandler(this.RemoveStudent_Click);
            // 
            // RemoveProfessor
            // 
            this.RemoveProfessor.Location = new System.Drawing.Point(6, 84);
            this.RemoveProfessor.Name = "RemoveProfessor";
            this.RemoveProfessor.Size = new System.Drawing.Size(168, 49);
            this.RemoveProfessor.TabIndex = 4;
            this.RemoveProfessor.Text = "Remove existing Lecturer";
            this.RemoveProfessor.UseVisualStyleBackColor = true;
            this.RemoveProfessor.Click += new System.EventHandler(this.RemoveProfessor_Click);
            // 
            // RemoveGroup
            // 
            this.RemoveGroup.Location = new System.Drawing.Point(6, 83);
            this.RemoveGroup.Name = "RemoveGroup";
            this.RemoveGroup.Size = new System.Drawing.Size(155, 49);
            this.RemoveGroup.TabIndex = 5;
            this.RemoveGroup.Text = "Remove existing Group";
            this.RemoveGroup.UseVisualStyleBackColor = true;
            this.RemoveGroup.Click += new System.EventHandler(this.RemoveGroup_Click);
            // 
            // sGroupAddBtn
            // 
            this.sGroupAddBtn.Location = new System.Drawing.Point(6, 138);
            this.sGroupAddBtn.Name = "sGroupAddBtn";
            this.sGroupAddBtn.Size = new System.Drawing.Size(155, 49);
            this.sGroupAddBtn.TabIndex = 6;
            this.sGroupAddBtn.Text = "Add Student to A Group";
            this.sGroupAddBtn.UseVisualStyleBackColor = true;
            this.sGroupAddBtn.Click += new System.EventHandler(this.sGroupAddBtn_Click);
            // 
            // list_Students
            // 
            this.list_Students.Controls.Add(this.AddStudent);
            this.list_Students.Controls.Add(this.RemoveStudent);
            this.list_Students.Location = new System.Drawing.Point(12, 12);
            this.list_Students.Name = "list_Students";
            this.list_Students.Size = new System.Drawing.Size(181, 144);
            this.list_Students.TabIndex = 7;
            this.list_Students.TabStop = false;
            this.list_Students.Text = "Student Controls";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProfessorAdd);
            this.groupBox1.Controls.Add(this.RemoveProfessor);
            this.groupBox1.Location = new System.Drawing.Point(213, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lecturer Controls";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sGroupAddBtn);
            this.groupBox2.Controls.Add(this.AddGroup);
            this.groupBox2.Controls.Add(this.RemoveGroup);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 202);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Group Controls";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LectorToSubjectBtn);
            this.groupBox3.Controls.Add(this.AddSubjectBtn);
            this.groupBox3.Controls.Add(this.RemoveSubjectBtn);
            this.groupBox3.Location = new System.Drawing.Point(213, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 202);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Subject Controls";
            // 
            // LectorToSubjectBtn
            // 
            this.LectorToSubjectBtn.Location = new System.Drawing.Point(6, 138);
            this.LectorToSubjectBtn.Name = "LectorToSubjectBtn";
            this.LectorToSubjectBtn.Size = new System.Drawing.Size(168, 49);
            this.LectorToSubjectBtn.TabIndex = 6;
            this.LectorToSubjectBtn.Text = "Add Lecturer To a Subject And Group";
            this.LectorToSubjectBtn.UseVisualStyleBackColor = true;
            this.LectorToSubjectBtn.Click += new System.EventHandler(this.LectorToSubjectBtn_Click);
            // 
            // AddSubjectBtn
            // 
            this.AddSubjectBtn.Location = new System.Drawing.Point(6, 28);
            this.AddSubjectBtn.Name = "AddSubjectBtn";
            this.AddSubjectBtn.Size = new System.Drawing.Size(168, 49);
            this.AddSubjectBtn.TabIndex = 2;
            this.AddSubjectBtn.Text = "Add new Subject";
            this.AddSubjectBtn.UseVisualStyleBackColor = true;
            this.AddSubjectBtn.Click += new System.EventHandler(this.AddSubjectBtn_Click);
            // 
            // RemoveSubjectBtn
            // 
            this.RemoveSubjectBtn.Location = new System.Drawing.Point(6, 83);
            this.RemoveSubjectBtn.Name = "RemoveSubjectBtn";
            this.RemoveSubjectBtn.Size = new System.Drawing.Size(168, 49);
            this.RemoveSubjectBtn.TabIndex = 5;
            this.RemoveSubjectBtn.Text = "Remove existing Subject";
            this.RemoveSubjectBtn.UseVisualStyleBackColor = true;
            this.RemoveSubjectBtn.Click += new System.EventHandler(this.RemoveSubjectBtn_Click);
            // 
            // Admin_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 386);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.list_Students);
            this.Name = "Admin_Screen";
            this.Text = "Admin_Screen";
            this.list_Students.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Button ProfessorAdd;
        private System.Windows.Forms.Button AddGroup;
        private System.Windows.Forms.Button RemoveStudent;
        private System.Windows.Forms.Button RemoveProfessor;
        private System.Windows.Forms.Button RemoveGroup;
        private System.Windows.Forms.Button sGroupAddBtn;
        private System.Windows.Forms.GroupBox list_Students;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button LectorToSubjectBtn;
        private System.Windows.Forms.Button AddSubjectBtn;
        private System.Windows.Forms.Button RemoveSubjectBtn;
    }
}