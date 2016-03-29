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
        
        public StudentProfile(string stuUser)
        {
            InitializeComponent();
            stuUsername.Text = stuUser;     // Set the label text to data recieved from login form.
        }

        public StudentProfile()
        {
            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\\F454 Program 2\\UI Designs\\F454ProjectDatabase.accdb");

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void StudentProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'f454ProjectDatabaseDataSet5.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.f454ProjectDatabaseDataSet5.Student);
            

        }

        private void stuUsername_Click(object sender, EventArgs e)
        {

        }

       
    }
        
}
