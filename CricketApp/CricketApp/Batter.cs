using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketApp
{
    internal class Batter :  Cricketer
    {
        private double totalrun;



        public double Totalrun
        {
            get { return totalrun; }
            set { totalrun = value; }
        }

        public Batter( string name,Dob dob, double totalrun)  : base( name,dob)
        {  
            this.Totalrun = totalrun;   
        }

       

        public override bool Check()
        {
            return totalrun%50==0;
        }


        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Totalrun:{Totalrun}");
            if (Check())
            {
                Console.WriteLine("Rest");
            }
            else {
                Console.WriteLine("Not Rest");
                
                }

        }
    }
}
