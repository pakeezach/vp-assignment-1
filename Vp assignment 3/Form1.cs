using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cprofile_Click(object sender, EventArgs e)
        {

            Form2 fm=new Form2();
            fm.Show();


        }

        private void Search_Click(object sender, EventArgs e)
        {

            Form3 fm = new Form3();
            fm.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Form6 fm = new Form6();
            fm.Show();
        }

        private void Attendance_Click(object sender, EventArgs e)
        {
            Form7 fm = new Form7();
            fm.Show();
        }

        private void ViewAttend_Click(object sender, EventArgs e)
        {
            Form8 fm = new Form8();
            fm.Show();
        }

        private void Top3_Click(object sender, EventArgs e)
        {
            Form9 fm = new Form9();
            fm.Show();

        }
    }
}