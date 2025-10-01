using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketApp
{
    internal class Bowler : Cricketer
    {
        private int totalwicket;

        public int TotalWicket
        {
            get { return totalwicket; }
            set { totalwicket = value; }
        }

        public Bowler(string name,Dob dob ,int totalwicket) : base(name,dob)
        {
            this.totalwicket = totalwicket;
        }

       
        

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"TotalWicket:{TotalWicket}");
        }

    }
}
