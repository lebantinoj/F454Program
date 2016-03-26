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
        public Edit(Edit updateAcc)
        {
            InitializeComponent();
            
            //Establish a connection.
            
          
             /*   OleDbCommand comm = new OleDbCommand(); 
            comm.CommandText = @"UPDATE Student SET [Term 1 Grade] = @t1GradeE,
                            [Term 1 Mark] = @t1MarkE,
                            [Term 2 Grade] = @t2GradeE,
                            [Term 2 Mark] = @t2MarkE,
                            [Term 3 Grade] = @t3GradeE,
                            [Term 3 Mark] = @t3MarkE,
                            [Average Mark] = @avgMarkE,
                            [Predicted Grade] = @prdctGradeE,
                            [Target Grade] = @trgtGradeE";

            
            
            comm.ExecuteNonQuery();
            MessageBox.Show("Successful Update");*/
           

            
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Edit_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'f454ProjectDatabaseDataSet5.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.f454ProjectDatabaseDataSet5.Student);

            
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
            var Tp = new TeacherProfile(v);     // Returns the user back to the Teacher Profile.
            Tp.Show();      //Teacher Profile is shown.
        }
    }
}
