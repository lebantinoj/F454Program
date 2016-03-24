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
            // TODO: This line of code loads data into the 'f454ProjectDatabaseDataSet4.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.f454ProjectDatabaseDataSet4.Student);
            // TODO: This line of code loads data into the 'f454ProjectDatabaseDataSet5.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.f454ProjectDatabaseDataSet5.Student);

            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\F454 Program 2\\UI Designs\\F454ProjectDatabase.accdb");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
