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
    public partial class Form6_name_ : Form
    {
        int i;
        student S;
        public string namee = "0";
        public string password = "0";
        public Form6_name_(int index, student SS)
        {
            i = index;
            S = SS;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form6_name__Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Error !");
            }
            S.EditDataByStudent(i, s1, password);
            this.Close();
            MessageBox.Show("Data has been successfully changed!");
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
