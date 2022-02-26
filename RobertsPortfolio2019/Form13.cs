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
    public partial class Form13 : Form
    {
        private Random ObjR = new Random();
        public int Biggest = -1;
        private int rNum;
        private int i;
        public Form13()
        {
            InitializeComponent();
            this.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            rNum = 0;
            int lim = Convert.ToInt32(textBox1.Text);
            //for (int i=1; i<=10; i++)
            for (int i = 1; i <= lim; i++)
            {
                rNum = ObjR.Next(1, 101);
                this.Text += "*" + rNum.ToString() + "* ";
                if (rNum > Biggest)
                {
                    Biggest = rNum;
                }
            }

            MessageBox.Show(Biggest.ToString());

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Biggest = -1;
            this.Text = "";
            rNum = 0;
            i = 1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int fib1 = 0;
            int fib2 = 1;


            int limit = Convert.ToInt32(textBox1.Text);
            this.Text = (fib1 + "*" + fib2 + "*");
            for (int i = 1; i <= limit; i++)
            {

                int NextFib = fib1 + fib2;
                this.Text += "* " + NextFib.ToString() + "* ";
                fib1 = fib2;
                fib2 = NextFib;

            }
        }
    }
}
