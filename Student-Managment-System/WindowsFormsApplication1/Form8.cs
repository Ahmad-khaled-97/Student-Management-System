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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.Hide();
                Form9 m = new Form9();
                m.Show();


            }
            else if (radioButton2.Checked)
            {
                this.Hide();
                Form10 m = new Form10();
                m.Show();

            }
            else if (radioButton3.Checked)
            {
                this.Hide();
                Form11 m = new Form11();
                m.Show();
            }
            else if (radioButton4.Checked)
            {
                this.Hide();
                Form12 m = new Form12();
                m.Show();

            }
            else if (radioButton5.Checked)
            {
                this.Hide();
                Form13 m = new Form13();
                m.Show();
            }
            else
            {
                MessageBox.Show("Please choose one of buttons!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
