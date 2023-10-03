using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafıza_oyujnu_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int süre = 5;
        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            timer1.Start();
            label6.Text = süre.ToString();
            int sayı1, sayı2, sayı3, sayı4, sayı5;
            sayı1 = rastgele.Next(0, 50);
            sayı2 = rastgele.Next(0, 50);
            sayı3 = rastgele.Next(0, 50);
            sayı4 = rastgele.Next(0, 50);
            sayı5 = rastgele.Next(0, 50);

            label1.Text = sayı1.ToString();
            label2.Text = sayı2.ToString();
            label3.Text = sayı3.ToString();
            label4.Text = sayı4.ToString();
            label5.Text = sayı5.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

            if (label1.Text == textBox1.Text && label2.Text == textBox2.Text && label3.Text == textBox3.Text && label4.Text == textBox4.Text && label5.Text == textBox5.Text)
            {
                MessageBox.Show("congratilations");
            }
            if(label1.Text!=textBox1.Text || label2.Text!=textBox2.Text || label3.Text!=textBox3.Text || label4.Text!=textBox4.Text || label5.Text!=textBox5.Text)
            {
                MessageBox.Show("sorry");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre--;
            label6.Text = süre.ToString();
            if (süre == 0)
            {
                timer1.Stop();
                süre = 5;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;

            }
        }
    }
}


