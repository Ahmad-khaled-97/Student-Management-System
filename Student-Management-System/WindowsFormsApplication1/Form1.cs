﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int index = 0;
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);

            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);

            textBox2.PasswordChar = '*';
   
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
       
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            student s1 = new student();
            s1.loadfile();
            s1.string_edit();
            string X = textBox1.Text;
            string y = textBox2.Text;

            if (s1.login(X, y, ref index))
            {
                this.Hide();
                Form2 m = new Form2(index, s1);
                m.Show();



            }
            else
            {
                MessageBox.Show("Invalid username or password,Please check and try again !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            student s1 = new student();
            s1.loadfile();
            s1.string_edit();
            string X = textBox1.Text;
            string y = textBox2.Text;

            if (s1.login(X, y, ref index))
            {
                this.Hide();
                Form2 m = new Form2(index, s1);
                m.Show();



            }
            else
            {
                MessageBox.Show("Invalid username or password,Please check and try again !");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

    
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username...")
            {
                textBox1.ForeColor = Color.Black;
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = Color.Black;
                textBox1.Text = "Username...";
            }
        }

        private void textBox2_Enter_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password...")
            {
                textBox2.ForeColor = Color.Black;
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.ForeColor = Color.Black;
                textBox2.Text = "Password...";
            }
        }
    }
}
