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
    public partial class Form11 : Form
    {
        private Random ObjR = new Random();
        private int box = 0;
        private int roll; 

        public Form11()
        {
            InitializeComponent();
            button2.Enabled = false;
            


        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            button2.Enabled = true;
            button1.Enabled = false;
             
             roll = ObjR.Next(1, 7);
            label1.Text = roll.ToString();



            
            
          
          

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;

          

            box = box + roll; 


            
            
            

             
            switch (box)
            {
                case 1:
                    pictureBox1.BackColor = Color.Blue; 
                    break;

                case 2:
                    pictureBox2.BackColor = Color.Blue;
                    break;

                case 3:
                    pictureBox3.BackColor = Color.Blue;
                    break;

                case 4:
                    pictureBox4.BackColor = Color.Blue;
                    break;

                case 5:
                    pictureBox5.BackColor = Color.Blue;
                    break;

                case 6:
                    pictureBox6.BackColor = Color.Blue;
                    break;
                case 7:
                    pictureBox1.BackColor = Color.Blue;
                    box = 1;
                    break;
                case 8:
                    pictureBox2.BackColor = Color.Blue;
                    box = 2;
                    break;
                case 9:
                    pictureBox3.BackColor = Color.Blue;
                    box = 3;
                    break;
                case 10:
                    pictureBox4.BackColor = Color.Blue;
                    box = 4;
                    break;
                case 11:
                    pictureBox5.BackColor = Color.Blue;
                    box = 5;
                    break;
                case 12:
                    pictureBox6.BackColor = Color.Blue;
                    box = 6;
                    break;
            }
                if ((pictureBox1.BackColor == Color.Blue ) && (pictureBox2.BackColor == Color.Blue) && (pictureBox3.BackColor == Color.Blue) && (pictureBox4.BackColor == Color.Blue) && (pictureBox5.BackColor == Color.Blue) && (pictureBox6.BackColor == Color.Blue)) 
                {
                MessageBox.Show("You Win!");
                }



        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            this.Text = "The Game";
        }
    }
}
