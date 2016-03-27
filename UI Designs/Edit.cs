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

        private void sveButton_Click(object sender, EventArgs e)
        {

            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\\F454 Program 2\\UI Designs\\F454ProjectDatabase.accdb");
            
                cn.Open();
                string qry = "SELECT * FROM Student";

                OleDbDataAdapter adpt = new OleDbDataAdapter(qry, cn);

                DataTable dTS = f454ProjectDatabaseDataSet5.Tables[0];

                adpt.Fill(dTS);

                
           

            

        }
    }
}
