namespace UI_Designs
{
    partial class Login
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
            this.usrTxtbox = new System.Windows.Forms.TextBox();
            this.passTxtbox = new System.Windows.Forms.TextBox();
            this.usrnmeLabel = new System.Windows.Forms.Label();
            this.passwLabel = new System.Windows.Forms.Label();
            this.subLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.stuBtn = new System.Windows.Forms.RadioButton();
            this.teachBtn = new System.Windows.Forms.RadioButton();
            this.telNum = new System.Windows.Forms.Label();
            this.faxNum = new System.Windows.Forms.Label();
            this.schlAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usrTxtbox
            // 
            this.usrTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.usrTxtbox.Location = new System.Drawing.Point(630, 36);
            this.usrTxtbox.MaxLength = 16;
            this.usrTxtbox.Name = "usrTxtbox";
            this.usrTxtbox.Size = new System.Drawing.Size(197, 38);
            this.usrTxtbox.TabIndex = 0;
            this.usrTxtbox.TextChanged += new System.EventHandler(this.usrTxtbox_TextChanged);
            // 
            // passTxtbox
            // 
            this.passTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.passTxtbox.Location = new System.Drawing.Point(630, 123);
            this.passTxtbox.MaxLength = 16;
            this.passTxtbox.Name = "passTxtbox";
            this.passTxtbox.Size = new System.Drawing.Size(197, 38);
            this.passTxtbox.TabIndex = 1;
            // 
            // usrnmeLabel
            // 
            this.usrnmeLabel.AutoSize = true;
            this.usrnmeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.usrnmeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usrnmeLabel.Location = new System.Drawing.Point(491, 43);
            this.usrnmeLabel.Name = "usrnmeLabel";
            this.usrnmeLabel.Size = new System.Drawing.Size(139, 31);
            this.usrnmeLabel.TabIndex = 2;
            this.usrnmeLabel.Text = "Username";
            this.usrnmeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwLabel
            // 
            this.passwLabel.AutoSize = true;
            this.passwLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.passwLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwLabel.Location = new System.Drawing.Point(496, 130);
            this.passwLabel.Name = "passwLabel";
            this.passwLabel.Size = new System.Drawing.Size(134, 31);
            this.passwLabel.TabIndex = 3;
            this.passwLabel.Text = "Password";
            this.passwLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // subLogin
            // 
            this.subLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.subLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.subLogin.Location = new System.Drawing.Point(496, 222);
            this.subLogin.Name = "subLogin";
            this.subLogin.Size = new System.Drawing.Size(331, 47);
            this.subLogin.TabIndex = 4;
            this.subLogin.Text = "Login";
            this.subLogin.UseVisualStyleBackColor = true;
            this.subLogin.Click += new System.EventHandler(this.subLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Insert Image";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // stuBtn
            // 
            this.stuBtn.AutoSize = true;
            this.stuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.stuBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stuBtn.Location = new System.Drawing.Point(496, 182);
            this.stuBtn.Name = "stuBtn";
            this.stuBtn.Size = new System.Drawing.Size(98, 29);
            this.stuBtn.TabIndex = 6;
            this.stuBtn.TabStop = true;
            this.stuBtn.Text = "Student";
            this.stuBtn.UseVisualStyleBackColor = true;
            this.stuBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // teachBtn
            // 
            this.teachBtn.AutoSize = true;
            this.teachBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.teachBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.teachBtn.Location = new System.Drawing.Point(724, 182);
            this.teachBtn.Name = "teachBtn";
            this.teachBtn.Size = new System.Drawing.Size(103, 29);
            this.teachBtn.TabIndex = 7;
            this.teachBtn.TabStop = true;
            this.teachBtn.Text = "Teacher";
            this.teachBtn.UseVisualStyleBackColor = true;
            // 
            // telNum
            // 
            this.telNum.AutoSize = true;
            this.telNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.telNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.telNum.Location = new System.Drawing.Point(12, 506);
            this.telNum.Name = "telNum";
            this.telNum.Size = new System.Drawing.Size(134, 17);
            this.telNum.TabIndex = 8;
            this.telNum.Text = "Telephone Number:";
            // 
            // faxNum
            // 
            this.faxNum.AutoSize = true;
            this.faxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.faxNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.faxNum.Location = new System.Drawing.Point(275, 506);
            this.faxNum.Name = "faxNum";
            this.faxNum.Size = new System.Drawing.Size(88, 17);
            this.faxNum.TabIndex = 9;
            this.faxNum.Text = "Fax Number:";
            // 
            // schlAdd
            // 
            this.schlAdd.AutoSize = true;
            this.schlAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.schlAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.schlAdd.Location = new System.Drawing.Point(493, 506);
            this.schlAdd.Name = "schlAdd";
            this.schlAdd.Size = new System.Drawing.Size(64, 17);
            this.schlAdd.TabIndex = 10;
            this.schlAdd.Text = "Address:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(911, 548);
            this.Controls.Add(this.schlAdd);
            this.Controls.Add(this.faxNum);
            this.Controls.Add(this.telNum);
            this.Controls.Add(this.teachBtn);
            this.Controls.Add(this.stuBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subLogin);
            this.Controls.Add(this.passwLabel);
            this.Controls.Add(this.usrnmeLabel);
            this.Controls.Add(this.passTxtbox);
            this.Controls.Add(this.usrTxtbox);
            this.Name = "Login";
            this.Text = "Welcome, Please Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usrTxtbox;
        private System.Windows.Forms.TextBox passTxtbox;
        private System.Windows.Forms.Label usrnmeLabel;
        private System.Windows.Forms.Label passwLabel;
        private System.Windows.Forms.Button subLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton stuBtn;
        private System.Windows.Forms.RadioButton teachBtn;
        private System.Windows.Forms.Label telNum;
        private System.Windows.Forms.Label faxNum;
        private System.Windows.Forms.Label schlAdd;
    }
}

