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
            this.Mark = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.t1MarkE = new System.Windows.Forms.TextBox();
            this.t1GradeE = new System.Windows.Forms.TextBox();
            this.assess1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t2MarkE = new System.Windows.Forms.TextBox();
            this.t2GradeE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.t3MarkE = new System.Windows.Forms.TextBox();
            this.t3GradeE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sveBtn = new System.Windows.Forms.Button();
            this.trgtGradelbl = new System.Windows.Forms.Label();
            this.avgMarklbl = new System.Windows.Forms.Label();
            this.avgMarkE = new System.Windows.Forms.TextBox();
            this.prdctGradeE = new System.Windows.Forms.TextBox();
            this.prdctGradelbl = new System.Windows.Forms.Label();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new F454_Program.F454ProjectDatabaseDataSet5TableAdapters.StudentTableAdapter();
            this.f454ProjectDatabaseDataSet4 = new F454_Program.F454ProjectDatabaseDataSet4();
            this.studentTableAdapter1 = new F454_Program.F454ProjectDatabaseDataSet4TableAdapters.StudentTableAdapter();
            this.f454ProjectDatabaseDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource10 = new System.Windows.Forms.BindingSource(this.components);
            this.classCombo = new System.Windows.Forms.ComboBox();
            this.chooseUsr = new System.Windows.Forms.ComboBox();
            this.chooseStu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.f454ProjectDatabaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f454ProjectDatabaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f454ProjectDatabaseDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(58, 66);
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
            // Mark
            // 
            this.Mark.AutoSize = true;
            this.Mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Mark.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Mark.Location = new System.Drawing.Point(75, 338);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(51, 24);
            this.Mark.TabIndex = 52;
            this.Mark.Text = "Mark";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(64, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 24);
            this.label10.TabIndex = 51;
            this.label10.Text = "Grade";
            // 
            // t1MarkE
            // 
            this.t1MarkE.Location = new System.Drawing.Point(153, 342);
            this.t1MarkE.Name = "t1MarkE";
            this.t1MarkE.Size = new System.Drawing.Size(58, 20);
            this.t1MarkE.TabIndex = 50;
            // 
            // t1GradeE
            // 
            this.t1GradeE.Location = new System.Drawing.Point(153, 300);
            this.t1GradeE.Name = "t1GradeE";
            this.t1GradeE.ReadOnly = true;
            this.t1GradeE.Size = new System.Drawing.Size(58, 20);
            this.t1GradeE.TabIndex = 49;
            // 
            // assess1
            // 
            this.assess1.AutoSize = true;
            this.assess1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.assess1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.assess1.Location = new System.Drawing.Point(59, 254);
            this.assess1.Name = "assess1";
            this.assess1.Size = new System.Drawing.Size(295, 24);
            this.assess1.TabIndex = 48;
            this.assess1.Text = " Autumn Term Assessment Grade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(71, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 57;
            this.label3.Text = "Mark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(60, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "Grade";
            // 
            // t2MarkE
            // 
            this.t2MarkE.Location = new System.Drawing.Point(149, 538);
            this.t2MarkE.Name = "t2MarkE";
            this.t2MarkE.Size = new System.Drawing.Size(58, 20);
            this.t2MarkE.TabIndex = 55;
            // 
            // t2GradeE
            // 
            this.t2GradeE.Location = new System.Drawing.Point(149, 497);
            this.t2GradeE.Name = "t2GradeE";
            this.t2GradeE.Size = new System.Drawing.Size(58, 20);
            this.t2GradeE.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(59, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 24);
            this.label5.TabIndex = 53;
            this.label5.Text = "Spring Term Assessment Grade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(72, 739);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 62;
            this.label6.Text = "Mark";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(61, 698);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 24);
            this.label7.TabIndex = 61;
            this.label7.Text = "Grade";
            // 
            // t3MarkE
            // 
            this.t3MarkE.Location = new System.Drawing.Point(150, 740);
            this.t3MarkE.Name = "t3MarkE";
            this.t3MarkE.Size = new System.Drawing.Size(58, 20);
            this.t3MarkE.TabIndex = 60;
            // 
            // t3GradeE
            // 
            this.t3GradeE.Location = new System.Drawing.Point(150, 698);
            this.t3GradeE.Name = "t3GradeE";
            this.t3GradeE.Size = new System.Drawing.Size(58, 20);
            this.t3GradeE.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(60, 653);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 24);
            this.label8.TabIndex = 58;
            this.label8.Text = "Summer Term Assessment Grade";
            // 
            // sveBtn
            // 
            this.sveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.sveBtn.Location = new System.Drawing.Point(63, 865);
            this.sveBtn.Name = "sveBtn";
            this.sveBtn.Size = new System.Drawing.Size(164, 59);
            this.sveBtn.TabIndex = 0;
            this.sveBtn.Text = "Save";
            this.sveBtn.UseVisualStyleBackColor = true;
            this.sveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // trgtGradelbl
            // 
            this.trgtGradelbl.AutoSize = true;
            this.trgtGradelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.trgtGradelbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.trgtGradelbl.Location = new System.Drawing.Point(713, 338);
            this.trgtGradelbl.Name = "trgtGradelbl";
            this.trgtGradelbl.Size = new System.Drawing.Size(121, 24);
            this.trgtGradelbl.TabIndex = 67;
            this.trgtGradelbl.Text = "Target Grade";
            // 
            // avgMarklbl
            // 
            this.avgMarklbl.AutoSize = true;
            this.avgMarklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgMarklbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.avgMarklbl.Location = new System.Drawing.Point(713, 254);
            this.avgMarklbl.Name = "avgMarklbl";
            this.avgMarklbl.Size = new System.Drawing.Size(127, 24);
            this.avgMarklbl.TabIndex = 66;
            this.avgMarklbl.Text = "Average Mark";
            // 
            // avgMarkE
            // 
            this.avgMarkE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgMarkE.Location = new System.Drawing.Point(846, 254);
            this.avgMarkE.Name = "avgMarkE";
            this.avgMarkE.Size = new System.Drawing.Size(92, 26);
            this.avgMarkE.TabIndex = 65;
            // 
            // prdctGradeE
            // 
            this.prdctGradeE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdctGradeE.Location = new System.Drawing.Point(846, 294);
            this.prdctGradeE.Name = "prdctGradeE";
            this.prdctGradeE.Size = new System.Drawing.Size(92, 26);
            this.prdctGradeE.TabIndex = 64;
            // 
            // prdctGradelbl
            // 
            this.prdctGradelbl.AutoSize = true;
            this.prdctGradelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.prdctGradelbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prdctGradelbl.Location = new System.Drawing.Point(693, 300);
            this.prdctGradelbl.Name = "prdctGradelbl";
            this.prdctGradelbl.Size = new System.Drawing.Size(147, 24);
            this.prdctGradelbl.TabIndex = 63;
            this.prdctGradelbl.Text = "Predicted Grade";
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
            // f454ProjectDatabaseDataSet5BindingSource
            // 
            this.f454ProjectDatabaseDataSet5BindingSource.DataSource = this.f454ProjectDatabaseDataSet5;
            this.f454ProjectDatabaseDataSet5BindingSource.Position = 0;
            // 
            // studentBindingSource10
            // 
            this.studentBindingSource10.DataMember = "Student";
            this.studentBindingSource10.DataSource = this.f454ProjectDatabaseDataSet5BindingSource;
            // 
            // classCombo
            // 
            this.classCombo.DataSource = this.studentBindingSource10;
            this.classCombo.DisplayMember = "Class";
            this.classCombo.FormattingEnabled = true;
            this.classCombo.Location = new System.Drawing.Point(440, 134);
            this.classCombo.Name = "classCombo";
            this.classCombo.Size = new System.Drawing.Size(162, 21);
            this.classCombo.TabIndex = 70;
            // 
            // chooseUsr
            // 
            this.chooseUsr.DataSource = this.studentBindingSource10;
            this.chooseUsr.DisplayMember = "Username";
            this.chooseUsr.FormattingEnabled = true;
            this.chooseUsr.Location = new System.Drawing.Point(254, 134);
            this.chooseUsr.Name = "chooseUsr";
            this.chooseUsr.Size = new System.Drawing.Size(166, 21);
            this.chooseUsr.TabIndex = 69;
            // 
            // chooseStu
            // 
            this.chooseStu.DataSource = this.studentBindingSource10;
            this.chooseStu.DisplayMember = "Full Name";
            this.chooseStu.FormattingEnabled = true;
            this.chooseStu.Location = new System.Drawing.Point(68, 134);
            this.chooseStu.Name = "chooseStu";
            this.chooseStu.Size = new System.Drawing.Size(166, 21);
            this.chooseStu.TabIndex = 68;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1064, 750);
            this.Controls.Add(this.classCombo);
            this.Controls.Add(this.chooseUsr);
            this.Controls.Add(this.chooseStu);
            this.Controls.Add(this.trgtGradelbl);
            this.Controls.Add(this.avgMarklbl);
            this.Controls.Add(this.avgMarkE);
            this.Controls.Add(this.prdctGradeE);
            this.Controls.Add(this.prdctGradelbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.t3MarkE);
            this.Controls.Add(this.t3GradeE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t2MarkE);
            this.Controls.Add(this.t2GradeE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Mark);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.t1MarkE);
            this.Controls.Add(this.t1GradeE);
            this.Controls.Add(this.assess1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sveBtn);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.f454ProjectDatabaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f454ProjectDatabaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f454ProjectDatabaseDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Mark;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox t1MarkE;
        private System.Windows.Forms.TextBox t1GradeE;
        private System.Windows.Forms.Label assess1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t2MarkE;
        private System.Windows.Forms.TextBox t2GradeE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox t3MarkE;
        private System.Windows.Forms.TextBox t3GradeE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button sveBtn;
        private System.Windows.Forms.Label trgtGradelbl;
        private System.Windows.Forms.Label avgMarklbl;
        private System.Windows.Forms.TextBox avgMarkE;
        private System.Windows.Forms.TextBox prdctGradeE;
        private System.Windows.Forms.Label prdctGradelbl;
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
        private System.Windows.Forms.ComboBox classCombo;
        private System.Windows.Forms.ComboBox chooseUsr;
        private System.Windows.Forms.ComboBox chooseStu;
    }
}