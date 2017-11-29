using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             int start=0;
            int end=textBox2.Text.LastIndexOf(textBox1.Text);
            textBox2.SelectAll();
            textBox2.SelectionBackColor = Color.White;
            while (start<=end) {

                textBox2.Find(textBox1.Text, start, textBox2.TextLength, RichTextBoxFinds.MatchCase);
                textBox2.SelectionBackColor = Color.Yellow;

                start = textBox2.Text.IndexOf(textBox1.Text, start)+1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
