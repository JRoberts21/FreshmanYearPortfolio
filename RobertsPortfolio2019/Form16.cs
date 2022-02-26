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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form9 ObjNextForm = new Form9();
            ObjNextForm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form17 ObjNextForm = new Form17();
            ObjNextForm.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form18 ObjNextForm = new Form18();
            ObjNextForm.Show();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            this.Text = "Flashcards V2";
        }
    }
}
