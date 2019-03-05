using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(textBox1.Text);
            int so2 = int.Parse(textBox2.Text);       
            int so3 = so1 + so2;
        }

      

    }
}
