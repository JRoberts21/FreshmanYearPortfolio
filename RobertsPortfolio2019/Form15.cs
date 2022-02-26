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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            this.Text = "Check for Prime";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int prime = Convert.ToInt32(textBox1.Text);

            int fella = prime % 2; 

            if ((fella == 1) || (prime==2))
            {
                MessageBox.Show("prime");

            }
            else
            {
                MessageBox.Show("Composite");
            }

        }
    }
}
