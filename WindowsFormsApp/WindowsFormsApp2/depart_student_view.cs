using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace WindowsFormsApp2
{
    public partial class depart_student_view : Form
    {
        public depart_student_view()
        {
            InitializeComponent();
        }

        private void depart_student_view_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Student_update su = new Student_update();
            su.Show();
            su.textBox4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            su.textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            su.textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            su.comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            su.textBox2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            su.dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            su.textBox5.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            su.textBox7.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            su.dateTimePicker2.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            su.agebox.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[10].Value.ToString() == "Male")
            {
                su.rdbtnMale.Checked = true;
            }
            else if (dataGridView1.SelectedRows[0].Cells[10].Value.ToString() == "Female")
            {
                su.rdbtnFemale.Checked = true;
            }
            else
            {
                su.rdbtnOther.Checked = true;
            }
            su.textBox6.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[13].Value.ToString() == "Yes")
            {
                su.rdbtnYes.Checked = true;
            }
            else
            {
                su.rdbtnNo.Checked = true;
            }
            string str = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            string[] arr = str.Split(',');
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "Sports")
                {
                    su.checkedListBox1.SetItemChecked(i, true);
                }
                else if (arr[i] == "Music")
                {
                    su.checkedListBox1.SetItemChecked(i, true);
                }
                else if (arr[i] == "Reading books")
                {
                    su.checkedListBox1.SetItemChecked(i, true);
                }
                else
                {
                    su.checkedListBox1.SetItemChecked(i, true);
                }

            }
            string path = Path.Combine(dataGridView1.SelectedRows[0].Cells[14].Value.ToString());
            su.pictureBox1.Image = Image.FromFile(path);
            this.Hide();
        }
    }
}
