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
    public partial class Form19 : Form
     
    {
       
        private int dividend; 

        private Random ObjR = new Random(); 
        public Form19()
        {
            InitializeComponent();
            this.Text = " ";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Hey dumbass, when you come back to this later, dont try using a string again. 

            dividend = Convert.ToInt32(textBox1.Text);

           while (dividend !=0 )
            {
                
                int rem = dividend % 2;
                dividend = dividend / 2;
                this.Text += rem.ToString();
               
            }
            string Back = this.Text;
            string Base2 = "";
            int num = Back.Length; 
            for (int i=Back.Length; i>0; i--)
            {
                Base2 += Back.Substring(i-1, 1);

            }
            this.Text = Base2; 


        }

        private void Form19_Load(object sender, EventArgs e)
        {
           
        }


    }
}
