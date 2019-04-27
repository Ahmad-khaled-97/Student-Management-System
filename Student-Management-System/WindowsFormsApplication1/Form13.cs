using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form13 : Form
    {
        Admin h = new Admin();

        public Form13()
        {
            InitializeComponent();
            label2.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();


        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Show();
            }
            else
            {
                textBox1.Hide();
            }


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.Show();
            }
            else
            {
                textBox2.Hide();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox3.Show();
            }
            else
            {
                textBox3.Hide();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox4.Show();
            }
            else
            {
                textBox4.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            h.edit_course_data(textBox5.Text);
            listBox1.Items.Add(h.s1);
            listBox1.Items.Add(h.s2);
            listBox1.Items.Add(h.s3);
            listBox1.Items.Add(h.s4);
            listBox1.Items.Add(h.s5);
            listBox1.Items.Add(h.s6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 m = new Form8();
            m.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Admin h = new Admin();
            courses m = new courses();
            int course_index = h.edit_course_data(textBox5.Text);

            if (checkBox1.Checked == true)
            {
                m.course_name = textBox1.Text;

            }
            else
            {
                m.course_name = " ";
            }
            if (checkBox2.Checked == true)
            {
                m.pre_required_courses = textBox2.Text;

            }
            else
            {
                m.pre_required_courses = " ";
            }
            if (checkBox3.Checked == true)
            {
                m.max_num_of_students = textBox3.Text;

            }
            else
            {
                m.max_num_of_students = " ";
            }
            if (checkBox4.Checked == true)
            {
                m.credit_hours = textBox4.Text;

            }
            else
            {
                m.credit_hours = " ";
            }
            h.edit_course(course_index, m);
            MessageBox.Show("Done !");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            h.edit_course_data(textBox5.Text);
            if (h.course_valid == 0)
            {
                label2.Text = "Wrong code..Please Reenter code:";
                label2.Show();
            }
            else
            {
                label2.Hide();
                listBox1.Items.Add(h.s1);
                listBox1.Items.Add(h.s2);
                listBox1.Items.Add(h.s3);
                listBox1.Items.Add(h.s4);
                listBox1.Items.Add(h.s5);
                listBox1.Items.Add(h.s6);
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                textBox1.Show();
            }
            else
            {
                textBox1.Hide();
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBox2.Checked)
            {
                textBox2.Show();
            }
            else
            {
                textBox2.Hide();
            }
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBox3.Checked)
            {
                textBox3.Show();
            }
            else
            {
                textBox3.Hide();
            }
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBox4.Checked)
            {
                textBox4.Show();
            }
            else
            {
                textBox4.Hide();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form8 m = new Form8();
            m.Show();
            this.Hide();
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
            }
        }
    }
}
