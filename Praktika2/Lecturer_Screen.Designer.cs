
namespace Praktika2
{
    partial class Lecturer_Screen
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
            this.insertGradeBtn = new System.Windows.Forms.Button();
            this.list_Students = new System.Windows.Forms.GroupBox();
            this.getStudentsBtn = new System.Windows.Forms.Button();
            this.gradeTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.aStudentBox = new System.Windows.Forms.ComboBox();
            this.aGroupBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LecturerSubjectList = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.subjectBox = new System.Windows.Forms.ComboBox();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aSubjectBox = new System.Windows.Forms.ComboBox();
            this.displayGBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.markTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.list_Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerSubjectList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertGradeBtn
            // 
            this.insertGradeBtn.Location = new System.Drawing.Point(310, 267);
            this.insertGradeBtn.Name = "insertGradeBtn";
            this.insertGradeBtn.Size = new System.Drawing.Size(138, 36);
            this.insertGradeBtn.TabIndex = 1;
            this.insertGradeBtn.Text = "Insert Grade";
            this.insertGradeBtn.UseVisualStyleBackColor = true;
            this.insertGradeBtn.Click += new System.EventHandler(this.insertGradeBtn_Click);
            // 
            // list_Students
            // 
            this.list_Students.Controls.Add(this.groupBox1);
            this.list_Students.Controls.Add(this.label2);
            this.list_Students.Controls.Add(this.LecturerSubjectList);
            this.list_Students.Location = new System.Drawing.Point(12, 12);
            this.list_Students.Name = "list_Students";
            this.list_Students.Size = new System.Drawing.Size(678, 576);
            this.list_Students.TabIndex = 8;
            this.list_Students.TabStop = false;
            this.list_Students.Text = "Lecturer Controls";
            // 
            // getStudentsBtn
            // 
            this.getStudentsBtn.Location = new System.Drawing.Point(124, 267);
            this.getStudentsBtn.Name = "getStudentsBtn";
            this.getStudentsBtn.Size = new System.Drawing.Size(121, 36);
            this.getStudentsBtn.TabIndex = 12;
            this.getStudentsBtn.Text = "Get Students";
            this.getStudentsBtn.UseVisualStyleBackColor = true;
            this.getStudentsBtn.Click += new System.EventHandler(this.getStudentsBtn_Click);
            // 
            // gradeTxt
            // 
            this.gradeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeTxt.Location = new System.Drawing.Point(332, 213);
            this.gradeTxt.Name = "gradeTxt";
            this.gradeTxt.Size = new System.Drawing.Size(91, 26);
            this.gradeTxt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Insert Grade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Students Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Group";
            // 
            // aStudentBox
            // 
            this.aStudentBox.FormattingEnabled = true;
            this.aStudentBox.Location = new System.Drawing.Point(124, 221);
            this.aStudentBox.Name = "aStudentBox";
            this.aStudentBox.Size = new System.Drawing.Size(121, 21);
            this.aStudentBox.TabIndex = 18;
            // 
            // aGroupBox
            // 
            this.aGroupBox.FormattingEnabled = true;
            this.aGroupBox.Location = new System.Drawing.Point(124, 171);
            this.aGroupBox.Name = "aGroupBox";
            this.aGroupBox.Size = new System.Drawing.Size(121, 21);
            this.aGroupBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lecturer Subject";
            // 
            // LecturerSubjectList
            // 
            this.LecturerSubjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LecturerSubjectList.Location = new System.Drawing.Point(9, 44);
            this.LecturerSubjectList.Name = "LecturerSubjectList";
            this.LecturerSubjectList.Size = new System.Drawing.Size(639, 187);
            this.LecturerSubjectList.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Group Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Subject Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.markTxt);
            this.groupBox1.Controls.Add(this.updateBtn);
            this.groupBox1.Controls.Add(this.displayGBtn);
            this.groupBox1.Controls.Add(this.insertGradeBtn);
            this.groupBox1.Controls.Add(this.gradeTxt);
            this.groupBox1.Controls.Add(this.getStudentsBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.subjectBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupComboBox);
            this.groupBox1.Controls.Add(this.aStudentBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.aGroupBox);
            this.groupBox1.Controls.Add(this.aSubjectBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 309);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grade Control";
            // 
            // subjectBox
            // 
            this.subjectBox.FormattingEnabled = true;
            this.subjectBox.Location = new System.Drawing.Point(124, 35);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(121, 21);
            this.subjectBox.TabIndex = 13;
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(357, 35);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(121, 21);
            this.groupComboBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // aSubjectBox
            // 
            this.aSubjectBox.FormattingEnabled = true;
            this.aSubjectBox.Location = new System.Drawing.Point(124, 126);
            this.aSubjectBox.Name = "aSubjectBox";
            this.aSubjectBox.Size = new System.Drawing.Size(121, 21);
            this.aSubjectBox.TabIndex = 16;
            // 
            // displayGBtn
            // 
            this.displayGBtn.Location = new System.Drawing.Point(495, 26);
            this.displayGBtn.Name = "displayGBtn";
            this.displayGBtn.Size = new System.Drawing.Size(121, 36);
            this.displayGBtn.TabIndex = 21;
            this.displayGBtn.Text = "Display Grades";
            this.displayGBtn.UseVisualStyleBackColor = true;
            this.displayGBtn.Click += new System.EventHandler(this.displayGBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(478, 267);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(138, 36);
            this.updateBtn.TabIndex = 22;
            this.updateBtn.Text = "Update Grade";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // markTxt
            // 
            this.markTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markTxt.Location = new System.Drawing.Point(495, 213);
            this.markTxt.Name = "markTxt";
            this.markTxt.Size = new System.Drawing.Size(91, 26);
            this.markTxt.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(453, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Inset Mark ID to Update";
            // 
            // Lecturer_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 602);
            this.Controls.Add(this.list_Students);
            this.Name = "Lecturer_Screen";
            this.Text = "Lecturer_Screen";
            this.list_Students.ResumeLayout(false);
            this.list_Students.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerSubjectList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insertGradeBtn;
        private System.Windows.Forms.GroupBox list_Students;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView LecturerSubjectList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gradeTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox aStudentBox;
        private System.Windows.Forms.ComboBox aGroupBox;
        private System.Windows.Forms.ComboBox aSubjectBox;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.ComboBox subjectBox;
        private System.Windows.Forms.Button getStudentsBtn;
        private System.Windows.Forms.Button displayGBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox markTxt;
    }
}