using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label1.Text) && !string.IsNullOrWhiteSpace(label1.Text)
            {
                int a = int.Parse(label1.Text);
                int c = a;
                int d = c;
                int m = d;
            }
        }
    }
}
