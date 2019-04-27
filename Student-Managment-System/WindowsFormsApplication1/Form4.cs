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
    public partial class Form4 : Form
    {
        student sd;
        int ind;
        public Form4(int i, student st)
        {
            ind = i;
            sd = st;
            InitializeComponent();
            label2.Hide();
            List<Tuple<string, string>> avl = new List<Tuple<string, string>>();
            avl = st.list_of_available(i);

            for (int h = 0; h < avl.Count; h++)
            {
                listBox1.Items.Add(avl[h]);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool b = false;
            sd.specific_course(ind, textBox1.Text, ref b);
            if (b == false)
            {
                label2.Text="Wrong code...Please Reenter code:";
                label2.Show();
            }
            else
            {
                this.Hide();

                Form5 f = new Form5(textBox1.Text, ind, sd);
                f.Show();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
