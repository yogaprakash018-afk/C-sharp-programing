//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace OOPS
//{
//    //child class or derived class or sub class.
//    public class Employee : Company2, IEmployeeSalary // using colon and class name we can inherit the properties and methods of base class Company2.
//                                        // When we inherit or extend a interface we should absolutely use its property if not it will show error.
//                                        // to fix that or get that function from interface press control+. to automatically create a function from interface.
//                                        // We can add multiple interfaces, but class can be only done one, so using interface we can achieve multiple inheritance.
//    {
//        public int EmployeeID { get; set; }
//        //public string? EmployeeName { get; set; } // that ? means it can hold null value also. In int it does not required because int by default hold 0 value.
//        //public string? Address { get; set; } // that ? means it can hold null value also.
//        public string EmployeeName { get; set; } = "";
//        public int PhoneNumber { get; set; }
//        public int Salary { get; set; }
//        public Employee(int employeeid, string employeename, int phonenum, int salary, int CompanyId, string CompanyName, string LocationofCompany) : base(CompanyId, CompanyName, LocationofCompany) // the constructor we are creating will always require the base class constructor parameters also.
//        {
//            // The values or id,name, location we are passing here will be passed to base class constructor using base keyword.
//            // this is the child class this child will get values and give it to parent class using base keyword.
//            EmployeeID = employeeid;
//            EmployeeName = employeename;
//            PhoneNumber = phonenum;
//            Salary = salary;
//        }
//        public Employee()  // To create empty constructor in child class we should also create empty constructor in parent class.
//        {

//        }
//        public void CompanyDetails() // Accessing Company2 class by child class Employee.
//        {
//            Console.WriteLine($"Company ID is {CompanyId}, Company Name is {CompanyName}, Location is {LocationofCompany}");
//        }
//        public void EmployeeInfo()
//        {
//            Console.WriteLine($"Employee ID is {EmployeeID}, Employee Name is {EmployeeName}, CompanyName: {CompanyName}, Phonenumber {PhoneNumber}");
//        }

//        public int SalaryDetails() // Coming from interface IEmployeeSalary. Using Employee object we can access this.
//        {
//            Console.WriteLine($"Salary of Employee: {Salary}");
//            return Salary;
//        }

//    }
//}
