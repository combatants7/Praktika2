
namespace Praktika2
{
    partial class RemoveLecturer_Screen
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
            this.LecturerInfoGrid = new System.Windows.Forms.DataGridView();
            this.removeLTxt = new System.Windows.Forms.TextBox();
            this.RemoveLecturerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerInfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LecturerInfoGrid
            // 
            this.LecturerInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LecturerInfoGrid.Location = new System.Drawing.Point(12, 12);
            this.LecturerInfoGrid.Name = "LecturerInfoGrid";
            this.LecturerInfoGrid.Size = new System.Drawing.Size(519, 165);
            this.LecturerInfoGrid.TabIndex = 1;
            // 
            // removeLTxt
            // 
            this.removeLTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeLTxt.Location = new System.Drawing.Point(411, 197);
            this.removeLTxt.Name = "removeLTxt";
            this.removeLTxt.Size = new System.Drawing.Size(115, 26);
            this.removeLTxt.TabIndex = 3;
            // 
            // RemoveLecturerBtn
            // 
            this.RemoveLecturerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveLecturerBtn.Location = new System.Drawing.Point(386, 233);
            this.RemoveLecturerBtn.Name = "RemoveLecturerBtn";
            this.RemoveLecturerBtn.Size = new System.Drawing.Size(140, 36);
            this.RemoveLecturerBtn.TabIndex = 4;
            this.RemoveLecturerBtn.Text = "Remove Lecturer";
            this.RemoveLecturerBtn.UseVisualStyleBackColor = true;
            this.RemoveLecturerBtn.Click += new System.EventHandler(this.RemoveLecturerBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Insert Lecturer ID";
            // 
            // RemoveLecturer_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveLecturerBtn);
            this.Controls.Add(this.removeLTxt);
            this.Controls.Add(this.LecturerInfoGrid);
            this.Name = "RemoveLecturer_Screen";
            this.Text = "RemoveLecturer_Screen";
            this.Load += new System.EventHandler(this.RemoveLecturer_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LecturerInfoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LecturerInfoGrid;
        private System.Windows.Forms.TextBox removeLTxt;
        private System.Windows.Forms.Button RemoveLecturerBtn;
        private System.Windows.Forms.Label label1;
    }
}