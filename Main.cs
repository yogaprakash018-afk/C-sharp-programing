using Polymorphism;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace OOPS
{
    public class Polymorphism
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            //Console.WriteLine(calc.Add(10,20)); // why this console.write is used it in calculator class only return a + b is there it will not print the a + b so to do that this used.
            //calc.Add(10, 20); // this will run for 1st function in calculator class.

            //calc.Add(10, 20, 30); // this will run for 2nd function in calculator class.
            // This is called method overloading, even though functions names are same it will identidy what to call based on no of inputs.
            // Method overloading will have same function name but different signature or different kinds of inputs.
            // if overloaded it will show +1 overload if we hoaver over it.
            // upto this static or compile time polymorphism and method overloading is done.

            Bus bus = new Bus(10);
            bus.Details();
            SemiBus semi = new SemiBus(8);
            semi.Details(); // this Details function is from Bus class as its inherited it can be used by semibus too.
            //Bus semibusobj = new SemiBus(11); // For Bus class object we create using SemiBus class too.
            //semibusobj.Details(); // This is Bus class function yet its accessed.
            /* sameclass obj = new sameclass(); - this like we can do
             * oneclass obj = new anotherclass(); - this like also we can do with inheritance/ if a class is inherited by another class.
             * But we cannot create child class obj with parent class ex: SemiBus obj = new Bus(); - this like we cannot create, its only applied for parent class.*/
            // 1 parent can controll a child but 1 child cannot control parent.
            SemiBus schoolbus = new SemiSchoolBus(18);
            schoolbus.Details();
            SemiBus schoolobj2 = new SemiSchoolBus(4);
            schoolbus.Capacity();
            
            // In semischoolbus class also there is one override and it will override Bus class function.
        
        }
    }
}
