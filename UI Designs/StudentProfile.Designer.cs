namespace UI_Designs
{
    partial class StudentProfile
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
            this.wlcmLabel = new System.Windows.Forms.Label();
            this.assess1 = new System.Windows.Forms.Label();
            this.t1Grade = new System.Windows.Forms.TextBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f454ProjectDatabaseDataSet5 = new F454_Program.F454ProjectDatabaseDataSet5();
            this.t1Mark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Mark = new System.Windows.Forms.Label();
            this.prdctgradeLabel = new System.Windows.Forms.Label();
            this.prdctGrade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t2Mark = new System.Windows.Forms.TextBox();
            this.t2Grade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.t3Mark = new System.Windows.Forms.TextBox();
            this.t3Grade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.t1Notes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.t3Note = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.t2Notes = new System.Windows.Forms.TextBox();
            this.schlLogo = new System.Windows.Forms.Label();
            this.trgtGrade = new System.Windows.Forms.TextBox();
            this.tgradeLabel = new System.Windows.Forms.Label();
            this.stuUsername = new System.Windows.Forms.Label();
            this.studentTableAdapter = new F454_Program.F454ProjectDatabaseDataSet5TableAdapters.StudentTableAdapter();
            this.logOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f454ProjectDatabaseDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // wlcmLabel
            // 
            this.wlcmLabel.AutoSize = true;
            this.wlcmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.wlcmLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.wlcmLabel.Location = new System.Drawing.Point(140, 24);
            this.wlcmLabel.Name = "wlcmLabel";
            this.wlcmLabel.Size = new System.Drawing.Size(126, 31);
            this.wlcmLabel.TabIndex = 0;
            this.wlcmLabel.Text = "Welcome";
            // 
            // assess1
            // 
            this.assess1.AutoSize = true;
            this.assess1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assess1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.assess1.Location = new System.Drawing.Point(314, 121);
            this.assess1.Name = "assess1";
            this.assess1.Size = new System.Drawing.Size(313, 29);
            this.assess1.TabIndex = 2;
            this.assess1.Text = "Term 1 - Assessment Grade";
            // 
            // t1Grade
            // 
            this.t1Grade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Term 1 Grade", true));
            this.t1Grade.Location = new System.Drawing.Point(404, 166);
            this.t1Grade.Name = "t1Grade";
            this.t1Grade.Size = new System.Drawing.Size(58, 20);
            this.t1Grade.TabIndex = 3;
            this.t1Grade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.f454ProjectDatabaseDataSet5;
            // 
            // f454ProjectDatabaseDataSet5
            // 
            this.f454ProjectDatabaseDataSet5.DataSetName = "F454ProjectDatabaseDataSet5";
            this.f454ProjectDatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t1Mark
            // 
            this.t1Mark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.f454ProjectDatabaseDataSet5, "Student.Term 1 Mark", true));
            this.t1Mark.Location = new System.Drawing.Point(404, 208);
            this.t1Mark.Name = "t1Mark";
            this.t1Mark.Size = new System.Drawing.Size(58, 20);
            this.t1Mark.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(315, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grade";
            // 
            // Mark
            // 
            this.Mark.AutoSize = true;
            this.Mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Mark.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Mark.Location = new System.Drawing.Point(315, 208);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(51, 24);
            this.Mark.TabIndex = 6;
            this.Mark.Text = "Mark";
            // 
            // prdctgradeLabel
            // 
            this.prdctgradeLabel.AutoSize = true;
            this.prdctgradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdctgradeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prdctgradeLabel.Location = new System.Drawing.Point(12, 121);
            this.prdctgradeLabel.Name = "prdctgradeLabel";
            this.prdctgradeLabel.Size = new System.Drawing.Size(190, 29);
            this.prdctgradeLabel.TabIndex = 7;
            this.prdctgradeLabel.Text = "Predicted Grade";
            // 
            // prdctGrade
            // 
            this.prdctGrade.Location = new System.Drawing.Point(208, 130);
            this.prdctGrade.Name = "prdctGrade";
            this.prdctGrade.Size = new System.Drawing.Size(58, 20);
            this.prdctGrade.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(315, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(315, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Grade";
            // 
            // t2Mark
            // 
            this.t2Mark.Location = new System.Drawing.Point(404, 476);
            this.t2Mark.Name = "t2Mark";
            this.t2Mark.Size = new System.Drawing.Size(58, 20);
            this.t2Mark.TabIndex = 11;
            // 
            // t2Grade
            // 
            this.t2Grade.Location = new System.Drawing.Point(404, 434);
            this.t2Grade.Name = "t2Grade";
            this.t2Grade.Size = new System.Drawing.Size(58, 20);
            this.t2Grade.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(314, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Term 2 - Assessment Grade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(315, 735);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Mark";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(315, 693);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Grade";
            // 
            // t3Mark
            // 
            this.t3Mark.Location = new System.Drawing.Point(404, 735);
            this.t3Mark.Name = "t3Mark";
            this.t3Mark.Size = new System.Drawing.Size(58, 20);
            this.t3Mark.TabIndex = 16;
            // 
            // t3Grade
            // 
            this.t3Grade.Location = new System.Drawing.Point(404, 693);
            this.t3Grade.Name = "t3Grade";
            this.t3Grade.Size = new System.Drawing.Size(58, 20);
            this.t3Grade.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(314, 648);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(313, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Term 3 - Assessment Grade";
            // 
            // t1Notes
            // 
            this.t1Notes.Location = new System.Drawing.Point(319, 303);
            this.t1Notes.Name = "t1Notes";
            this.t1Notes.Size = new System.Drawing.Size(292, 20);
            this.t1Notes.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(315, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "Notes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(315, 814);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Notes";
            // 
            // t3Note
            // 
            this.t3Note.Location = new System.Drawing.Point(319, 841);
            this.t3Note.Name = "t3Note";
            this.t3Note.Size = new System.Drawing.Size(292, 20);
            this.t3Note.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(315, 544);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "Notes";
            // 
            // t2Notes
            // 
            this.t2Notes.Location = new System.Drawing.Point(319, 571);
            this.t2Notes.Name = "t2Notes";
            this.t2Notes.Size = new System.Drawing.Size(292, 20);
            this.t2Notes.TabIndex = 27;
            // 
            // schlLogo
            // 
            this.schlLogo.AutoSize = true;
            this.schlLogo.Location = new System.Drawing.Point(36, 39);
            this.schlLogo.Name = "schlLogo";
            this.schlLogo.Size = new System.Drawing.Size(91, 13);
            this.schlLogo.TabIndex = 39;
            this.schlLogo.Text = "Insert Image Here";
            // 
            // trgtGrade
            // 
            this.trgtGrade.Location = new System.Drawing.Point(208, 175);
            this.trgtGrade.Name = "trgtGrade";
            this.trgtGrade.Size = new System.Drawing.Size(58, 20);
            this.trgtGrade.TabIndex = 41;
            // 
            // tgradeLabel
            // 
            this.tgradeLabel.AutoSize = true;
            this.tgradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgradeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tgradeLabel.Location = new System.Drawing.Point(12, 166);
            this.tgradeLabel.Name = "tgradeLabel";
            this.tgradeLabel.Size = new System.Drawing.Size(157, 29);
            this.tgradeLabel.TabIndex = 40;
            this.tgradeLabel.Text = "Target Grade";
            // 
            // stuUsername
            // 
            this.stuUsername.AutoSize = true;
            this.stuUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuUsername.Location = new System.Drawing.Point(281, 24);
            this.stuUsername.Name = "stuUsername";
            this.stuUsername.Size = new System.Drawing.Size(139, 31);
            this.stuUsername.TabIndex = 43;
            this.stuUsername.Tag = "";
            this.stuUsername.Text = "Username";
            this.stuUsername.Click += new System.EventHandler(this.stuUsername_Click);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // logOut
            // 
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logOut.Location = new System.Drawing.Point(806, 39);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(227, 31);
            this.logOut.TabIndex = 50;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // StudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1064, 567);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.stuUsername);
            this.Controls.Add(this.trgtGrade);
            this.Controls.Add(this.tgradeLabel);
            this.Controls.Add(this.schlLogo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.t2Notes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.t3Note);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.t1Notes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.t3Mark);
            this.Controls.Add(this.t3Grade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t2Mark);
            this.Controls.Add(this.t2Grade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prdctGrade);
            this.Controls.Add(this.prdctgradeLabel);
            this.Controls.Add(this.Mark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t1Mark);
            this.Controls.Add(this.t1Grade);
            this.Controls.Add(this.assess1);
            this.Controls.Add(this.wlcmLabel);
            this.Name = "StudentProfile";
            this.Text = "Student Profile";
            this.Load += new System.EventHandler(this.StudentProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f454ProjectDatabaseDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wlcmLabel;
        private System.Windows.Forms.Label assess1;
        private System.Windows.Forms.TextBox t1Grade;
        private System.Windows.Forms.TextBox t1Mark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Mark;
        private System.Windows.Forms.Label prdctgradeLabel;
        private System.Windows.Forms.TextBox prdctGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t2Mark;
        private System.Windows.Forms.TextBox t2Grade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox t3Mark;
        private System.Windows.Forms.TextBox t3Grade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox t1Notes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox t3Note;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox t2Notes;
        private System.Windows.Forms.Label schlLogo;
        private System.Windows.Forms.TextBox trgtGrade;
        private System.Windows.Forms.Label tgradeLabel;
        private System.Windows.Forms.Label stuUsername;
        private F454_Program.F454ProjectDatabaseDataSet5 f454ProjectDatabaseDataSet5;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private F454_Program.F454ProjectDatabaseDataSet5TableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Button logOut;
    }
}