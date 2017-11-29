using System;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        GlobalKeyboardHook gHook;
        Boolean b = true, w = true, c = true;
        private void Form1_Load(object sender, EventArgs e)
        {
            gHook = new GlobalKeyboardHook();
            gHook.KeyDown+= new KeyEventHandler(gHook_KeyDawn);
            gHook.KeyUp += new KeyEventHandler(gHook_KeyUp);
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
                gHook.HookedKeys.Add(key);
            
            gHook.hook();
        }

        private void gHook_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.LControlKey)
            {
                b = true;
            }

            if (e.KeyCode == Keys.C )
            {
                c = true;
            }

            if (e.KeyCode == Keys.W )
            {
                c = true;
            }

            e.Handled =true;
            // throw new NotImplementedException();
        }

        private void gHook_KeyDawn(Object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.LControlKey)
            {
                b = false;
            }

            if (e.KeyCode == Keys.C && b==false)
            {
                c = false;
            }
            if (e.KeyCode == Keys.W && b == false)
            {
                w = false;
            }

            if (  b == false && c == false && e.KeyCode == Keys.D1)
                   {
                textBox1.Text = Clipboard.GetText();
            }
            if ( b == false && w == false && e.KeyCode == Keys.D1 )
            {
                       Clipboard.SetText(textBox1.Text);
                       SendKeys.Send("^(v)");
            }


            if (e.KeyCode == Keys.D2 && b == false && c == false)
            {
                textBox2.Text = Clipboard.GetText();
            }
            if (e.KeyCode == Keys.D2 && b == false && w == false)
            {
                Clipboard.SetText(textBox2.Text);
                SendKeys.Send("^(V)");
                
            }


            if (e.KeyCode == Keys.D3 && b == false && c == false)
            {
                textBox3.Text = Clipboard.GetText();
            }
            if (e.KeyCode == Keys.D3 && b == false && w == false)
            {
                Clipboard.SetText(textBox3.Text);
                SendKeys.Send("^(V)");
            }

            if (e.KeyCode == Keys.D4 && b == false && c == false)
            {
                textBox4.Text = Clipboard.GetText();
            }
            if (e.KeyCode == Keys.D4 && b == false && w == false)
            {
                Clipboard.SetText(textBox4.Text);
                SendKeys.Send("^(V)");
            }


            if (e.KeyCode == Keys.D5 && b == false && c == false)
            {
                textBox5.Text = Clipboard.GetText();
            }
            if (e.KeyCode == Keys.D5 && b == false && w == false)
            {
                Clipboard.SetText(textBox5.Text);
                SendKeys.Send("^(V)");
            }

            e.Handled = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            gHook.unhook();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                gHook.hook();
            }
            else
            {
                gHook.unhook();
            }
        }
    }
}
