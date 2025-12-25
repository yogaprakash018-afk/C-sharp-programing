using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Encapsulation
{
    class Student
    {
        private int StuID { get; set; }
        private string StuName { get; set; } = "";

        public int Id
        {
            get{
                return StuID; 
            }
            set{
                StuID = value;  // This function returns stuid and store what property we are giving in main function using value keyword.
            }
        }
        public string Name
        {
            get { return StuName; }
            set { StuName = value; } // This function returns stu and store what property we are giving in main function using value keyword.
        }
        public void StudentDetails()
        {
            Console.WriteLine($"Student ID : {StuID}, Student Name : {StuName}");
        }
    }
}