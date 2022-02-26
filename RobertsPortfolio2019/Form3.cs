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
    public partial class Form3 : Form
    {
        //Declare class level variables. Only use these when you have to
        //you put methods here, that can be used in any of the other methods in this program
        private Random ObjR = new Random();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int ranNum = ObjR.Next(0, 13);
            label2.Text = ranNum.ToString(); //ToString converts the numerica variable to a string
            ranNum = ObjR.Next(1, 13);
            label4.Text = ranNum.ToString();
            //in here is where local varaibles are stored
            this.Text = "Integer Division";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //get the data from labels 2 and 4
            //perform arithmatic operations
            //divide to get integer quotient with type cast
            //divide to get integer remainder with modulous division 
            //display quotient and remainder

            int divisor = Convert.ToInt32(label4.Text);
            int dividend = Convert.ToInt32(label2.Text);
            int rem;
            int quotient;
            rem = dividend % divisor; //when youd divide it returns the raminder not the actual answer
            label8.Text = rem.ToString(); 
            quotient = (int)(dividend / divisor); // (int) returns the integer instead of the remainder
            label6.Text = quotient.ToString(); 



        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //copy the code from form load
            //should also clear quotient and remainder

            int ranNum = ObjR.Next(0, 13);
            label2.Text = ranNum.ToString(); //ToString converts the numerica variable to a string
            ranNum = ObjR.Next(1, 13);
            label4.Text = ranNum.ToString();
            
            this.Text = "Integer Division";

            
            label6.Text = " ";
            label8.Text = " ";

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {
           
        }
    }
}
