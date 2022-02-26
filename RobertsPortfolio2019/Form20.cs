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
    public partial class Form20 : Form
    {
        private int counter = 0;
        private int MilitaryCounter = 0;
        private int military;
        private string Hour;
        private string Minute;
        private string second; 
       
        public Form20()
        {
            InitializeComponent();
            
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            this.Text = " ";
        }

        private string YoinkHour(string p1)
        {
            //fix

             p1 = DateTime.Now.ToString();

            if (p1.Length == 22)
            {
                p1 = (p1.Substring(11, 2));
            }

            if (p1.Length == 21)
            {
                p1 = (p1.Substring(10, 2));

            }
            if (p1.Length == 20)
            {
                p1 = (p1.Substring(10, 1));
            }

            if (p1.Length == 19)
            {

                p1 = (p1.Substring(9, 1));
            }
            return p1;




        }

        private string YoinkMin(string p1)
        {
            if (p1.Length == 22)
            {
                p1 = (p1.Substring(14, 2));
            }

            if (p1.Length == 21)
            {
                p1 = (p1.Substring(13, 2));

            }
            if (p1.Length == 20)
            {
                p1 = (p1.Substring(12, 2));
            }
            if (p1.Length == 19)
            {

                p1 = (p1.Substring(11, 2));
            }


            return p1; 
        }

        

        private string YoinkDate(string p1)
        {
            string p2 = "!";

            //This is for the day 
            if (p1.Length == 22)
            {
                 p2 = (p1.Substring(3, 2));
            }

            if (p1.Length == 21)
            {
                 p2 = (p1.Substring(3, 1));
                //You should probably go buy some condoms for protection because this part is going to fuck me
            }
            if (p1.Length == 20)
            {
                 p2 = (p1.Substring(2, 2));
                //Life is meaningless
            }
            if (p1.Length == 19)
            {

                 p2 = (p1.Substring(0, 1));
            }





            string p3 = "!";

            //this is for year and needs fixed 
            if (p1.Length == 22)
            {
                p3 = p1.Substring(6, 4);
                
            }

            if (p1.Length == 21)
            {
                if ((p1.Substring(1, 1) == "2") || (p1.Substring(1, 1) == "1") || (p1.Substring(1, 1) == "0 "))
                {
                    p3 = p1.Substring(6, 4);

                }
                p3 = p1.Substring(5, 4);

            }
            if (p1.Length == 20)
            {
                if ((p1.Substring(3, 1) == "0") || (p1.Substring(3, 1) == "1") || (p1.Substring(3, 1) == "2") || (p1.Substring(3, 1) == "3") || (p1.Substring(3, 1) == "4") || (p1.Substring(3, 1) == "5") || (p1.Substring(3, 1) == "6") || (p1.Substring(3, 1) == "7") || (p1.Substring(3, 1) == "8") || (p1.Substring(3, 1) == "9"))
                {
                    p3 = p1.Substring(5, 4);

                }

                p3 = p1.Substring(5, 4);
            }

            if (p1.Length == 19)
            {

                p3 = p1.Substring(4, 1);
            }



            string p4 = "1";
            //Month
            if (p1.Length == 22)
            {
                p4 = (p1.Substring(0, 2));
            }

            if (p1.Length == 21)
            {
                if (p1.Substring(1, 1) == "/")
                {
                    p4 = p1.Substring(0, 1);
                }

                p4 = (p1.Substring(0, 2));
                //you know what to do
            }
            if (p1.Length == 20)
            {
                if (p1.Substring(1, 1) == "/")
                {
                    p4 = p1.Substring(0, 1);
                }


                p4 = p1.Substring(0, 2);
                //suicide is always an option 
            }

            if (p1.Length == 19)
            {

                p4 = (p1.Substring(0, 1));
            }

            string together = p4 +"/" + p2 + "/" + p3; 

            return together; 
        }

        private string YoinkSecond(string p1)
        {
            
            if (p1.Length == 22)
            {
                p1 = (p1.Substring(17, 2));
            }

            if (p1.Length == 21)
            {
                p1 = (p1.Substring(16, 2));

            }
            if (p1.Length == 20)
            {
                p1 = (p1.Substring(15, 2));
            }
            if (p1.Length == 19)
            {

                p1 = (p1.Substring(14, 2));
            }



            return p1;
        }

        private string YoinkAmPM(string p1)
        {
            

            if (p1.Length == 22)
            {
                p1 = (p1.Substring(20, 2));
            }

            if (p1.Length == 21)
            {
                p1 = (p1.Substring(19, 2));

            }
            if (p1.Length == 20)
            {
                p1 = (p1.Substring(18, 2));
            }
            if (p1.Length == 19)
            {

                p1 = (p1.Substring(17, 2));
            }

            
            return p1; 
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            
            string DT = DateTime.Now.ToString();
            
             second = YoinkSecond(DT);
            if (counter %2 ==1 )
            {
                Base2Second(); 

            }
          


            Hour = YoinkHour(DT);
            if (counter % 2== 1)
            {
                Base2Hour();

            }
            if(MilitaryCounter % 2== 1)
            {
                Hour = military.ToString();

            }

            
             Minute = YoinkMin(DT);
            if (counter % 2 == 1)
            {
                Base2Minute();

            }

            //these wont be affected by base 2 or military so leave these alone
            string AMPM = YoinkAmPM(DT);
            string Date = YoinkDate(DT);

            label1.Text = Hour + ":" + Minute + ":"  + second + " " + AMPM;
            label2.Text = Date; 


           
            



            //convert to military 
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter % 2 == 1)
            {
                button1.Text = "Base 10";

            }
            else
            {
                button1.Text = "Base 2"; 
            }

        }

        private void Base2Hour()
        {
            int dividend = Convert.ToInt32(Hour);
            string forward ="";

            while (dividend != 0)
            {

                int rem = dividend % 2;
                dividend = dividend / 2;
                forward += rem.ToString();
                 
            }
            string Back =forward;
            string Base2 = "";
            int num = Back.Length;
            for (int i = Back.Length; i > 0; i--)
            {
                Base2 += Back.Substring(i - 1, 1);

            }
            Hour = Base2;




            

        }

        private void Base2Minute()
        {
            int dividend = Convert.ToInt32(Minute);
            string forward = "";

            while (dividend != 0)
            {

                int rem = dividend % 2;
                dividend = dividend / 2;
                forward += rem.ToString();

            }
            string Back = forward;
            string Base2 = "";
            int num = Back.Length;
            for (int i = Back.Length; i > 0; i--)
            {
                Base2 += Back.Substring(i - 1, 1);

            }
            Minute = Base2;

        }

        private void Base2Second()
        {
            int dividend = Convert.ToInt32(second);
            string forward = "";

            while (dividend != 0)
            {

                int rem = dividend % 2;
                dividend = dividend / 2;
                forward += rem.ToString();

            }
            string Back = forward;
            string Base2 = "";
            int num = Back.Length;
            for (int i = Back.Length; i > 0; i--)
            {
                Base2 += Back.Substring(i - 1, 1);

            }
            second = Base2;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MilitaryCounter ++; 
            string l1 = label1.Text;
             military = 1;
            
            if ((l1.Substring(8,2)== "PM") & (l1.Substring(0,2) != "12"))
            {
                if(l1.Substring(1,1) == ":")
                {
                     military = Convert.ToInt32(l1.Substring(0, 1));
                    military = military + 12;
                    

                }
                if (l1.Substring(1,1) != ":")
                {

                    military = Convert.ToInt32(l1.Substring(0, 2));
                    military = military + 12;
                    
                }
            }

        }
    }
}
