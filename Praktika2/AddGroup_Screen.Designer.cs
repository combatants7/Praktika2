
namespace Praktika2
{
    partial class AddGroup_Screen
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
            this.CreateGroupBtn = new System.Windows.Forms.Button();
            this.GroupNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.list_Students.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_Students
            // 
            this.list_Students.Controls.Add(this.CreateGroupBtn);
            this.list_Students.Controls.Add(this.GroupNameTxt);
            this.list_Students.Controls.Add(this.label3);
            this.list_Students.Location = new System.Drawing.Point(12, 12);
            this.list_Students.Name = "list_Students";
            this.list_Students.Size = new System.Drawing.Size(379, 283);
            this.list_Students.TabIndex = 9;
            this.list_Students.TabStop = false;
            this.list_Students.Text = "Group Information";
            // 
            // CreateGroupBtn
            // 
            this.CreateGroupBtn.Location = new System.Drawing.Point(126, 188);
            this.CreateGroupBtn.Name = "CreateGroupBtn";
            this.CreateGroupBtn.Size = new System.Drawing.Size(115, 40);
            this.CreateGroupBtn.TabIndex = 0;
            this.CreateGroupBtn.Text = "Create new Group";
            this.CreateGroupBtn.UseVisualStyleBackColor = true;
            this.CreateGroupBtn.Click += new System.EventHandler(this.CreateGroupBtn_Click);
            // 
            // GroupNameTxt
            // 
            this.GroupNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupNameTxt.Location = new System.Drawing.Point(167, 86);
            this.GroupNameTxt.Name = "GroupNameTxt";
            this.GroupNameTxt.Size = new System.Drawing.Size(121, 26);
            this.GroupNameTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Group Name";
            // 
            // AddGroup_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 308);
            this.Controls.Add(this.list_Students);
            this.Name = "AddGroup_Screen";
            this.Text = "AddGroup_Screen";
            this.list_Students.ResumeLayout(false);
            this.list_Students.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox list_Students;
        private System.Windows.Forms.Button CreateGroupBtn;
        private System.Windows.Forms.TextBox GroupNameTxt;
        private System.Windows.Forms.Label label3;
    }
}