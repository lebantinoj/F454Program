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

        public Edit()
        {
            
        }

        private void Edit_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'f454ProjectDatabaseDataSet5.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.f454ProjectDatabaseDataSet5.Student);
            f454ProjectDatabaseDataSet5BindingSource.DataSource = this.f454ProjectDatabaseDataSet5.Student;

        }

        private void bckTp_Click(object sender, EventArgs e)
        {
            this.Hide();    // Hides the current form (Teacher Profile).
            TeacherProfile Tp = new TeacherProfile(v);     // Returns the user back to the Teacher Profile.
            Tp.Show();      //Teacher Profile is shown.
        }

       
        private void editDg_KeyDown (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    f454ProjectDatabaseDataSet5BindingSource.RemoveCurrent();
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            // Catch Statement - tries first block of code, followed by catch for exceptions.
            try
            {
                // The control can respond to user interaction.
                editDg.Enabled = true;

                // Input focus to first name text box.
                enterFirstName.Focus();

                // Adds new row in database, projects to data set.
                this.f454ProjectDatabaseDataSet5.Student.AddStudentRow(this.f454ProjectDatabaseDataSet5.Student.NewStudentRow());

                // Moves to the last item on database.
                f454ProjectDatabaseDataSet5BindingSource.MoveLast();

            }
            catch (Exception ex)
            {
                // Shows error in error message.
                MessageBox.Show(ex.Message, "Message: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                f454ProjectDatabaseDataSet5BindingSource.ResetBindings(false);
            }
        }

        private void sveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                f454ProjectDatabaseDataSet5BindingSource.EndEdit();
                studentTableAdapter.Update(this.f454ProjectDatabaseDataSet5.Student);
                editDg.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                f454ProjectDatabaseDataSet5BindingSource.ResetBindings(false);
            }
        }

        private void cnclBtn_Click(object sender, EventArgs e)
        {
            editDg.Enabled = false;
            f454ProjectDatabaseDataSet5BindingSource.ResetBindings(false);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            editDg.Enabled = true;
            enterFirstName.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
