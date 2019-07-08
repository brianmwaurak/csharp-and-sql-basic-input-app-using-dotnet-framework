using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace appdb1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ;
        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            string nametxt, gendertxt, idnotxt, complaintstxt, diagnosistxt, dobtxt;
            nametxt = name.Text;
            gendertxt = male.Text;
            gendertxt = female.Text;
            idnotxt = idno.Text;
            complaintstxt = complaint.Text;
            diagnosistxt = diagnosis.Text;
            dobtxt = dob.Text;
            if (male.Checked)
            {
                gendertxt = "male";
            }
            else if(female.Checked)
            {
                gendertxt = "female";
            }
            try
            {
               
            string connectionString;
            SqlConnection conn;
            connectionString = @"Data Source=BRAYOTAO\SQLEXPRESS;Initial Catalog=db1;User ID=sa;Password=br14n";
            conn = new SqlConnection(connectionString);
            conn.Open();
             SqlDataAdapter sa = new SqlDataAdapter();
                sa.InsertCommand = new SqlCommand("exec inputt   @name='" + nametxt + "', @idno=" + idnotxt + ", @dob='" + dobtxt + "', @gender='" + gendertxt + "',  @complaint='" + complaintstxt + "', @diagnosis='" + complaintstxt + "' ", conn);
                sa.InsertCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Saved");
                name.Clear();
                idno.Clear();
                complaint.Clear();
                diagnosis.Clear();
                male.Checked = false;
                female.Checked = false;
            }
            catch (Exception ec)
            {
                MessageBox.Show("Error \n" + ec);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void view_Click(object sender, EventArgs e)
        {
            Form newform1 = new newform();
            newform1.Show();
            this.Hide();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            name.Clear();
            idno.Clear();
            complaint.Clear();
            diagnosis.Clear();
            male.Checked = false;
            female.Checked = false;
        }
    }
}
