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
        public OleDbConnection cn = new OleDbConnection();

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
            // TODO: This line of code loads data into the 'f454ProjectDatabaseDataSet4.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter4.Fill(this.f454ProjectDatabaseDataSet4.Student);
            // TODO: This line of code loads data into the 'f454ProjectDatabaseDataSet3.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter3.Fill(this.f454ProjectDatabaseDataSet3.Student);
            // TODO: This line of code loads data into the 'f454ProjectDatabaseDataSet2.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter2.Fill(this.f454ProjectDatabaseDataSet2.Student);
            // TODO: This line of code loads data into the 'f454ProjectDatabaseDataSet1.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.f454ProjectDatabaseDataSet1.Student);


            

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\F454\\F454 Program\\UI Designs\\F454ProjectDatabase.accdb");
            
            con.Open();
            string qry = "SELECT [StuID], [First Name], [Last Name], [Class] FROM Student";
            OleDbCommand command = new OleDbCommand(qry, con);

            OleDbDataAdapter adapt = new OleDbDataAdapter();
            DataSet cbS = new DataSet();
            adapt.Fill(cbS);
            chooseStu.DataSource = cbS.Tables[0];
            chooseStu.DisplayMember = "StuID";
            chooseStu.ValueMember = "Last Name";

            cn.Close();
            
            
            
            
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
            /*
            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\F454\\F454 Program\\UI Designs\\F454ProjectDatabase.accdb");
            cn.Open();

            string select = "Select Term 1 Grade, Term 1 Mar, Term 2 Grade, Term 2 Mark, Term 3 Grade, Term 3 Mark from Student";
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand cm = new OleDbCommand(select, cn);
            OleDbDataReader dr = cm.ExecuteReader();

            if(dr.Read())
            {
                autGrade.Text=
            }
            cn.Close();
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();    // Hides the current form (Teacher Profile).
            var Edit = new Edit(v);     // A new edit form generated.
            Edit.Show();        // Shows the edit page.
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            /*
            string negStatus = "Below Target", posStatus = "Above Target", reachedStatus = "On Target";

            if ()
            */
        }

        private void prdctGrade_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
                

           


            

            

            

            
            
            
       
