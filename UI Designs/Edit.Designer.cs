namespace UI_Designs
{
    partial class Edit
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
            this.label1 = new System.Windows.Forms.Label();
            this.f454ProjectDatabaseDataSet5 = new F454_Program.F454ProjectDatabaseDataSet5();
            this.studentBindingSource10 = new System.Windows.Forms.BindingSource(this.components);
            this.f454ProjectDatabaseDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new F454_Program.F454ProjectDatabaseDataSet5TableAdapters.StudentTableAdapter();
            this.f454ProjectDatabaseDataSet4 = new F454_Program.F454ProjectDatabaseDataSet4();
            this.studentTableAdapter1 = new F454_Program.F454ProjectDatabaseDataSet4TableAdapters.StudentTableAdapter();
            this.bckTp = new System.Windows.Forms.Button();
            this.editS = new System.Windows.Forms.DataGridView();
            this.stuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term1MarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term1GradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term2MarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term2GradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term3MarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term3GradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageMarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predictedGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.f454ProjectDatabaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f454ProjectDatabaseDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f454ProjectDatabaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(434, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // f454ProjectDatabaseDataSet5
            // 
            this.f454ProjectDatabaseDataSet5.DataSetName = "F454ProjectDatabaseDataSet5";
            this.f454ProjectDatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource10
            // 
            this.studentBindingSource10.DataMember = "Student";
            this.studentBindingSource10.DataSource = this.f454ProjectDatabaseDataSet5BindingSource;
            // 
            // f454ProjectDatabaseDataSet5BindingSource
            // 
            this.f454ProjectDatabaseDataSet5BindingSource.DataSource = this.f454ProjectDatabaseDataSet5;
            this.f454ProjectDatabaseDataSet5BindingSource.Position = 0;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.f454ProjectDatabaseDataSet5;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // f454ProjectDatabaseDataSet4
            // 
            this.f454ProjectDatabaseDataSet4.DataSetName = "F454ProjectDatabaseDataSet4";
            this.f454ProjectDatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // bckTp
            // 
            this.bckTp.Location = new System.Drawing.Point(79, 21);
            this.bckTp.Name = "bckTp";
            this.bckTp.Size = new System.Drawing.Size(143, 37);
            this.bckTp.TabIndex = 73;
            this.bckTp.Text = "< Back";
            this.bckTp.UseVisualStyleBackColor = true;
            this.bckTp.Click += new System.EventHandler(this.bckTp_Click);
            // 
            // editS
            // 
            this.editS.AutoGenerateColumns = false;
            this.editS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.term1MarkDataGridViewTextBoxColumn,
            this.term1GradeDataGridViewTextBoxColumn,
            this.term2MarkDataGridViewTextBoxColumn,
            this.term2GradeDataGridViewTextBoxColumn,
            this.term3MarkDataGridViewTextBoxColumn,
            this.term3GradeDataGridViewTextBoxColumn,
            this.averageMarkDataGridViewTextBoxColumn,
            this.predictedGradeDataGridViewTextBoxColumn,
            this.targetGradeDataGridViewTextBoxColumn});
            this.editS.DataSource = this.studentBindingSource10;
            this.editS.Location = new System.Drawing.Point(12, 83);
            this.editS.Name = "editS";
            this.editS.Size = new System.Drawing.Size(1435, 432);
            this.editS.TabIndex = 74;
            this.editS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stuIDDataGridViewTextBoxColumn
            // 
            this.stuIDDataGridViewTextBoxColumn.DataPropertyName = "StuID";
            this.stuIDDataGridViewTextBoxColumn.HeaderText = "StuID";
            this.stuIDDataGridViewTextBoxColumn.Name = "stuIDDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // term1MarkDataGridViewTextBoxColumn
            // 
            this.term1MarkDataGridViewTextBoxColumn.DataPropertyName = "Term 1 Mark";
            this.term1MarkDataGridViewTextBoxColumn.HeaderText = "Term 1 Mark";
            this.term1MarkDataGridViewTextBoxColumn.Name = "term1MarkDataGridViewTextBoxColumn";
            // 
            // term1GradeDataGridViewTextBoxColumn
            // 
            this.term1GradeDataGridViewTextBoxColumn.DataPropertyName = "Term 1 Grade";
            this.term1GradeDataGridViewTextBoxColumn.HeaderText = "Term 1 Grade";
            this.term1GradeDataGridViewTextBoxColumn.Name = "term1GradeDataGridViewTextBoxColumn";
            // 
            // term2MarkDataGridViewTextBoxColumn
            // 
            this.term2MarkDataGridViewTextBoxColumn.DataPropertyName = "Term 2 Mark";
            this.term2MarkDataGridViewTextBoxColumn.HeaderText = "Term 2 Mark";
            this.term2MarkDataGridViewTextBoxColumn.Name = "term2MarkDataGridViewTextBoxColumn";
            // 
            // term2GradeDataGridViewTextBoxColumn
            // 
            this.term2GradeDataGridViewTextBoxColumn.DataPropertyName = "Term 2 Grade";
            this.term2GradeDataGridViewTextBoxColumn.HeaderText = "Term 2 Grade";
            this.term2GradeDataGridViewTextBoxColumn.Name = "term2GradeDataGridViewTextBoxColumn";
            // 
            // term3MarkDataGridViewTextBoxColumn
            // 
            this.term3MarkDataGridViewTextBoxColumn.DataPropertyName = "Term 3 Mark";
            this.term3MarkDataGridViewTextBoxColumn.HeaderText = "Term 3 Mark";
            this.term3MarkDataGridViewTextBoxColumn.Name = "term3MarkDataGridViewTextBoxColumn";
            // 
            // term3GradeDataGridViewTextBoxColumn
            // 
            this.term3GradeDataGridViewTextBoxColumn.DataPropertyName = "Term 3 Grade";
            this.term3GradeDataGridViewTextBoxColumn.HeaderText = "Term 3 Grade";
            this.term3GradeDataGridViewTextBoxColumn.Name = "term3GradeDataGridViewTextBoxColumn";
            // 
            // averageMarkDataGridViewTextBoxColumn
            // 
            this.averageMarkDataGridViewTextBoxColumn.DataPropertyName = "Average Mark";
            this.averageMarkDataGridViewTextBoxColumn.HeaderText = "Average Mark";
            this.averageMarkDataGridViewTextBoxColumn.Name = "averageMarkDataGridViewTextBoxColumn";
            // 
            // predictedGradeDataGridViewTextBoxColumn
            // 
            this.predictedGradeDataGridViewTextBoxColumn.DataPropertyName = "Predicted Grade";
            this.predictedGradeDataGridViewTextBoxColumn.HeaderText = "Predicted Grade";
            this.predictedGradeDataGridViewTextBoxColumn.Name = "predictedGradeDataGridViewTextBoxColumn";
            // 
            // targetGradeDataGridViewTextBoxColumn
            // 
            this.targetGradeDataGridViewTextBoxColumn.DataPropertyName = "Target Grade";
            this.targetGradeDataGridViewTextBoxColumn.HeaderText = "Target Grade";
            this.targetGradeDataGridViewTextBoxColumn.Name = "targetGradeDataGridViewTextBoxColumn";
            // 
            // sveBtn
            // 
            this.sveBtn.Location = new System.Drawing.Point(12, 537);
            this.sveBtn.Name = "sveBtn";
            this.sveBtn.Size = new System.Drawing.Size(130, 44);
            this.sveBtn.TabIndex = 75;
            this.sveBtn.Text = "Save Changes";
            this.sveBtn.UseVisualStyleBackColor = true;
            this.sveBtn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1471, 873);
            this.Controls.Add(this.sveBtn);
            this.Controls.Add(this.editS);
            this.Controls.Add(this.bckTp);
            this.Controls.Add(this.label1);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.f454ProjectDatabaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f454ProjectDatabaseDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f454ProjectDatabaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private string v;

        public Edit(string v)
        {
            this.v = v;
        }

        private F454_Program.F454ProjectDatabaseDataSet5 f454ProjectDatabaseDataSet5;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private F454_Program.F454ProjectDatabaseDataSet5TableAdapters.StudentTableAdapter studentTableAdapter;
        private F454_Program.F454ProjectDatabaseDataSet4 f454ProjectDatabaseDataSet4;
        private F454_Program.F454ProjectDatabaseDataSet4TableAdapters.StudentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.BindingSource studentBindingSource10;
        private System.Windows.Forms.BindingSource f454ProjectDatabaseDataSet5BindingSource;
        private System.Windows.Forms.Button bckTp;
        private System.Windows.Forms.DataGridView editS;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn term1MarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn term1GradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn term2MarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn term2GradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn term3MarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn term3GradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageMarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predictedGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button sveBtn;
    }
}