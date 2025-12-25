using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    internal class mainFunction
    {
        static void Main(string[] args)
        {
            Student stuobj = new Student();
            //stuobj.StuID = 1;
            //stuobj.StuName = "Loop"; // This like we cannot access because they both are private.
            stuobj.Id = 28;
            stuobj.Name = "Herbert";
            stuobj.StudentDetails();
        }
    }
}
