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
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form2()
        {
            InitializeComponent();
            fillCombobox();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentGrp.Visible = true;
            label1.Visible = true;
            btnRegister.Text = "Register";
            StudentGrp.Text = "Student Registration";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StudentGrp.Visible = false;
            label1.Visible = false;
            btnReset_Click(sender, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox7.Clear();
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            rdbtnMale.Checked = true;
            rdbtnFemale.Checked = false;
            rdbtnOther.Checked = false;
            rdbtnYes.Checked = true;
            rdbtnNo.Checked = false;
            pictureBox1.Image = WindowsFormsApp2.Properties.Resources.images2;
            int count = checkedListBox1.Items.Count;
            for(int i=0;i<count;i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            errorProviderName.Clear();
            errorProviderEmail.Clear();
            errorProviderDOJ.Clear();
            errorProviderDepart.Clear();
            errorProviderCurrentyr.Clear();
            errorProviderDOB.Clear();
            errorProviderMob.Clear();
            errorProviderFees.Clear();
            errorProviderInterest.Clear();
            errorProviderGender.Clear();
            errorProviderHostel.Clear();
            agebox.Text = "";
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

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_report sr = new Student_report();
            sr.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(2);

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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            departForm df = new departForm();
            df.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
        int sr = 10;
         private void btnRegister_Click(object sender, EventArgs e)
        {
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
            else  if (year < 0 || year > 5)
            {
                dateTimePicker1.Focus();
                MessageBox.Show("Invalid data", "Failure");
            }
            else  if ((textBox7.Text).Length != 10 || !UInt64.TryParse(textBox7.Text, out n))
            {
                textBox7.Focus();
                MessageBox.Show("Invalid data", "Failure");
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
            if (!uint.TryParse(textBox4.Text, out m))
            {
                MessageBox.Show("Invalid data", "Failure");
            }
            else if (!rdbtnYes.Checked == true && !rdbtnNo.Checked == true)
            {
                grpBoxHostel.Focus();
                MessageBox.Show("Invalid data", "Failure");
            }


            else
            {


                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "insert into student (name,email,course,duration,DOJ,current_yr,mobile_no,DOB,age,gender,interest,fees,hostel,image) values(@name,@email,@course,@duration,@DOJ,@current_yr,@mobile_no,@DOB,@age,@gender,@interest,@fees,@hostel,@image)";
                SqlCommand cmd = new SqlCommand(query, con);
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

                cmd.Parameters.AddWithValue("@fees", Convert.ToInt32(textBox4.Text));
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
                string location = "C:\\Users\\SUPREETA\\Mphasis\\WindowsFormsApp2\\Profiles";
                string photo = "ST" + sr.ToString() + textBox5.Text + comboBox1.Text.Substring(0, 2) + dateTimePicker1.Value.Year + ".jpeg";
                string path = Path.Combine(location, photo);
                cmd.Parameters.AddWithValue("@image", path);
                Image a = pictureBox1.Image;
                int k = cmd.ExecuteNonQuery();
                if (k > 0)
                {
                    a.Save(path);
                    MessageBox.Show("Inserted successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Student_report strep = new Student_report();
                    strep.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Insertion failed!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
        }



        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

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
            if (year < 0 || year>5)
            {
                errorProviderDOJ.SetError(dateTimePicker1, "Invalid date of joining!!");
            }
            
            else
            {
                errorProviderDOJ.Clear();
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            uint n;
            if(!uint.TryParse(textBox5.Text, out n))
            {
                errorProviderCurrentyr.SetError(textBox5, "please enter valid current yr!!");
            }
            else
            {
                errorProviderCurrentyr.Clear();
            }
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            ulong n;
            if ((textBox7.Text).Length != 10 || !UInt64.TryParse(textBox7.Text, out n))
            {
                errorProviderMob.SetError(textBox7, "please enter valid mobile number!!");
            }
            else if(textBox7.Text.StartsWith("0"))
            {
                errorProviderMob.SetError(textBox7, "please enter valid mobile number!!");
            }
            else
            {
                errorProviderMob.Clear();
            }
        }
        private void dateTimePicker2_Validating(object sender, CancelEventArgs e)
        {
            int age= DateTime.Today.Year - dateTimePicker2.Value.Year;
            if(age<18 || age>25)
            {
                errorProviderDOB.SetError(dateTimePicker2, "Invalid date of birth!!");
            }
            else
            {
                errorProviderDOB.Clear();
                agebox.Text = "" + age;
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            uint n;
            if (!uint.TryParse(textBox4.Text, out n))
            {
                errorProviderFees.SetError(textBox4, "please enter valid fees!!");
            }
            else
            {
                errorProviderFees.Clear();
            }
        }

        private void StudentGrp_Validating(object sender, CancelEventArgs e)
        {
        }

       
        private void rdbtnOther_Validating(object sender, CancelEventArgs e)
        {
            if (!rdbtnMale.Checked==true && !rdbtnFemale.Checked == true && !rdbtnOther.Checked == true)
            {
                errorProviderGender.SetError(rdbtnOther, "please select the gender");
            }
            else
            {
                errorProviderGender.Clear();
            }
           
        }

        private void grpBoxHostel_Validating(object sender, CancelEventArgs e)
        {
            if(!rdbtnYes.Checked==true && !rdbtnNo.Checked==true)
            {
                errorProviderHostel.SetError(grpBoxHostel, "please select yes or no");
            }
            else
            {
                errorProviderHostel.Clear();
            }
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            departmentReport dr = new departmentReport();
            dr.Show();
            this.Hide();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select duration from department where course='"+comboBox1.Text+"' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            textBox2.Text = data.Rows[0][0].ToString();
        }

        private void checkedListBox1_Validating(object sender, CancelEventArgs e)
        {
            if(checkedListBox1.CheckedIndices.Count==0)
            {
                errorProviderInterest.SetError(checkedListBox1, "please select interest");
            }
            else
            {
                errorProviderInterest.Clear();
            }
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            int year = DateTime.Today.Year - dateTimePicker1.Value.Year;
            if (year < 0 || year > 5)
            {
                dateTimePicker1.Focus();
                errorProviderDOJ.SetError(dateTimePicker1, "Invalid date of joining!!");
            }
            else
            {
                year = year + 1;
                textBox5.Text= year.ToString();
            }
        }

        private void rdbtnMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Validating(object sender, CancelEventArgs e)
        {
            if(pictureBox1.Image==null)
            {
                pictureBox1.Focus();
                errorProviderimage.SetError(pictureBox1, "please choose photo!!!");
            }
            else
            {
                errorProviderimage.Clear();
            }
        }
    }
}
