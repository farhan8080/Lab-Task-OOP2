using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cricketer[] c = new Cricketer[7];



          

            c[0] = new Batter("Ahmed", new Dob(2, 3, 2002), 50);
            c[1] = new Bowler("Rahim", new Dob(5, 6, 2000), 15);
            c[2] = new AllRounder("Hasan", new Dob(10, 12, 1999), 45.4,25);
            c[3] = new Batter("Karim", new Dob(2, 3, 2001), 150);
            c[4] = new Batter("Sumon", new Dob(2, 3, 2003), 200);


            foreach (Cricketer c2 in c)
            {


               c2.Show();

                Console.WriteLine();
               


            }

           


        }
    }
}
