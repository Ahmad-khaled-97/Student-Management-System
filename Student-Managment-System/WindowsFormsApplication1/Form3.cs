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
    public partial class Form3 : Form
    {
        int index;
        student s;
        public Form3(int sindex, student ss)
        {
            index = sindex;
            s = ss;
            InitializeComponent();

            List<Tuple<string, string>> rlist = new List<Tuple<string, string>>();
            rlist = ss.ViewMyCourses(index);

            for (int i = 0; i < rlist.Count; i++)
            {
                listBox1.Items.Add(rlist[i]);
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2(index, s);
            m.Show();
            this.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 m = new Form2(index, s);
            m.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
