using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Socket_in_Client
{

    
    public partial class Form1 : Form
    {
        public static string ip;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ip = textBox1.Text;


            Client cl = new Client();
            cl.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
