
namespace Praktika2
{
    partial class RemoveGroup_Screen
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
            this.GroupInfoGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.removeGTxt = new System.Windows.Forms.TextBox();
            this.removeSBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GroupInfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupInfoGrid
            // 
            this.GroupInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupInfoGrid.Location = new System.Drawing.Point(12, 12);
            this.GroupInfoGrid.Name = "GroupInfoGrid";
            this.GroupInfoGrid.Size = new System.Drawing.Size(519, 165);
            this.GroupInfoGrid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Insert Group ID";
            // 
            // removeGTxt
            // 
            this.removeGTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeGTxt.Location = new System.Drawing.Point(416, 199);
            this.removeGTxt.Name = "removeGTxt";
            this.removeGTxt.Size = new System.Drawing.Size(115, 26);
            this.removeGTxt.TabIndex = 5;
            // 
            // removeSBtn
            // 
            this.removeSBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSBtn.Location = new System.Drawing.Point(391, 239);
            this.removeSBtn.Name = "removeSBtn";
            this.removeSBtn.Size = new System.Drawing.Size(140, 36);
            this.removeSBtn.TabIndex = 6;
            this.removeSBtn.Text = "Remove Group";
            this.removeSBtn.UseVisualStyleBackColor = true;
            this.removeSBtn.Click += new System.EventHandler(this.removeSBtn_Click);
            // 
            // RemoveGroup_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 280);
            this.Controls.Add(this.removeSBtn);
            this.Controls.Add(this.removeGTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupInfoGrid);
            this.Name = "RemoveGroup_Screen";
            this.Text = "RemoveGroup_Screen";
            ((System.ComponentModel.ISupportInitialize)(this.GroupInfoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GroupInfoGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox removeGTxt;
        private System.Windows.Forms.Button removeSBtn;
    }
}