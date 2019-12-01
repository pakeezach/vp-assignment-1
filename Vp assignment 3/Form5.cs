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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string line;
            int ch, counter = 0;
            string[] words = File.ReadAllText(@"C:\Users\pakeeza saleem\Desktop\file.txt").Split( ' ' );
            string ID;
            ID = Convert.ToString(textBox1.Text);
            bool condition = false;
            for( int i=0; i<words.Length; i++)
            {
                if (words[i].Contains(ID) == true)
                {
                    MessageBox.Show(words[i] + " ");
                }
               else
                {
                   
                    condition = false;
                    
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
