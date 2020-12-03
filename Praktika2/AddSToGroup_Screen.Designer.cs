
namespace Praktika2
{
    partial class AddSToGroup_Screen
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
            this.studentListView = new System.Windows.Forms.DataGridView();
            this.groupListView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SIDtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GIDtxt = new System.Windows.Forms.TextBox();
            this.AddSToGroupBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupListView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentListView
            // 
            this.studentListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentListView.Location = new System.Drawing.Point(12, 32);
            this.studentListView.Name = "studentListView";
            this.studentListView.Size = new System.Drawing.Size(411, 198);
            this.studentListView.TabIndex = 0;
            // 
            // groupListView
            // 
            this.groupListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupListView.Location = new System.Drawing.Point(451, 35);
            this.groupListView.Name = "groupListView";
            this.groupListView.Size = new System.Drawing.Size(239, 195);
            this.groupListView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Group List";
            // 
            // SIDtxt
            // 
            this.SIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIDtxt.Location = new System.Drawing.Point(150, 241);
            this.SIDtxt.Name = "SIDtxt";
            this.SIDtxt.Size = new System.Drawing.Size(60, 26);
            this.SIDtxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Insert Student ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Insert Group ID";
            // 
            // GIDtxt
            // 
            this.GIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIDtxt.Location = new System.Drawing.Point(356, 241);
            this.GIDtxt.Name = "GIDtxt";
            this.GIDtxt.Size = new System.Drawing.Size(60, 26);
            this.GIDtxt.TabIndex = 7;
            // 
            // AddSToGroupBtn
            // 
            this.AddSToGroupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSToGroupBtn.Location = new System.Drawing.Point(503, 237);
            this.AddSToGroupBtn.Name = "AddSToGroupBtn";
            this.AddSToGroupBtn.Size = new System.Drawing.Size(187, 35);
            this.AddSToGroupBtn.TabIndex = 8;
            this.AddSToGroupBtn.Text = "Add student to group";
            this.AddSToGroupBtn.UseVisualStyleBackColor = true;
            this.AddSToGroupBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddSToGroup_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 286);
            this.Controls.Add(this.AddSToGroupBtn);
            this.Controls.Add(this.GIDtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SIDtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupListView);
            this.Controls.Add(this.studentListView);
            this.Name = "AddSToGroup_Screen";
            this.Text = "AddSToGroup_Screen";
            ((System.ComponentModel.ISupportInitialize)(this.studentListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentListView;
        private System.Windows.Forms.DataGridView groupListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SIDtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GIDtxt;
        private System.Windows.Forms.Button AddSToGroupBtn;
    }
}