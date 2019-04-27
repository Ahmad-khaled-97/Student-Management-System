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
    public partial class Form14 : Form
    {
        int index;
        student s;

        public Form14(int sindex, student ss)
        {
            InitializeComponent();
            index = sindex;
            s = ss;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2(index, s);
            m.Show();
            this.Hide();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 m = new Form2(index, s);
            m.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
