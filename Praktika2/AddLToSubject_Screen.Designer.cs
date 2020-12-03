
namespace Praktika2
{
    partial class AddLToSubject_Screen
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
            this.label1 = new System.Windows.Forms.Label();
            this.lecturerListView = new System.Windows.Forms.DataGridView();
            this.subjectListView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.LIDtxt = new System.Windows.Forms.TextBox();
            this.SIDtxt = new System.Windows.Forms.TextBox();
            this.LToSubjectBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LecturerSubjectView = new System.Windows.Forms.DataGridView();
            this.GroupListView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GIDtxt = new System.Windows.Forms.TextBox();
            this.RemoveLSBtn = new System.Windows.Forms.Button();
            this.lsIDtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerSubjectView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupListView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lecturer List";
            // 
            // lecturerListView
            // 
            this.lecturerListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lecturerListView.Location = new System.Drawing.Point(15, 23);
            this.lecturerListView.Name = "lecturerListView";
            this.lecturerListView.Size = new System.Drawing.Size(408, 126);
            this.lecturerListView.TabIndex = 4;
            // 
            // subjectListView
            // 
            this.subjectListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectListView.Location = new System.Drawing.Point(445, 23);
            this.subjectListView.Name = "subjectListView";
            this.subjectListView.Size = new System.Drawing.Size(371, 126);
            this.subjectListView.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subject List";
            // 
            // LIDtxt
            // 
            this.LIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIDtxt.Location = new System.Drawing.Point(754, 189);
            this.LIDtxt.Name = "LIDtxt";
            this.LIDtxt.Size = new System.Drawing.Size(62, 26);
            this.LIDtxt.TabIndex = 7;
            // 
            // SIDtxt
            // 
            this.SIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIDtxt.Location = new System.Drawing.Point(754, 231);
            this.SIDtxt.Name = "SIDtxt";
            this.SIDtxt.Size = new System.Drawing.Size(62, 26);
            this.SIDtxt.TabIndex = 8;
            // 
            // LToSubjectBtn
            // 
            this.LToSubjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LToSubjectBtn.Location = new System.Drawing.Point(642, 326);
            this.LToSubjectBtn.Name = "LToSubjectBtn";
            this.LToSubjectBtn.Size = new System.Drawing.Size(165, 61);
            this.LToSubjectBtn.TabIndex = 9;
            this.LToSubjectBtn.Text = "Add Lecturer To Subject And Group";
            this.LToSubjectBtn.UseVisualStyleBackColor = true;
            this.LToSubjectBtn.Click += new System.EventHandler(this.LToSubjectBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(614, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Insert Lecturer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(619, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Insert Subject ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lecturer Subject List";
            // 
            // LecturerSubjectView
            // 
            this.LecturerSubjectView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LecturerSubjectView.Location = new System.Drawing.Point(15, 189);
            this.LecturerSubjectView.Name = "LecturerSubjectView";
            this.LecturerSubjectView.Size = new System.Drawing.Size(408, 117);
            this.LecturerSubjectView.TabIndex = 13;
            // 
            // GroupListView
            // 
            this.GroupListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupListView.Location = new System.Drawing.Point(445, 189);
            this.GroupListView.Name = "GroupListView";
            this.GroupListView.Size = new System.Drawing.Size(162, 198);
            this.GroupListView.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "StudentGroups";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(628, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Insert Group ID";
            // 
            // GIDtxt
            // 
            this.GIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIDtxt.Location = new System.Drawing.Point(754, 265);
            this.GIDtxt.Name = "GIDtxt";
            this.GIDtxt.Size = new System.Drawing.Size(62, 26);
            this.GIDtxt.TabIndex = 18;
            // 
            // RemoveLSBtn
            // 
            this.RemoveLSBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveLSBtn.Location = new System.Drawing.Point(118, 354);
            this.RemoveLSBtn.Name = "RemoveLSBtn";
            this.RemoveLSBtn.Size = new System.Drawing.Size(197, 33);
            this.RemoveLSBtn.TabIndex = 19;
            this.RemoveLSBtn.Text = "Remove Lecturer Subject";
            this.RemoveLSBtn.UseVisualStyleBackColor = true;
            this.RemoveLSBtn.Click += new System.EventHandler(this.RemoveLSBtn_Click);
            // 
            // lsIDtxt
            // 
            this.lsIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsIDtxt.Location = new System.Drawing.Point(280, 316);
            this.lsIDtxt.Name = "lsIDtxt";
            this.lsIDtxt.Size = new System.Drawing.Size(62, 26);
            this.lsIDtxt.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Lecturer Subject List ID";
            // 
            // AddLToSubject_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 403);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lsIDtxt);
            this.Controls.Add(this.RemoveLSBtn);
            this.Controls.Add(this.GIDtxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GroupListView);
            this.Controls.Add(this.LecturerSubjectView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LToSubjectBtn);
            this.Controls.Add(this.SIDtxt);
            this.Controls.Add(this.LIDtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subjectListView);
            this.Controls.Add(this.lecturerListView);
            this.Controls.Add(this.label1);
            this.Name = "AddLToSubject_Screen";
            this.Text = "AddLToSubject_Screen";
            ((System.ComponentModel.ISupportInitialize)(this.lecturerListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerSubjectView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView lecturerListView;
        private System.Windows.Forms.DataGridView subjectListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LIDtxt;
        private System.Windows.Forms.TextBox SIDtxt;
        private System.Windows.Forms.Button LToSubjectBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView LecturerSubjectView;
        private System.Windows.Forms.DataGridView GroupListView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox GIDtxt;
        private System.Windows.Forms.Button RemoveLSBtn;
        private System.Windows.Forms.TextBox lsIDtxt;
        private System.Windows.Forms.Label label8;
    }
}