using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ceasar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metn = "";
            metn = textBox1.Text;

            char[] simvol = metn.ToCharArray();

            if (textBox2.Text != null)
            {
                textBox2.Clear();
                foreach(char eded in simvol)
                {
                    textBox2.Text += Convert.ToChar(eded + 7).ToString();
                }

            }
            else
            {
                foreach (char eded in simvol)
                {
                    textBox2.Text += Convert.ToChar(eded + 7).ToString();
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string shifre = "";
            shifre = textBox2.Text;

            char[] simvol2 = shifre.ToCharArray();
            
            if (textBox1.Text != null)
            {
                textBox1.Clear();
                foreach (char eded2 in simvol2)
                {
                    textBox1.Text += Convert.ToChar(eded2 - 7).ToString();
                }

            }
            else
            {
                foreach (char eded2 in simvol2)
                {
                    textBox1.Text += Convert.ToChar(eded2 - 5).ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
