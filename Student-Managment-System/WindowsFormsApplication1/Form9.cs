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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            label2.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin Ad = new Admin();
            string s = Ad.view_students(textBox1.Text);
            if (Ad.code_in == 0)
            {
                label2.Text = "Wrong code !";
                label2.Show();
            }
            else
            {
                string g = "";
                for (int h = 0; h < s.Length; h++)
                {

                    if (s[h] == '\n') { listBox1.Items.Add(g); g = ""; continue; }
                    g += s[h];

                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 m = new Form8();
            m.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Admin Ad = new Admin();
            string s = Ad.view_students(textBox1.Text);
            if (s == "") 
            {
                MessageBox.Show("Sorry,No students in this course");
            }
            string g = "";
            for (int h = 0; h < s.Length; h++)
            {

                if (s[h] == '\n') { listBox1.Items.Add(g); g = ""; continue; }
                g += s[h];

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form8 m = new Form8();
            m.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
