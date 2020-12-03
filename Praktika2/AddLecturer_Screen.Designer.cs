
namespace Praktika2
{
    partial class AddLecturer_Screen
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
            this.list_Students = new System.Windows.Forms.GroupBox();
            this.SaveLecturerBtn = new System.Windows.Forms.Button();
            this.LastnameTxt = new System.Windows.Forms.TextBox();
            this.FirstnameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.list_Students.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_Students
            // 
            this.list_Students.Controls.Add(this.SaveLecturerBtn);
            this.list_Students.Controls.Add(this.LastnameTxt);
            this.list_Students.Controls.Add(this.FirstnameTxt);
            this.list_Students.Controls.Add(this.label3);
            this.list_Students.Controls.Add(this.label4);
            this.list_Students.Location = new System.Drawing.Point(12, 12);
            this.list_Students.Name = "list_Students";
            this.list_Students.Size = new System.Drawing.Size(379, 283);
            this.list_Students.TabIndex = 8;
            this.list_Students.TabStop = false;
            this.list_Students.Text = "Lecturer Information";
            // 
            // SaveLecturerBtn
            // 
            this.SaveLecturerBtn.Location = new System.Drawing.Point(126, 237);
            this.SaveLecturerBtn.Name = "SaveLecturerBtn";
            this.SaveLecturerBtn.Size = new System.Drawing.Size(115, 40);
            this.SaveLecturerBtn.TabIndex = 0;
            this.SaveLecturerBtn.Text = "Save";
            this.SaveLecturerBtn.UseVisualStyleBackColor = true;
            this.SaveLecturerBtn.Click += new System.EventHandler(this.SaveLecturerBtn_Click);
            // 
            // LastnameTxt
            // 
            this.LastnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastnameTxt.Location = new System.Drawing.Point(167, 144);
            this.LastnameTxt.Name = "LastnameTxt";
            this.LastnameTxt.Size = new System.Drawing.Size(121, 26);
            this.LastnameTxt.TabIndex = 6;
            // 
            // FirstnameTxt
            // 
            this.FirstnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstnameTxt.Location = new System.Drawing.Point(167, 86);
            this.FirstnameTxt.Name = "FirstnameTxt";
            this.FirstnameTxt.Size = new System.Drawing.Size(121, 26);
            this.FirstnameTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // AddLecturer_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 307);
            this.Controls.Add(this.list_Students);
            this.Name = "AddLecturer_Screen";
            this.Text = "AddLecturer_Screen";
            this.list_Students.ResumeLayout(false);
            this.list_Students.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox list_Students;
        private System.Windows.Forms.Button SaveLecturerBtn;
        private System.Windows.Forms.TextBox LastnameTxt;
        private System.Windows.Forms.TextBox FirstnameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}