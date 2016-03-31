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
    public partial class TeacherProfile : Form
    {
        public OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\\F454 Program 2\\UI Designs\\F454ProjectDatabase.accdb");

        public Edit v { get; private set; }

        public TeacherProfile(string name)
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TeacherProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'f454ProjectDatabaseDataSet5.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter5.Fill(this.f454ProjectDatabaseDataSet5.Student);
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void assess1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void chooseStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
               
        }

        private void stuSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void chooseStu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void autGrade_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void autMark_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chooseStu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();    // Hides the current form (Teacher Profile).
            Edit edit = new Edit(v);     // A new edit form generated.
            edit.Show();        // Shows the edit page.
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void prdctGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();    //Hides Teacher Profile
            Login login = new Login();  //opens new login form.
            login.Show();
        }

        
    } 
    
    }
                

           


            

            

            

            
            
            
       
