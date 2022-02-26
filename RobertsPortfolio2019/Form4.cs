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
    public partial class Form4 : Form
    {
        private Random ObjR = new Random();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int ranNum = ObjR.Next(0, 100);
            label2.Text = ranNum.ToString(); //ToString converts the numerica variable to a string
            ranNum = ObjR.Next(0, 100);
            label4.Text = ranNum.ToString();
            this.Text = "Addition"; 
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int Variable1 = Convert.ToInt32(label4.Text);
            int Variable2 = Convert.ToInt32(label2.Text);

            int equals = Variable1 + Variable2;
            label6.Text = equals.ToString();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label6.Text = " ";
            int ranNum = ObjR.Next(0, 100);
            label2.Text = ranNum.ToString(); //ToString converts the numerica variable to a string
            ranNum = ObjR.Next(0, 100);
            label4.Text = ranNum.ToString();
            this.Text = "Addition";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
