using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace calculator
{
    public partial class Form1 : Form
    {
        float rezult = 0;
        float argument = 0;
        string ev = "";
        int tmp = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SetAutorunValue(true);
        }

        public bool SetAutorunValue(bool autorun)
        {
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun)
                    reg.SetValue("clculator", ExePath);
                else
                    reg.DeleteValue("calculator");

                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void add_char(String c)
        {
            if (tmp == 1)
            {
                label1.Text = c;
                tmp = 0;
            }
            else
            {
                label1.Text += c;
            }
        }

        private void do_event()
        {
            switch (ev)
            {
                case "+":
                    rezult += argument;
                    label1.Text = rezult.ToString();
                    tmp = 1;
                    break;
                case "-":
                    rezult -= argument;
                    label1.Text = rezult.ToString();
                    tmp = 1;
                    break;
                case "/":
                    rezult = rezult / argument;
                    label1.Text = rezult.ToString();
                    tmp = 1;
                    break;
                case "x":
                    rezult = rezult * argument;
                    label1.Text = rezult.ToString();
                    tmp = 1;
                    break;
                default:
                    rezult = float.Parse(label1.Text);
                    tmp = 1;
                    break;
            }
        }

        private void num1_Click(object sender, EventArgs e)
        {
            add_char("1");
        }

        private void num2_Click(object sender, EventArgs e)
        {
            add_char("2");
        }

        private void num3_Click(object sender, EventArgs e)
        {
            add_char("3");
        }

        private void num4_Click(object sender, EventArgs e)
        {
            add_char("4");
        }

        private void num5_Click(object sender, EventArgs e)
        {
            add_char("5");
        }

        private void num6_Click(object sender, EventArgs e)
        {
            add_char("6");
        }

        private void num7_Click(object sender, EventArgs e)
        {
            add_char("7");
        }

        private void num8_Click(object sender, EventArgs e)
        {
            add_char("8");
        }

        private void num9_Click(object sender, EventArgs e)
        {
            add_char("9");
        }

        private void num0_Click(object sender, EventArgs e)
        {
            add_char("0");
        }

        private void coma_Click(object sender, EventArgs e)
        {
            add_char(",");
        }

        private void add_Click(object sender, EventArgs e)
        {
            argument = float.Parse(label1.Text);
            do_event();
            ev = "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            argument = float.Parse(label1.Text);
            do_event();
            ev = "-";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            argument = float.Parse(label1.Text);
            do_event();
            ev = "x";
        }

        private void div_Click(object sender, EventArgs e)
        {
            argument = float.Parse(label1.Text);
            do_event();
            ev = "/";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            rezult = 0;
            argument = 0;
            ev = "";
            tmp = 1;
            label1.Text = "";
        }

        private void del_Click(object sender, EventArgs e)
        {   
            if (label1.Text.Length > 0)
            {
                String sub = label1.Text.Substring(0, label1.Text.Length - 1);
                label1.Text = sub;
            }
            ev = "";
            tmp = 0;
        }

        private void rez_Click(object sender, EventArgs e)
        {
            argument = float.Parse(label1.Text);
            do_event();
            label1.Text = rezult.ToString();
        }

        
    }
}
