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
    public partial class Form2 : Form
    {
        int sindex;
        student stu;
        public Form2(int index, student s)
        {
            InitializeComponent();
            sindex = index;
            stu = s;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.Hide();
                Form3 m = new Form3(sindex, stu);
                m.Show();


            }
            else if (radioButton2.Checked)
            {
                Form4 f = new Form4(sindex, stu);
                this.Hide();
                f.Show();
            }
            else if (radioButton3.Checked)
            {
                this.Hide();
                Edit_Your_Data F5 = new Edit_Your_Data(sindex, stu);
                F5.Show();
            }
            else if (radioButton4.Checked)
            {
                this.Hide();
                Form15 j = new Form15(sindex,stu);
                j.Show();
            }
            else
            {
                MessageBox.Show("Incorrect choice!...Please choose button !");
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
