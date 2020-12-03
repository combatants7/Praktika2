
namespace Praktika2
{
    partial class RemoveStudent_Screen
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
            this.StudentInfoGrid = new System.Windows.Forms.DataGridView();
            this.removeSBtn = new System.Windows.Forms.Button();
            this.removeSTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentInfoGrid
            // 
            this.StudentInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentInfoGrid.Location = new System.Drawing.Point(12, 12);
            this.StudentInfoGrid.Name = "StudentInfoGrid";
            this.StudentInfoGrid.Size = new System.Drawing.Size(519, 165);
            this.StudentInfoGrid.TabIndex = 0;
            // 
            // removeSBtn
            // 
            this.removeSBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSBtn.Location = new System.Drawing.Point(381, 235);
            this.removeSBtn.Name = "removeSBtn";
            this.removeSBtn.Size = new System.Drawing.Size(140, 36);
            this.removeSBtn.TabIndex = 1;
            this.removeSBtn.Text = "Remove Student";
            this.removeSBtn.UseVisualStyleBackColor = true;
            this.removeSBtn.Click += new System.EventHandler(this.removeSBtn_Click);
            // 
            // removeSTxt
            // 
            this.removeSTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSTxt.Location = new System.Drawing.Point(406, 194);
            this.removeSTxt.Name = "removeSTxt";
            this.removeSTxt.Size = new System.Drawing.Size(115, 26);
            this.removeSTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insert Student ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RemoveStudent_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 283);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeSTxt);
            this.Controls.Add(this.removeSBtn);
            this.Controls.Add(this.StudentInfoGrid);
            this.Name = "RemoveStudent_Screen";
            this.Text = "RemoveStudent_Screen";
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentInfoGrid;
        private System.Windows.Forms.Button removeSBtn;
        private System.Windows.Forms.TextBox removeSTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}