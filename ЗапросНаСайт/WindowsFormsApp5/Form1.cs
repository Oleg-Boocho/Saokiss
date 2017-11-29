using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Runtime.InteropServices;
using xNet;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

           
        private void Form1_Load(object sender, EventArgs e)
        {
            using(var request = new HttpRequest())
            {
                var urlParams = new RequestParams();

                urlParams["user"] = "Бучинский";
                urlParams["pass"] = "777";

                string s = request.Post("zapomnika.zzz.com.ua/Lab4.php", urlParams).ToString();
                textBox1.Text = s;
                webBrowser1.DocumentText = s;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
/*
 * WebRequest request = WebRequest.Create("http://zapomnika.zzz.com.ua/Lab4.php");
            request.Credentials = new NetworkCredential("Бучинский", "7777");
            webBrowser1.DocumentStream = request.GetResponse().GetResponseStream(); 
 * 
 * WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
                    textBox1.Text = reader.ReadToEnd(); 
                    response.Close();*/
