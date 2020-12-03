namespace Praktika2
{
    partial class AddStudent_Screen
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
            this.SaveStdntBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.list_Students = new System.Windows.Forms.GroupBox();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.list_Students.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveStdntBtn
            // 
            this.SaveStdntBtn.Location = new System.Drawing.Point(126, 237);
            this.SaveStdntBtn.Name = "SaveStdntBtn";
            this.SaveStdntBtn.Size = new System.Drawing.Size(115, 40);
            this.SaveStdntBtn.TabIndex = 0;
            this.SaveStdntBtn.Text = "Save";
            this.SaveStdntBtn.UseVisualStyleBackColor = true;
            this.SaveStdntBtn.Click += new System.EventHandler(this.SaveStdntBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // list_Students
            // 
            this.list_Students.Controls.Add(this.SaveStdntBtn);
            this.list_Students.Controls.Add(this.LastNameTxt);
            this.list_Students.Controls.Add(this.FirstNameTxt);
            this.list_Students.Controls.Add(this.label1);
            this.list_Students.Controls.Add(this.label2);
            this.list_Students.Location = new System.Drawing.Point(12, 21);
            this.list_Students.Name = "list_Students";
            this.list_Students.Size = new System.Drawing.Size(380, 310);
            this.list_Students.TabIndex = 4;
            this.list_Students.TabStop = false;
            this.list_Students.Text = "Student Information";
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTxt.Location = new System.Drawing.Point(167, 144);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(121, 26);
            this.LastNameTxt.TabIndex = 6;
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTxt.Location = new System.Drawing.Point(167, 86);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(121, 26);
            this.FirstNameTxt.TabIndex = 4;
            // 
            // AddStudent_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 343);
            this.Controls.Add(this.list_Students);
            this.Name = "AddStudent_Screen";
            this.Text = "AddStudent_Screen";
            this.list_Students.ResumeLayout(false);
            this.list_Students.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveStdntBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox list_Students;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.TextBox FirstNameTxt;
    }
}