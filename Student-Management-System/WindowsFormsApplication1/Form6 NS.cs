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
    public partial class Form6_NS : Form
    {
        int i;
        student S;
        public string namee = "0";
        public string password = "0";
        public Form6_NS(int index, student SS)
        {
            i = index;
            S = SS;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Error !");
            }
            else
            {
                S.EditDataByStudent(i, s1, s2);
                this.Close();
                MessageBox.Show("Data has been successfully changed!");
            }
        }

        private void Form6_NS_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Error !");
            }
            else
            {
                S.EditDataByStudent(i, s1, s2);
                this.Close();
                MessageBox.Show("Data has been successfully changed!");
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
