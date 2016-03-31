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
            this.editDg = new System.Windows.Forms.DataGridView();
            this.enterFirstName = new System.Windows.Forms.TextBox();
            this.enterUsrnme = new System.Windows.Forms.TextBox();
            this.enterPass = new System.Windows.Forms.TextBox();
            this.enterT1g = new System.Windows.Forms.TextBox();
            this.enterT1m = new System.Windows.Forms.TextBox();
            this.enterT2g = new System.Windows.Forms.TextBox();
            this.T2m = new System.Windows.Forms.TextBox();
            this.enterT3m = new System.Windows.Forms.TextBox();
            this.enterT3g = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sveBtn = new System.Windows.Forms.Button();
            this.cnclBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.enterLastName = new System.Windows.Forms.TextBox();
            this.stuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stuIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.f454ProjectDatabaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f454ProjectDatabaseDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f454ProjectDatabaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 108;
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
            // editDg
            // 
            this.editDg.AutoGenerateColumns = false;
            this.editDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuIDDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
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
            this.editDg.DataSource = this.studentBindingSource1;
            this.editDg.Location = new System.Drawing.Point(12, 82);
            this.editDg.Name = "editDg";
            this.editDg.Size = new System.Drawing.Size(343, 432);
            this.editDg.TabIndex = 0;
            this.editDg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editDg_KeyDown);
            // 
            // enterFirstName
            // 
            this.enterFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterFirstName.Location = new System.Drawing.Point(381, 114);
            this.enterFirstName.Name = "enterFirstName";
            this.enterFirstName.Size = new System.Drawing.Size(127, 26);
            this.enterFirstName.TabIndex = 0;
            // 
            // enterUsrnme
            // 
            this.enterUsrnme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource10, "Username", true));
            this.enterUsrnme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterUsrnme.Location = new System.Drawing.Point(595, 114);
            this.enterUsrnme.Name = "enterUsrnme";
            this.enterUsrnme.Size = new System.Drawing.Size(127, 26);
            this.enterUsrnme.TabIndex = 2;
            // 
            // enterPass
            // 
            this.enterPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource10, "Password", true));
            this.enterPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPass.Location = new System.Drawing.Point(595, 172);
            this.enterPass.Name = "enterPass";
            this.enterPass.PasswordChar = '*';
            this.enterPass.Size = new System.Drawing.Size(127, 26);
            this.enterPass.TabIndex = 3;
            // 
            // enterT1g
            // 
            this.enterT1g.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource10, "Term 1 Grade", true));
            this.enterT1g.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterT1g.Location = new System.Drawing.Point(689, 236);
            this.enterT1g.Name = "enterT1g";
            this.enterT1g.Size = new System.Drawing.Size(33, 26);
            this.enterT1g.TabIndex = 6;
            // 
            // enterT1m
            // 
            this.enterT1m.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource10, "Term 1 Mark", true));
            this.enterT1m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterT1m.Location = new System.Drawing.Point(689, 268);
            this.enterT1m.Name = "enterT1m";
            this.enterT1m.Size = new System.Drawing.Size(33, 26);
            this.enterT1m.TabIndex = 7;
            // 
            // enterT2g
            // 
            this.enterT2g.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource10, "Term 2 Grade", true));
            this.enterT2g.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterT2g.Location = new System.Drawing.Point(689, 331);
            this.enterT2g.Name = "enterT2g";
            this.enterT2g.Size = new System.Drawing.Size(33, 26);
            this.enterT2g.TabIndex = 8;
            // 
            // T2m
            // 
            this.T2m.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource10, "Term 2 Mark", true));
            this.T2m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2m.Location = new System.Drawing.Point(689, 363);
            this.T2m.Name = "T2m";
            this.T2m.Size = new System.Drawing.Size(33, 26);
            this.T2m.TabIndex = 9;
            // 
            // enterT3m
            // 
            this.enterT3m.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource10, "Term 3 Mark", true));
            this.enterT3m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterT3m.Location = new System.Drawing.Point(689, 452);
            this.enterT3m.Name = "enterT3m";
            this.enterT3m.Size = new System.Drawing.Size(33, 26);
            this.enterT3m.TabIndex = 11;
            // 
            // enterT3g
            // 
            this.enterT3g.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource10, "Term 3 Grade", true));
            this.enterT3g.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterT3g.Location = new System.Drawing.Point(689, 420);
            this.enterT3g.Name = "enterT3g";
            this.enterT3g.Size = new System.Drawing.Size(33, 26);
            this.enterT3g.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(377, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 88;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(591, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 89;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(594, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(576, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 91;
            this.label5.Text = "Term 1 Grade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(576, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 92;
            this.label6.Text = "Term 1 Mark";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(576, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 93;
            this.label7.Text = "Term 2 Grade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(576, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 94;
            this.label8.Text = "Term 2 Mark";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(576, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 95;
            this.label9.Text = "Term 3 Grade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(576, 461);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 96;
            this.label10.Text = "Term 3 Mark";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(377, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 20);
            this.label12.TabIndex = 101;
            this.label12.Text = "Target Grade";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource10, "Target Grade", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(511, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 26);
            this.textBox1.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(376, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 20);
            this.label13.TabIndex = 103;
            this.label13.Text = "Predicted Grade";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource10, "Predicted Grade", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(511, 276);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 26);
            this.textBox2.TabIndex = 5;
            // 
            // sveBtn
            // 
            this.sveBtn.Location = new System.Drawing.Point(745, 292);
            this.sveBtn.Name = "sveBtn";
            this.sveBtn.Size = new System.Drawing.Size(143, 37);
            this.sveBtn.TabIndex = 15;
            this.sveBtn.Text = "Save";
            this.sveBtn.UseVisualStyleBackColor = true;
            this.sveBtn.Click += new System.EventHandler(this.sveBtn_Click);
            // 
            // cnclBtn
            // 
            this.cnclBtn.Location = new System.Drawing.Point(745, 232);
            this.cnclBtn.Name = "cnclBtn";
            this.cnclBtn.Size = new System.Drawing.Size(143, 37);
            this.cnclBtn.TabIndex = 14;
            this.cnclBtn.Text = "Cancel";
            this.cnclBtn.UseVisualStyleBackColor = true;
            this.cnclBtn.Click += new System.EventHandler(this.cnclBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(745, 172);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(143, 37);
            this.editBtn.TabIndex = 13;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(745, 114);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(143, 37);
            this.newBtn.TabIndex = 12;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(377, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 110;
            this.label11.Text = "Last Name";
            // 
            // enterLastName
            // 
            this.enterLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource10, "Full Name", true));
            this.enterLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLastName.Location = new System.Drawing.Point(381, 172);
            this.enterLastName.Name = "enterLastName";
            this.enterLastName.Size = new System.Drawing.Size(127, 26);
            this.enterLastName.TabIndex = 1;
            // 
            // stuIDDataGridViewTextBoxColumn
            // 
            this.stuIDDataGridViewTextBoxColumn.DataPropertyName = "StuID";
            this.stuIDDataGridViewTextBoxColumn.HeaderText = "StuID";
            this.stuIDDataGridViewTextBoxColumn.Name = "stuIDDataGridViewTextBoxColumn";
            this.stuIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.stuIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.f454ProjectDatabaseDataSet5BindingSource;
            // 
            // stuIDDataGridViewTextBoxColumn1
            // 
            this.stuIDDataGridViewTextBoxColumn1.DataPropertyName = "StuID";
            this.stuIDDataGridViewTextBoxColumn1.HeaderText = "StuID";
            this.stuIDDataGridViewTextBoxColumn1.Name = "stuIDDataGridViewTextBoxColumn1";
            this.stuIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
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
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(911, 602);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.enterLastName);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.cnclBtn);
            this.Controls.Add(this.sveBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enterT3m);
            this.Controls.Add(this.enterT3g);
            this.Controls.Add(this.T2m);
            this.Controls.Add(this.enterT2g);
            this.Controls.Add(this.enterT1m);
            this.Controls.Add(this.enterT1g);
            this.Controls.Add(this.enterPass);
            this.Controls.Add(this.enterUsrnme);
            this.Controls.Add(this.enterFirstName);
            this.Controls.Add(this.editDg);
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
            ((System.ComponentModel.ISupportInitialize)(this.editDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridView editDg;
        private System.Windows.Forms.TextBox enterFirstName;
        private System.Windows.Forms.TextBox enterUsrnme;
        private System.Windows.Forms.TextBox enterPass;
        private System.Windows.Forms.TextBox enterT1g;
        private System.Windows.Forms.TextBox enterT1m;
        private System.Windows.Forms.TextBox enterT2g;
        private System.Windows.Forms.TextBox T2m;
        private System.Windows.Forms.TextBox enterT3m;
        private System.Windows.Forms.TextBox enterT3g;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button sveBtn;
        private System.Windows.Forms.Button cnclBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox enterLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.BindingSource studentBindingSource1;
    }
}