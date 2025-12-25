using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    public class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);

        }
        public void Add(int a, int b, int c) // Here two same function name but different input parameters thats why its not showing any error.
        {
            Console.WriteLine(a + b + c);

        }
    
    }
}
