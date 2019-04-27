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
    public partial class Edit_Your_Data : Form
    {
        public int i;
        public student SS;
        public Edit_Your_Data(int index, student sss)
        {
            InitializeComponent();
            i = index;
            SS = sss;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Edit_Your_Data_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked && !checkBox2.Checked)
            {
                Form6_name_ F6 = new Form6_name_(i, SS);
                this.Hide();
                F6.Show();
            }
            else if (checkBox2.CheckState == CheckState.Checked && !checkBox1.Checked)
            {
                Form6_password_ f6 = new Form6_password_(i, SS);
                this.Hide();
                f6.Show();
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                Form6_NS FS = new Form6_NS(i, SS);
                this.Hide();
                FS.Show();
            }
            else
            {
                MessageBox.Show("Please select Any button !");
            }
        }
    }
}
