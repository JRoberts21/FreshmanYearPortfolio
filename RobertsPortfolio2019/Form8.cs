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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form6 ObjNextForm = new Form6();
            ObjNextForm.Show();  
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form16 ObjNextForm = new Form16();
            ObjNextForm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form7 ObjNextForm = new Form7();
            ObjNextForm.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.Text = "Programs";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form10 ObjNextForm = new Form10();
            ObjNextForm.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Form11 ObjNextForm = new Form11();
            ObjNextForm.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
           
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Form13 ObjNextForm = new Form13();
            ObjNextForm.Show();
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            Form12 ObjNextForm = new Form12();
            ObjNextForm.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Form14 ObjNextForm = new Form14();
            ObjNextForm.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Form15 ObjNextForm = new Form15();
            ObjNextForm.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Form19 ObjNextForm = new Form19();
            ObjNextForm.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Form20 ObjNextForm = new Form20();
            ObjNextForm.Show(); 
        }
    }
}
