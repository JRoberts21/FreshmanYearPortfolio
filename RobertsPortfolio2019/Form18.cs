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
    public partial class Form18 : Form
    {
        private Random ObjR = new Random();
        private int Counter = 0;
        private int Wrong = 0;
        private double PercentCorrect;

        public Form18()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int divisor = Convert.ToInt32(label4.Text);
            int dividend = Convert.ToInt32(label2.Text);
            int rem;
            int quotient;
            rem = dividend % divisor; //when youd divide it returns the raminder not the actual answer
            label15.Text = rem.ToString();
            quotient = (int)(dividend / divisor); // (int) returns the integer instead of the remainder
            label6.Text = quotient.ToString();


            //For the Counters 
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
            //For percent Correct
            double PercentCorrect = ((double)(Counter) / (double)(Counter + Wrong)) * 100.00;
            PercentCorrect = Math.Round(PercentCorrect, 0);
            label12.Text = PercentCorrect.ToString();

            button2.Enabled = true;
            button1.Enabled = false;

            //has a 30% chance to give you a message
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
            int ranNum = ObjR.Next(1, 13);
            label2.Text = ranNum.ToString(); //ToString converts the numerical variable to a string
            ranNum = ObjR.Next(1, 13);
            label4.Text = ranNum.ToString();
            label6.Text = " ";
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            this.Text = "Division V2";
            int ranNum = ObjR.Next(1, 13);
            label2.Text = ranNum.ToString(); //ToString converts the numerica variable to a string
            ranNum = ObjR.Next(1, 13);
            label4.Text = ranNum.ToString();


            button2.Enabled = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }
    }
}
