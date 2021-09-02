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
    public partial class departUpdateForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public departUpdateForm()
        {
            InitializeComponent();
        }

        private void grpboxUpdateDepart_Enter(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxCourse.Clear();
            textBoxDuration.Clear();
            errorProviderCourseupdate.Clear();
            errorProviderUpdateDur.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uint n;
            string patternName = "^[A-Za-z]+$";

            if (!uint.TryParse(textBoxDuration.Text, out n))
            {
                textBoxDuration.Focus();
                MessageBox.Show("Invalid data");
            }
            else if (Convert.ToInt16(textBoxDuration.Text) > 5)
            {
                textBoxDuration.Focus();
                MessageBox.Show("Invalid data");
            }
            else if (string.IsNullOrWhiteSpace(textBoxCourse.Text))
            {
                textBoxCourse.Focus();
                MessageBox.Show("Invalid data");
            }
            else if (!Regex.IsMatch(textBoxCourse.Text, patternName))
            {
                textBoxCourse.Focus();
                MessageBox.Show("Invalid data");
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "update department set course=@course, duration=@duration where course=@course";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@course", textBoxCourse.Text);
                cmd.Parameters.AddWithValue("@duration", textBoxDuration.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Updated successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    departmentReport dr = new departmentReport();
                    dr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Updation failed!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //departmentReport dr = new departmentReport();
            //dr.Show();
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            btnReset_Click(sender, e);
        }

        private void textBoxCourse_Validating(object sender, CancelEventArgs e)
        {
            string patternName = "^[A-Za-z]+$";
            if (string.IsNullOrWhiteSpace(textBoxCourse.Text))
            {
                errorProviderCourseupdate.SetError(textBoxCourse, "Course should not be left blank!");
            }
            else if (!Regex.IsMatch(textBoxCourse.Text, patternName))
            {
                errorProviderCourseupdate.SetError(textBoxCourse, "Course name should contain alphabets only!!!");
            }
            else
            {
                errorProviderCourseupdate.Clear();
            }
        }

        private void textBoxDuration_Validating(object sender, CancelEventArgs e)
        {
            uint n;
            if (!uint.TryParse(textBoxDuration.Text, out n))
            {
                errorProviderUpdateDur.SetError(textBoxDuration, "In valid duration!!");
            }
            else if (Convert.ToInt16(textBoxDuration.Text) > 5)
            {
                errorProviderUpdateDur.SetError(textBoxDuration, "Duration should be less than 5!!");
            }
            else
            {
                errorProviderUpdateDur.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from department where course=@course";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@course", textBoxCourse.Text);
            //cmd.Parameters.AddWithValue("@duration", textBoxDuration.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Deleted successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                departmentReport dr = new departmentReport();
                dr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Deletion failed!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            depart_student_view dsv = new depart_student_view();
            dsv.Show();
            SqlConnection con = new SqlConnection(cs);
            string query = "select sid,name,email,course,duration,DOJ,current_yr,mobile_no,DOB,age,gender,interest,fees,hostel,image from student where course='"+ textBoxCourse.Text+"';";
            dsv.label1.Text = textBoxCourse.Text + " STUDENT'S DETAILS";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dsv.dataGridView1.DataSource = data;
            this.Hide();

        }
    }
}
