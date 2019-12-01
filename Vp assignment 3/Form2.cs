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
    public partial class Form2 : Form
    {
        string name;
        string ID;
        string uni;
        string dep;
        string cgpa;
       
        
        
        


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw= new StreamWriter(@"C:\Users\pakeeza saleem\Desktop\file.txt",true))
            {
                sw.WriteLine(name);
                sw.WriteLine(ID);
                sw.WriteLine(uni);
                sw.WriteLine(dep);
                sw.WriteLine(cgpa);
                sw.WriteLine("  ");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = Convert.ToString(textBox1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ID = Convert.ToString(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            uni = Convert.ToString(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dep= Convert.ToString(textBox5.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cgpa = Convert.ToString(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
