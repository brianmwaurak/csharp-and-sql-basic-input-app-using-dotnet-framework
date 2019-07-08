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
    public partial class newform : Form
    {
        public newform()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void load_Click(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            SqlConnection conn;
            conn = new SqlConnection(@"Data Source=BRAYOTAO\SQLEXPRESS;Initial Catalog=db1; User ID=sa ;Password=br14n");
            conn.Open();
            SqlDataAdapter br = new SqlDataAdapter("select * from patients", conn);
            DataTable dt = new DataTable();
            br.Fill(dt);
            conn.Close();
            dgv.DataSource = dt;
        }

        private void deleterec_Click(object sender, EventArgs e)
        {
            int rowno = dgv.CurrentCell.RowIndex;
            string idno = dgv.Rows[rowno].Cells[0].Value.ToString();


            SqlConnection conn;
            conn = new SqlConnection(@"Data Source=BRAYOTAO\SQLEXPRESS;Initial Catalog=db1; User ID=sa ;Password=br14n");
            conn.Open();
            {
                if (this.dgv.SelectedRows.Count > 0)
                {
                    SqlCommand sc = new SqlCommand("delete from patients where idno='" + idno + "';", conn);
                    sc.ExecuteNonQuery();
                    conn.Close();
                    LoadDataToGrid();
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            conn = new SqlConnection(@"Data Source=BRAYOTAO\SQLEXPRESS;Initial Catalog=db1; User ID=sa ;Password=br14n");
            conn.Open();
            SqlDataAdapter br = new SqlDataAdapter("select * from patients", conn);
            DataTable dt = new DataTable();
            br.Fill(dt);
            dgv.ClearSelection();
            int i, c;
            for (i = 0; i < (dgv.Rows.Count); i++)
            {
                for (c = 0; c < (dgv.Columns.Count); c++)
                {
                    if (dgv.Rows[i].Cells[c].Value.ToString() != dt.Rows[i][c].ToString())
                    {
                        SqlCommand sc = new SqlCommand("update patients set " + dgv.Columns[c].HeaderText + "='" + dgv.Rows[dgv.CurrentCell.RowIndex].Cells[c].Value.ToString() + "' where idno='" + dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'", conn);
                        sc.ExecuteNonQuery();
                        conn.Close();
                        LoadDataToGrid();
                    }
                }
            }
        }

        private void newform_Load(object sender, EventArgs e)
        {

        }
    }
}
    