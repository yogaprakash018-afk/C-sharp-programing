using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Bus
    {
        public int ACNum { get; set; }
        public virtual void Details() // Virtual is given to make child class override parent class function if they are same. If virtual keyword is not used here child class will not overrid this.
        {                                    // If we Use sealed keyword it wont let any child class override it.
            Console.WriteLine($"Bus with AC : {ACNum}");
        }
        public  virtual void Capacity()
        {
            Console.WriteLine("Capacity is : 40");
        }
        public Bus(int acnum)
        {
            ACNum = acnum;
        }

    }
}
