//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Text;

//namespace OOPS
//{
//    internal class ParttimeEmployee : Company2 // inheriting Company2 class to ParttimeEmployee class.
//    {
//        public string PartTimeEmployeeName { get; set; } = "";
//        public int PtEmployeePhoneNumber { get; set; }
//        public int PtEmployeeSalary { get; set; }

//        public ParttimeEmployee(string PTEName, int PTEphone, int PTEsalary, int CompanyId, string CompanyName, string LocationofCompany) : base(CompanyId, CompanyName, LocationofCompany) // we get inputs and give to base class or parent class.
//        {
//            PartTimeEmployeeName = PTEName;
//            PtEmployeePhoneNumber = PTEphone;
//            PtEmployeeSalary = PTEsalary;
//        }
//        public void DisplayPTEmployee()
//        {
//            Console.WriteLine($"Part Time Employee Name: {PartTimeEmployeeName}, Phone Number: {PtEmployeePhoneNumber}, Salary: {PtEmployeeSalary}");
//        }
//    }
//}
