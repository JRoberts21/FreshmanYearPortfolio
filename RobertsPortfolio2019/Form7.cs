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
    public partial class Form7 : Form
    {
        private int counter = 0;
        
        public Form7()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Yellow;
            pictureBox2.BackColor = Color.Yellow;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            pictureBox2.BackColor = Color.White;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            

        
                  counter ++;

            int rem = counter % 2;

            if (rem == 1)
            {
                button3.Text = "OFF";
                pictureBox1.BackColor = Color.White;
                pictureBox2.BackColor = Color.White;
           
            }
            else if (rem == 0)
            {
                button3.Text = "ON";
                pictureBox1.BackColor = Color.Yellow;
                pictureBox2.BackColor = Color.Yellow;
               
            }
           

            this.Text = counter.ToString(); 
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
