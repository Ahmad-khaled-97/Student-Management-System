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
    public partial class Form15 : Form
    {
        int index;
        student d = new student();
        public Form15(int ind,student w)
        {
            InitializeComponent();
           index = ind;
           d = w;
           label2.Hide();
           label3.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2(index,d);
            m.Show();
            this.Hide();
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text= d.view_details_of_specefic_course(textBox1.Text);
            if (string.IsNullOrEmpty(label2.Text))
            {
                label3.Text = "Wrong course Code..Please Reenter name!";
                label3.Show();
            }else{
            label2.Show();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
