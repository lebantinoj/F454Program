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
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

                private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usrTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void subLogin_Click(object sender, EventArgs e)
        {
            // The following code opens up a connection between the program and the database.
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\\F454 Program 2\\UI Designs\\F454ProjectDatabase.accdb");
            // This allows us to send commands to the database.
            OleDbCommand command = new OleDbCommand();

            // We need to open the connection.
            con.Open();
            
            // Data sets to store the student and teacher tables.
            DataSet dataSetStu = new DataSet();
            DataSet dataSetTeach = new DataSet();

            // Variable to hold our query.
            string qryS = "SELECT * from Student", qryT = "Select * from Teacher";

            // Adapter holds data from query and connection.
            OleDbDataAdapter adapterStudent = new OleDbDataAdapter(qryS, con);
            OleDbDataAdapter adapterTeacher = new OleDbDataAdapter(qryT, con);

            // Fills data sets with data from 
            adapterStudent.Fill(dataSetStu);
            adapterTeacher.Fill(dataSetTeach);

            // Lets us give specific commands for student table.
            DataTable dtS = dataSetStu.Tables[0];
            
            // User needs to identify themselves.
            string userType;

            //Set the user type.
            if (stuBtn.Checked)
            {
                userType = "Student";
            }
            else if (teachBtn.Checked)
            {
                userType = "Teacher";
            }
            else
            {
                userType = "";
            }

            
            bool usrFound = false;

            // If the user has identified as a student then it will look at the student table.
            if (userType == "Student")
            {
                foreach (DataRow drS in dtS.Rows)   // Looks through each row.
                {
                    // Looks at the username and password combination in student table.
                    if (drS["Username"].ToString() == usrTxtbox.Text && drS["Password"].ToString() == passTxtbox.Text) 
                    {
                        usrFound = true;        // If the user has been found a message will be displayed - shows successful login.
                        MessageBox.Show("Welcome, " + drS["First Name"].ToString() + ".");      // Welcome message.
                        this.Hide();        // Hides login form.
                        var StudentProfile = new stuUser("Welcome");     // Will open up the student profile.
                        StudentProfile.Show();      // Displays student profile.
                    }
                    
                }

                if (usrFound == false)      // Error message if detals are incorrect.
                {
                    MessageBox.Show("Invalid login details. Please try again.");
                }
            }

            
            // If the user has identified as a student then it will look at the student table.
            if (userType == "Teacher")
            {
                DataTable dtT = dataSetTeach.Tables[0];
                foreach (DataRow drT in dtT.Rows)
                {
                    if (drT["Username"].ToString() == usrTxtbox.Text && drT["Password"].ToString() == passTxtbox.Text)
                    {
                        usrFound = true;
                        MessageBox.Show("Welcome, " + drT["First Name"].ToString() + ".");
                        this.Hide();
                        var TeacherProfile = new TeacherProfile("Welcome");
                        TeacherProfile.Show();
                    }
                    
                }

                if (usrFound == false)
                {
                    MessageBox.Show("Invalid login details. Please try again.");
                }
            }

            if (userType == "")     //If no user type has been chosen, prompt message appears.
            {
                MessageBox.Show("Please choose a user type.");
            }
            con.Close();
            }

        }
    }

