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
    //This program will verify text scores and uses try catch to verify the inputs

    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string grade;
                double t1 = Convert.ToDouble(textBox1.Text);
                double t2 = Convert.ToDouble(textBox2.Text);
                double p1 = Convert.ToDouble(textBox3.Text);
                double p2 = Convert.ToDouble(textBox4.Text);
                double p3 = Convert.ToDouble(textBox5.Text);

                double wtAvg = (((t1 + t2) / 2.0) * .6) + (((p1 + p2 + p3) / 3.0) * .4);

                if (wtAvg >= 90.0)
                {
                    grade = "A";
                }
                else
                {
                    if (wtAvg >= 80.0)
                    {
                        grade = "B";
                    }
                    else
                    {
                        if (wtAvg >= 70.0)
                        {
                            grade = "C";
                        }
                        else
                        {
                            if (wtAvg >= 60.0)
                            {
                                grade = "D";
                            }
                            else
                            {
                                grade = "F";
                            }
                        }
                    }
                }
                label8.Text = wtAvg.ToString();
                label9.Text = grade;
            }
            catch {
                MessageBox.Show("Please enter a value");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string grade = "*";
            double t1 = Convert.ToDouble(textBox1.Text);
            double t2 = Convert.ToDouble(textBox2.Text);
            double p1 = Convert.ToDouble(textBox3.Text);
            double p2 = Convert.ToDouble(textBox4.Text);
            double p3 = Convert.ToDouble(textBox5.Text);

            double wtAvg = (((t1 + t2) / 2.0) * .6) + (((p1 + p2 + p3) / 3.0) * .4);

            if (wtAvg >= 0)
            {
                grade = "F";
            }


            if (wtAvg >= 60.0)
            {
                grade = "D";
            }

            if (wtAvg >= 70.0)
            {
                grade = "C";
            }


            if (wtAvg >= 80.0)
            {
                grade = "B";
            }


            if (wtAvg >= 90.0)
            {
                grade = "A";
            }


            label8.Text = wtAvg.ToString();
            label9.Text = grade;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            bool inputIsOK = true;

            try
            {
                double t1 = Convert.ToDouble(textBox1.Text);
                double t2 = Convert.ToDouble(textBox2.Text);
                double p1 = Convert.ToDouble(textBox3.Text);
                double p2 = Convert.ToDouble(textBox4.Text);
                double p3 = Convert.ToDouble(textBox5.Text);

                if ((t1 < 0.0) || (t1 > 100.0))
                {
                    inputIsOK = false;
                }

                if ((t2 < 0.0) || (t2 > 100.0))
                {
                    inputIsOK = false;
                }

                if ((p1 < 0.0) || (p1 > 100.0))
                {
                    inputIsOK = false;
                }

                if ((p2 < 0.0) || (p2 > 100.0))
                {
                    inputIsOK = false;
                }

                if ((p3 < 0.0) || (p3 > 100.0))
                {
                    inputIsOK = false;
                }

                if (inputIsOK == false)
                {
                    MessageBox.Show("Data out of Range");
                }
                else
                {
                    MessageBox.Show("Data is ok");
                }
            }
            catch
            {
                MessageBox.Show("Invalid Data Type");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double t1 = Convert.ToDouble(textBox1.Text);

            if ((t1 >= 0.0) && (t1 <= 100.0))
            {
                MessageBox.Show("Good Test 1 Score");

            }
            else
            {
                MessageBox.Show("Bad Test 1 Score");
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
