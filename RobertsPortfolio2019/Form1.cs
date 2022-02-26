using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobertsPortfolio2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Welcome Form";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Text = "Welcome Form";
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //create a new form 2 object
            Form2 ObjNextForm = new Form2();
            ObjNextForm.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 ObjNextForm = new Form3();
            ObjNextForm.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form5 ObjNextForm = new Form5();
            ObjNextForm.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form4 ObjNextForm = new Form4();
            ObjNextForm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form6 ObjNextForm = new Form6();
            ObjNextForm.Show();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Form7 ObjNextForm = new Form7();
            ObjNextForm.Show();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            Form8 ObjNextForm = new Form8();
            ObjNextForm.Show();
        }
    }
}
