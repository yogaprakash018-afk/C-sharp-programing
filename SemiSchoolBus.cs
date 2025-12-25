using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class SemiSchoolBus : SemiBus // Multilevel inheritance.
    {
        public SemiSchoolBus(int ACNum) : base(ACNum)
        { 
      
        }
        public new void Details() // Without giving override to semibus function we cannot override here because this semischoolbus inherits from semibus thats why.
        {                          // // We can also use new keyword to use that to hide function present in base class or parent class.
            Console.WriteLine($"SemiSchoolBus: {ACNum}");
        }
    }
}
