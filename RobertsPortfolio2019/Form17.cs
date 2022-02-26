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
    public partial class Form17 : Form
    {
        private Random ObjR = new Random();
        private int Counter = 0;
        private int Wrong = 0;
        private double PercentCorrect;
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            this.Text = "Addition V2";
            int ranNum = ObjR.Next(0, 13);
            label2.Text = ranNum.ToString(); //ToString converts the numerica variable to a string
            ranNum = ObjR.Next(0, 13);
            label4.Text = ranNum.ToString();


            button2.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //this one does the math
            int Variable1 = Convert.ToInt32(label2.Text);
            int Variable2 = Convert.ToInt32(label4.Text);

            int equals = Variable1 - Variable2;
            label6.Text = equals.ToString();
            int sum;
            sum = Variable1 - Variable2;


            //This is the counters for # correct and wrong 
            if (textBox1.Text == label6.Text)

            {
                Counter = Counter + 1;
                label8.Text = Counter.ToString();
            }
            else
            {
                Wrong = Wrong + 1;
                label10.Text = Wrong.ToString();
            }

            //fun stuff with buttons 
            button2.Enabled = true;
            if (button2.Enabled == true)
            {
                button1.Enabled = false;
            }

            // this is for %correct
            double PercentCorrect = ((double)(Counter) / (double)(Counter + Wrong)) * 100.00;
            PercentCorrect = Math.Round(PercentCorrect, 0);
            label12.Text = PercentCorrect.ToString();


            int ranMessage = ObjR.Next(1, 11);
            if (PercentCorrect >= 80)
            {
                if ((ranMessage == 1) || (ranMessage == 2) || (ranMessage == 3))
                {

                    MessageBox.Show("Keep up the Good Work");
                }

            }

            if (PercentCorrect <= 70)
            {
                if ((ranMessage == 1) || (ranMessage == 2) || (ranMessage == 3))
                {

                    MessageBox.Show("Spend More Time Studying");
                }

            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Text = "Flash Cards V2";
            int ranNum = ObjR.Next(0, 13);
            label2.Text = ranNum.ToString(); //ToString converts the numerical variable to a string
            ranNum = ObjR.Next(0, 13);
            label4.Text = ranNum.ToString();
            label6.Text = " ";
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
