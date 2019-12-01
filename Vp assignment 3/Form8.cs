using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var str = File.ReadAllText(@"C:\Users\pakeeza saleem\Desktop\file2.txt");
            richTextBox1.Text = str;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
