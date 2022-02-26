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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();

        }


        private void Form12_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add(1.ToString());
            comboBox1.Items.Add(2.ToString());
            comboBox1.Items.Add(3.ToString());

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int Combo = Convert.ToInt32(comboBox1.Text);

            if (Combo == 1)
            {
                double truncate = Convert.ToDouble(textBox1.Text);
                Double multiply = (int)(truncate * 10);


                label3.Text = multiply.ToString();
                double deci = Convert.ToDouble(label3.Text);
                double division = deci / 10;


                this.Text = division.ToString();


            }
            if (Combo == 2)
            {
                double truncate = Convert.ToDouble(textBox1.Text);
                Double multiply = (int)(truncate * 100);


                label3.Text = multiply.ToString();
                double deci = Convert.ToDouble(label3.Text);
                double division = deci / 100;


                this.Text = division.ToString();


            }
            if (Combo == 3)
            {
                double truncate = Convert.ToDouble(textBox1.Text);
                Double multiply = (int)(truncate * 1000);


                label3.Text = multiply.ToString();
                double deci = Convert.ToDouble(label3.Text);
                double division = deci / 1000;


                this.Text = division.ToString();



            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            this.Text = " ";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
