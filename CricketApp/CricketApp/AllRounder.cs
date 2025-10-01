using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CricketApp
{
    internal class AllRounder : Cricketer
    {
        private double battingAvg;
        private int bowlingavg;
        

        public double BattingAvg
        {
            get { return battingAvg; }
            set {
                if (battingAvg >= 0)
                {
                    battingAvg = value;
                }
                else
                {
                    battingAvg = 0;
                }
            
            }
        }
        public int BowlingAvg
        {
            get { return bowlingavg; }
            set { 
            
                if (battingAvg >= 0) {
                    battingAvg = value;
                }
                else
                {
                    battingAvg = 0;
                }
            
            
            
            }
        }

        public AllRounder( string name, Dob dob,  double battingavg,int bowlingavg) : base( name,dob)
        {
            this.BattingAvg = battingavg;
            this.BowlingAvg = bowlingavg;
        }

      
        public override bool Check()
        {
            return bowlingavg >= 35 || battingAvg>=100 ;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"BattingAvg:{BattingAvg} BowlingAvg:{BowlingAvg} ");
            if (Check())
            {
                Console.WriteLine("Rest");
            }
            else
            {
                Console.WriteLine("Not Rest");

            }
        }



    }
}
