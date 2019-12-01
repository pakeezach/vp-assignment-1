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
    public partial class Form7 : Form
    {
        string Pname,Aname,AID, PID;
        public Form7()
        {
           
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
           
            using (StreamWriter sw = new StreamWriter(@"C:\Users\pakeeza saleem\Desktop\file2.txt", true))
            {
                sw.WriteLine(Pname);
                sw.WriteLine(PID);
                sw.WriteLine(Aname);
                sw.WriteLine(AID);

            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            PID= Convert.ToString(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 fm = new Form8();
            fm.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

           
            Pname = Convert.ToString(textBox2.Text);
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
            AID = Convert.ToString(textBox4.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Aname = Convert.ToString(textBox3.Text);
        }
    }
}
