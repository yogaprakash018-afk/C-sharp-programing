using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class SemiBus : Bus // Single inheritance and if we inherit we absolutly need to create constructor.
    {
        public int num;
        public SemiBus(int ACNum) : base(ACNum)
        {
            ACNum = num;
        }
        public override void Details() // This will override parent class function Details and this function will execute.
                                       // In base class virtual keyword should present or else this child class cannot override that function.
        {
            // if both child and parent class also has same function or method name, like here - Details; and if we call it using any obj like semibus or bus it will run parent function only.
            Console.WriteLine($"Semibus : {ACNum}");
        }
        public sealed override void Capacity() // If we use sealed it will block next inherited semischoolbus class to not use override or override wont work. Thats why new keyword is used.
        {
            Console.WriteLine("Capacity is : 30");
        }
    }
}
