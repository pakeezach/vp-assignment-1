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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] words = File.ReadAllText(@"C:\Users\pakeeza saleem\Desktop\file.txt").Split(' ');
            string name;
            name = Convert.ToString(SStName.Text);
            bool condition = false;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(name) == true)
                {
                    MessageBox.Show(words[i] + " ");
                }
                else
                {

                    condition = false;

                }

            }

        }
    }
}