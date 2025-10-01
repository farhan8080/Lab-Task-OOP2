using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CricketApp
{
    struct Dob
    {
       public byte Day;
       public byte Month;
       public short Year;


        public Dob(byte day, byte month, short year)
        {
           this.Day = day;
           this. Month = month;
           this.Year = year;
        }
    }
        internal class Cricketer
    {
        private static int count=1;
        private string id;
        private string name;
        Dob dob;
      
        public virtual bool Check() {
            return false;
        }

        internal string Id
        {
            get { return id; }
            set { id = "C-" +value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Dob Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public Cricketer(string name,Dob dob){

            
            this.Id = count.ToString();
            count++;
            this.Name = name;
            this.Dob = dob;


           
         }

        public virtual void Show()
        {   
            Console.WriteLine($"Id:{Id}  Name:{name}  Dob:{Dob.Day}/{Dob.Month}/{Dob.Year}" );
        }

    }
}
