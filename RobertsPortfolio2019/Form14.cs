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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(10);
            comboBox1.Items.Add(20);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int Combo = Convert.ToInt32(comboBox1.Text);

            if (Combo == 1)
            {

            }

            if (Combo == 10)
            {

            }

            if (Combo == 20)
            {


            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
