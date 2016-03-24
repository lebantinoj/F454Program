using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace UI_Designs
{
    public partial class StudentProfile : Form
    {
        public StudentProfile(string name)
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void predictGrade_Load(object sender, EventArgs e)
        {
            /*
            if (drS["Username"].ToString() == usrTxtbox.Text && drS["Password"].ToString() == passTxtbox.Text)
            {
                usrFound = true;        // If the user has been found a message will be displayed - shows successful login.
                MessageBox.Show("Welcome, " + drS["First Name"].ToString() + ".");      // Welcome message.
                this.Hide();        // Hides login form.
                var StudentProfile = new StudentProfile("Welcome");     // Will open up the student profile.
                StudentProfile.Show();      // Displays student profile.
              */
            }
        }
        
    }
