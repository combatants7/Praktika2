
namespace Praktika2
{
    partial class RemoveSubject_Screen
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
            this.subjectListView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectIDtxt = new System.Windows.Forms.TextBox();
            this.deleteSubjectBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.subjectListView)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectListView
            // 
            this.subjectListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectListView.Location = new System.Drawing.Point(12, 25);
            this.subjectListView.Name = "subjectListView";
            this.subjectListView.Size = new System.Drawing.Size(596, 209);
            this.subjectListView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subject List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insert Subject ID ";
            // 
            // subjectIDtxt
            // 
            this.subjectIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectIDtxt.Location = new System.Drawing.Point(420, 246);
            this.subjectIDtxt.Name = "subjectIDtxt";
            this.subjectIDtxt.Size = new System.Drawing.Size(65, 26);
            this.subjectIDtxt.TabIndex = 6;
            // 
            // deleteSubjectBtn
            // 
            this.deleteSubjectBtn.Location = new System.Drawing.Point(506, 244);
            this.deleteSubjectBtn.Name = "deleteSubjectBtn";
            this.deleteSubjectBtn.Size = new System.Drawing.Size(98, 33);
            this.deleteSubjectBtn.TabIndex = 7;
            this.deleteSubjectBtn.Text = "Delete Subject";
            this.deleteSubjectBtn.UseVisualStyleBackColor = true;
            this.deleteSubjectBtn.Click += new System.EventHandler(this.deleteSubjectBtn_Click);
            // 
            // RemoveSubject_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 291);
            this.Controls.Add(this.deleteSubjectBtn);
            this.Controls.Add(this.subjectIDtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectListView);
            this.Name = "RemoveSubject_Screen";
            this.Text = "RemoveSubject_Screen";
            ((System.ComponentModel.ISupportInitialize)(this.subjectListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView subjectListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subjectIDtxt;
        private System.Windows.Forms.Button deleteSubjectBtn;
    }
}