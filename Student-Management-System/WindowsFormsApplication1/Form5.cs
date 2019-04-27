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
    public partial class Form5 : Form
    {
        student ss;
        int ind;

        public Form5(string cc, int i, student s)
        {

            InitializeComponent();
            ss = s;
            ind = i;
            bool b = true;
            label1.Text = ss.specific_course(i, cc,ref b);

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ss.register(ss.course_ind, ind);
            Form14 m = new Form14(ind, ss);
            m.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ss.register(ss.course_ind, ind);
            Form14 m = new Form14(ind, ss);
            m.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
