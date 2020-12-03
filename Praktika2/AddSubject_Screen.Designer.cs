
namespace Praktika2
{
    partial class AddSubject_Screen
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
            this.components = new System.ComponentModel.Container();
            this.subjectListView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nSubjectBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectNameTxt = new System.Windows.Forms.TextBox();
            this.praktikaDBDataSet = new Praktika2.PraktikaDBDataSet();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectTableAdapter = new Praktika2.PraktikaDBDataSetTableAdapters.SubjectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.subjectListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectListView
            // 
            this.subjectListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectListView.Location = new System.Drawing.Point(12, 26);
            this.subjectListView.Name = "subjectListView";
            this.subjectListView.Size = new System.Drawing.Size(596, 209);
            this.subjectListView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subject List";
            // 
            // nSubjectBtn
            // 
            this.nSubjectBtn.Location = new System.Drawing.Point(510, 258);
            this.nSubjectBtn.Name = "nSubjectBtn";
            this.nSubjectBtn.Size = new System.Drawing.Size(98, 33);
            this.nSubjectBtn.TabIndex = 3;
            this.nSubjectBtn.Text = "Insert Subject";
            this.nSubjectBtn.UseVisualStyleBackColor = true;
            this.nSubjectBtn.Click += new System.EventHandler(this.nSubjectBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Insert Subject Name";
            // 
            // subjectNameTxt
            // 
            this.subjectNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectNameTxt.Location = new System.Drawing.Point(172, 262);
            this.subjectNameTxt.Name = "subjectNameTxt";
            this.subjectNameTxt.Size = new System.Drawing.Size(319, 26);
            this.subjectNameTxt.TabIndex = 5;
            // 
            // praktikaDBDataSet
            // 
            this.praktikaDBDataSet.DataSetName = "PraktikaDBDataSet";
            this.praktikaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject";
            this.subjectBindingSource.DataSource = this.praktikaDBDataSet;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // AddSubject_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 302);
            this.Controls.Add(this.subjectNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nSubjectBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectListView);
            this.Name = "AddSubject_Screen";
            this.Text = "AddSubject_Screen";
            ((System.ComponentModel.ISupportInitialize)(this.subjectListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView subjectListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nSubjectBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subjectNameTxt;
        private PraktikaDBDataSet praktikaDBDataSet;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private PraktikaDBDataSetTableAdapters.SubjectTableAdapter subjectTableAdapter;
    }
}