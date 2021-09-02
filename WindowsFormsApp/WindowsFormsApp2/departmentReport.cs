using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace WindowsFormsApp2
{
    public partial class departmentReport : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public departmentReport()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void departmentReport_Load(object sender, EventArgs e)
        {
            BindGridView();            
        }
        public void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from department";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridViewReport.DataSource = data;
            this.Hide();
        }

        private void dataGridViewReport_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            departUpdateForm duf = new departUpdateForm();
            duf.Show();
            duf.textBoxCourse.Text = dataGridViewReport.SelectedRows[0].Cells[0].Value.ToString();
            duf.textBoxDuration.Text = dataGridViewReport.SelectedRows[0].Cells[1].Value.ToString();
            duf.btnView.Text = "View " + dataGridViewReport.SelectedRows[0].Cells[0].Value.ToString()+" student details";
            this.Hide();
        }

       
    }
}
