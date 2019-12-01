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
    public partial class Form6 : Form
    {
        private int fileIndex;

        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> lines = File.ReadAllLines(@"C:\\Users\\pakeezasaleem\\Desktop\\file.txt").ToList();

            string ID;
           ID = Convert.ToString(textBox1.Text);

            for(int i=0; i<lines.Count-1;i++)
            {

                if(lines[i]==ID)
                {

                    for(int j=0;j<6;j++)
                    {
                        lines.RemoveAt(0);
                    }
                }
            }
            File.WriteAllLines(@"C:\\Users\\pakeezasaleem\\Desktop\\file.txt", lines.ToArray());

        }
    }
}
