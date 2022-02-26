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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Text = "Flashcards";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form3 ObjNextForm = new Form3();
            ObjNextForm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form4 ObjNextForm = new Form4();
            ObjNextForm.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form5 ObjNextForm = new Form5();
            ObjNextForm.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
