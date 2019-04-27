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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            label2.Hide();

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form8 m = new Form8();
            m.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Admin ad = new Admin();
              List<Tuple<string, string>> rlist = new List<Tuple<string, string>>();
            rlist= ad.courses_of_a_student(textBox1.Text);
            if (ad.student_founder == 0)
            {
                label2.Text = "Student name not valid !";
                label2.Show();
            }
            else
            {
                label2.Hide();
                for (int g = 0; g < rlist.Count; g++)
                {
                    listBox1.Items.Add(rlist[g]);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
