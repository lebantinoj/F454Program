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
    public partial class Edit : Form
    {
        private OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\\F454 Program 2\\UI Designs\\F454ProjectDatabase.accdb");
        public Edit(Edit updateAcc)
        {
            InitializeComponent();
            
            // TODO: This line of code loads data into the 'f454ProjectDatabaseDataSet5.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.f454ProjectDatabaseDataSet5.Student);

            
            
        }

        public Edit()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Edit_Load(object sender, EventArgs e)
        {
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void bckTp_Click(object sender, EventArgs e)
        {
            this.Hide();    // Hides the current form (Teacher Profile).
            TeacherProfile Tp = new TeacherProfile(v);     // Returns the user back to the Teacher Profile.
            Tp.Show();      //Teacher Profile is shown.
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            /*
            try
            {
                cn.Open();

                OleDbCommand cm = new OleDbCommand();
                cm.Connection = cn; // command to execute using the ocnnection.
                cm.CommandText = ""; //query.

                OleDbDataReader read = cm.ExecuteNonQuery(); //We want to insert so we execute non reader. Retrieving data then 

                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
             * */

        }
            

    
    }
}
