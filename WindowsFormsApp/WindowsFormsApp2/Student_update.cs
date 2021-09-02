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
using System.IO;

using System.Text.RegularExpressions;
namespace WindowsFormsApp2
{
    public partial class Student_update : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Student_update()
        {
            InitializeComponent();
            fillCombobox();
        }
        public void fillCombobox()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from department";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string scourse = myreader.GetString(0);
                    comboBox1.Items.Add(scourse);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int sr = 10;
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string patternName = "^[A-Za-z]+$";
            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase); ///Object initialization for Regex 
            int year = DateTime.Today.Year - dateTimePicker1.Value.Year;
            ulong n;
            uint m;
            int age = DateTime.Today.Year - dateTimePicker2.Value.Year;


            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Focus();
                MessageBox.Show("Invalid data", "Failure");
            }
            else if ((textBox1.Text).Length < 5 || (textBox1.Text).Length > 20)
            {
                textBox1.Focus();
                MessageBox.Show("Invalid data", "Failure");
            }
            else if (!Regex.IsMatch(textBox1.Text, patternName))
            {
                textBox1.Focus();
                MessageBox.Show("Invalid data", "Failure");
            }
            else if (!reg.IsMatch(textBox3.Text))
            {
                textBox3.Focus();
                MessageBox.Show("Invalid data", "Failure");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                comboBox1.Focus();
                MessageBox.Show("Invalid data", "Failure");
            }
            else if (year < 0 || year > 5)
            {
                dateTimePicker1.Focus();
                MessageBox.Show("Invalid data", "Failure");
            }
            else if ((textBox7.Text).Length != 10 || !UInt64.TryParse(textBox7.Text, out n))
            {
                textBox7.Focus();
                MessageBox.Show("Invalid data", "Failure");
            }
            else if (textBox7.Text.StartsWith("0"))
            {
                errorProviderMob.SetError(textBox7, "please enter valid mobile number!!");
            }
            else if (age < 18 || age > 25)
            {
                dateTimePicker2.Focus();
                MessageBox.Show("Invalid data", "Failure");
            }
            else if (!rdbtnMale.Checked == true && !rdbtnFemale.Checked == true && !rdbtnOther.Checked == true)
            {
                rdbtnOther.Focus();
                MessageBox.Show("Invalid data", "Failure");
            }
            else if (checkedListBox1.CheckedIndices.Count == 0)
            {
                checkedListBox1.Focus();
                MessageBox.Show("Invalid data", "Failure");
            }
            else if (!uint.TryParse(textBox6.Text, out m))
            {
                MessageBox.Show("Invalid data", "Failure");
            }
            else if (!rdbtnYes.Checked == true && !rdbtnNo.Checked == true)
            {
                grpBoxHostel.Focus();
                MessageBox.Show("Invalid data", "Failure");
            }
            else if (pictureBox1.Image == null)
            {
                pictureBox1.Focus();
                MessageBox.Show("Invalid data", "Failure");
            }
            else
            {


                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query= "update student set name=@name,email=@email,course=@course,duration=@duration,DOJ=@DOJ,current_yr=@current_yr,mobile_no=@mobile_no,DOB=@DOB,age=@age,gender=@gender,interest=@interest,fees=@fees,hostel=@hostel,image=@image where sid=@sid;";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@sid", textBox4.Text);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@email", textBox3.Text);
                cmd.Parameters.AddWithValue("@course", comboBox1.Text);
                cmd.Parameters.AddWithValue("@duration", Convert.ToInt32(textBox2.Text));
                cmd.Parameters.AddWithValue("@DOJ", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@current_yr", Convert.ToInt32(textBox5.Text));
                cmd.Parameters.AddWithValue("@mobile_no", Convert.ToInt64(textBox7.Text));
                cmd.Parameters.AddWithValue("@DOB", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(agebox.Text));
                string gdr = "";
                string hostel_stay = "";
                if (rdbtnMale.Checked == true)
                {
                    gdr = "Male";
                }
                else if (rdbtnFemale.Checked == true)
                {
                    gdr = "Female";
                }
                else
                {
                    gdr = "Other";
                }
                cmd.Parameters.AddWithValue("@gender", gdr);

                cmd.Parameters.AddWithValue("@fees", Convert.ToInt32(textBox6.Text));
                if (rdbtnYes.Checked == true)
                {
                    hostel_stay = "Yes";
                }
                else
                {
                    hostel_stay = "No";
                }
                cmd.Parameters.AddWithValue("@hostel", hostel_stay);

                string interest = "";

                foreach (string s in checkedListBox1.CheckedItems)
                {
                    if (interest == "")
                    {
                        interest = s;
                    }
                    else
                    {
                        interest += "," + s;
                    }
                }
                cmd.Parameters.AddWithValue("@interest", interest);
                sr++;
                string location = "C:\\Users\\SUPREETA\\Mphasis\\WindowsFormsApp2\\Updated_profiles";
                string photo = "ST" + sr.ToString() + textBox5.Text + comboBox1.Text.Substring(0, 2) + dateTimePicker1.Value.Year + ".jpeg";
                string path = Path.Combine(location, photo);
                cmd.Parameters.AddWithValue("@image", path);
                Image a = pictureBox1.Image;
                int k = cmd.ExecuteNonQuery();
                if (k > 0)
                {
                    a.Save(path);
                    MessageBox.Show("Updated successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Student_report strep = new Student_report();
                    strep.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Updation failed!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from student where sid=@sid";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@sid", textBox4.Text);
            //cmd.Parameters.AddWithValue("@duration", textBoxDuration.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Deleted successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Student_report sr = new Student_report();
                sr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Deletion failed!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
           
            int count = checkedListBox1.Items.Count;
            for (int i = 0; i < count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            errorProviderName.Clear();
            errorProviderEmail.Clear();
            errorProviderDOJ.Clear();
            errorProviderDepart.Clear();
            errorProviderDOB.Clear();
            errorProviderMob.Clear();
            errorProviderFees.Clear();
            errorProviderInterest.Clear();
            errorProviderGender.Clear();
            errorProviderHostel.Clear();
            errorProviderImage.Clear();
            agebox.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            btnReset_Click(sender, e);
        }
        string patternName = "^[A-Za-z]+$";
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProviderName.SetError(textBox1, "Name should not be left blank!");
            }
            else if ((textBox1.Text).Length < 5 || (textBox1.Text).Length > 20)
            {
                errorProviderName.SetError(textBox1, "Name size should be grater than 5 and less than 20!");
            }
            else if (!Regex.IsMatch(textBox1.Text, patternName))
            {
                errorProviderName.SetError(textBox1, "Name should contain alphabets only!!!");
            }
            else
            {
                errorProviderName.Clear();
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {

            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase); ///Object initialization for Regex 
            if (!reg.IsMatch(textBox3.Text))
            {
                errorProviderEmail.SetError(textBox3, "please enter valid email");
            }
            else
            {
                errorProviderEmail.Clear();
            }
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                errorProviderDepart.SetError(comboBox1, "please select the course!!");
            }
            else
            {
                errorProviderDepart.Clear();
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            int year = DateTime.Today.Year - dateTimePicker1.Value.Year;
            int month = DateTime.Today.Month - dateTimePicker1.Value.Month;
            int day = DateTime.Today.Day - dateTimePicker1.Value.Day;
            /* if (dateTimePicker1.Value.ToString()=="")
             {
                 dateTimePicker1.Focus();
             }
            */
            if (year < 0 || year > 5)
            {
                errorProviderDOJ.SetError(dateTimePicker1, "Invalid date of joining!!");
            }

            else
            {
                errorProviderDOJ.Clear();
            }
        }

        private void dateTimePicker2_Validating(object sender, CancelEventArgs e)
        {
            int age = DateTime.Today.Year - dateTimePicker2.Value.Year;
            if (age < 18 || age > 25)
            {
                errorProviderDOB.SetError(dateTimePicker2, "Invalid date of birth!!");
            }
            else
            {
                errorProviderDOB.Clear();
                agebox.Text = "" + age;
            }
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            ulong n;
            if ((textBox7.Text).Length != 10 || !UInt64.TryParse(textBox7.Text, out n))
            {
                errorProviderMob.SetError(textBox7, "please enter valid mobile number!!");
            }
            else if (textBox7.Text.StartsWith("0"))
            {
                errorProviderMob.SetError(textBox7, "please enter valid mobile number!!");
            }
            else
            {
                errorProviderMob.Clear();
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            uint n;
            if (!uint.TryParse(textBox6.Text, out n))
            {
                errorProviderFees.SetError(textBox6, "please enter valid fees!!");
            }
            else
            {
                errorProviderFees.Clear();
            }
        }
        private void grpBoxHostel_Validating(object sender, CancelEventArgs e)
        {
            if (!rdbtnYes.Checked == true && !rdbtnNo.Checked == true)
            {
                errorProviderHostel.SetError(grpBoxHostel, "please select yes or no");
            }
            else
            {
                errorProviderHostel.Clear();
            }
        }
        private void checkedListBox1_Validating(object sender, CancelEventArgs e)
        {
            if (checkedListBox1.CheckedIndices.Count == 0)
            {
                errorProviderInterest.SetError(checkedListBox1, "please select interest");
            }
            else
            {
                errorProviderInterest.Clear();
            }
        }

        private void checkedListBox1_Validating_1(object sender, CancelEventArgs e)
        {
            if (checkedListBox1.CheckedIndices.Count == 0)
            {
                errorProviderInterest.SetError(checkedListBox1, "please select interest");
            }
            else
            {
                errorProviderInterest.Clear();
            }
        }

        private void grpBoxHostel_Validating_1(object sender, CancelEventArgs e)
        {
            if (!rdbtnYes.Checked == true && !rdbtnNo.Checked == true)
            {
                errorProviderHostel.SetError(grpBoxHostel, "please select yes or no");
            }
            else
            {
                errorProviderHostel.Clear();
            }
        }

        private void rdbtnOther_Validating(object sender, CancelEventArgs e)
        {
            if (!rdbtnMale.Checked == true && !rdbtnFemale.Checked == true && !rdbtnOther.Checked == true)
            {
                errorProviderGender.SetError(rdbtnOther, "please select the gender");
            }
            else
            {
                errorProviderGender.Clear();
            }
        }

        private void pictureBox1_Validating(object sender, CancelEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                errorProviderImage.SetError(pictureBox1, "please choose photo!!!");
            }
            else
            {
                errorProviderImage.Clear();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opnfd.FileName);
            }
        }

       
        private void Student_update_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(2);
        }
    }
}
