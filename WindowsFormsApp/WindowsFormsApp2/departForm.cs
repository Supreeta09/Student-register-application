using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class departForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public departForm()
        {
            InitializeComponent();
        }

        public void grpboxAddDepart_Enter(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxCourse.Clear();
            textBoxDuration.Clear();
            errorProviderCourse.Clear();
            errorProviderDuration.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            btnReset_Click(sender, e);
        }

        public void departForm_Load(object sender, EventArgs e)
        {
            grpboxAddDepart.Text = "Add department";
            btnAdd.Text = "ADD";
        }

        private void textBoxCourse_Validating(object sender, CancelEventArgs e)
        {
            string patternName = "^[A-Za-z]+$";
            if (string.IsNullOrWhiteSpace(textBoxCourse.Text))
            {
                textBoxCourse.Focus();
                errorProviderCourse.SetError(textBoxCourse, "Course should not be left blank!");

            }
            else if (!Regex.IsMatch(textBoxCourse.Text, patternName))
            {
                textBoxCourse.Focus();
                errorProviderCourse.SetError(textBoxCourse, "Course name should contain alphabets only!!!");
            }
            else
            {
                errorProviderCourse.Clear();
            }
        }


        private void textBoxDuration_Validating(object sender, CancelEventArgs e)
        {
            uint n;
            if (!uint.TryParse(textBoxDuration.Text, out n))
            {
                textBoxDuration.Focus();
                errorProviderDuration.SetError(textBoxDuration, "In valid duration!!");
            }
            else if (Convert.ToInt16(textBoxDuration.Text) > 5)
            {
                textBoxDuration.Focus();
                errorProviderDuration.SetError(textBoxDuration, "Duration should be less than 5!!");
            }
            else
            {
                errorProviderDuration.Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uint n;
            string patternName = "^[A-Za-z]+$";
            if (!uint.TryParse(textBoxDuration.Text, out n))
            {
                textBoxDuration.Focus();
                MessageBox.Show("Invalid data", "Failure");
            }
            else if (Convert.ToInt16(textBoxDuration.Text) > 5)
            {
                textBoxDuration.Focus();
                MessageBox.Show("Invalid data", "Failure");
            }
            else if (string.IsNullOrWhiteSpace(textBoxCourse.Text))
            {
                textBoxCourse.Focus();
                MessageBox.Show("Invalid data", "Failure");
            }
            else if (!Regex.IsMatch(textBoxCourse.Text, patternName))
            {
                textBoxCourse.Focus();
                MessageBox.Show("Invalid data", "Failure");
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query2 = "select * from department where course=@course";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@course", textBoxCourse.Text);
                con.Open();
                SqlDataReader sdr = cmd2.ExecuteReader();
                if (sdr.HasRows == true)
                {
                    MessageBox.Show(textBoxCourse.Text + " course already exists", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                else
                {
                    con.Close();

                    string query = "insert into department values(@course,@duration)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@course", textBoxCourse.Text);
                    cmd.Parameters.AddWithValue("@duration", int.Parse(textBoxDuration.Text));
                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Inserted successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        departmentReport dr = new departmentReport();
                        dr.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Insertion failed!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }
            }
        }
    }
}



