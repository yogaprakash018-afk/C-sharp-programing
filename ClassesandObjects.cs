//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace OOPS
//{
//    class ClassesandObjects
//    {
//        static void Main(string[] args)
//        {
            // we are going to create a company class and create objects of that class.
            //Company googleobj = new Company(1, "Google LLC", "USA"); // Object creation, googleobj is one of the object of class Company.
            //googleobj.DisplayCompanyInfo(); // object calling.

            //Company youtubeobj = new Company(2, "Youtube", 1); // we can create multiple objects for a single class.
            //// youtubeobj.Id = 2; // Only youtube object properties are set because for google already set in Company class itself.
            //// youtubeobj.SetteR("Youtube"); // youtube object properties are set. Why two objects are because we can have multiple objects to single class for reusability of code.
            //// As setter function is giving this youtube to assign to that private string name in Company class. This SetteR is created by us and inside it has this.name = name;.
            //// youtubeobj.Name = "Youtube"; // Using property to set the name as youtube.

            //// Console.WriteLine("Company ID: {0}", youtubeobj.Id); // This will print id and we can access id to change it to 2 then print for particulary youtube object yet it wont change to 2 in class company.
            //                                             //Console.WriteLine("Company name: {0}", youtubeobj.name) // But we cannot access the name yet because its private. So to bring that name i want to use getter.
            //// Console.WriteLine("Company Name: {0}", youtubeobj.Name);

            //youtubeobj.DisplayRequiredData(); // As previously the name youtube will assigned using SetteR - this.name = name and printed using GetteR - return name; so to understand we both print and call the function.

            //Company facebookobj = new Company(3, "Facebook", 1);
            //facebookobj.DisplayRequiredData();

            //Company titkokobj = new Company // this is another way of giving properties to function using object creation.
            //{
            //    Id = 4,
            //    Name = "TitTok",
            //    Location = "China"
            //};
            //titkokobj.DisplayCompanyInfo(); // this will print all the properties of titkok object including location and this will take empty constructor.
            // titkokobj.DisplayRequiredData(); // this will print only id and name of titkok object. This will take constructor with two parameters id and name.

            //List<Company> companies = new List<Company> {  // this will be accepted and no error will shown and, we can give classes to list.
            //new Company
            //{
            //    Id = 1,
            //    Name = "Google LLC",
            //    Location = "USA"
            //},
            //new Company
            //{
            //    Id = 2,
            //    Name = "Youtube",
            //    Location = "USA",
            //    CorelatedID = 1
            //},
            //new Company
            //{
            //    Id = 3,
            //    Name = "Facebook",
            //    Location = "USA",
            //    CorelatedID = 1
            //},
            // new Company
            //{ 
            //    Id = 4,
            //    Name = "TikTok",
            //    Location = "CHINA"
            //}
            //};
            //foreach(var i in companies) // to print required company details from the list of companies. Var is given to assign any data type rather changing it all the time.
            //{
            //    Console.WriteLine($"Name: {i.Name}, ID: {i.Id}, Location: {i.Location}");
            //}
            // Classes and Objects upto this.

            // Four Pillars of OOPS - Encapsulation, Abstraction, Inheritance, Polymorphism.

            //Employee empobj = new Employee(456, "Micheal", 1234567890,50000, 1, "Google LLC", "USA"); // 456 - employee, employee, employee, employee salary, company id, company name, company location.
            ////empobj.CompanyData(); // in employee class there is no function called CompanyData, but as employee is inheriting company2 class we can call that function here.
            //// the parent class gave it properties to employee class. So employee class or child class can access it or using child class we call parent class function.
            //// Company2 comobj = new Company2(2, "Youtube", "USA");
            //// comobj.CompanyInfo(); // This like also we can do, we can use child class to get details of parent class or parent class is directly called to get its own details.
            //empobj.EmployeeInfo(); // child class function
            //empobj.CompanyData();  // parent class function
            //empobj.SalaryDetails(); // inherited interface function. All can be accessed by child class.
            //// upto this multiple and single inheritance and interface and how multiple inheritance achieved by interface.
            //Boss bossobj = new Boss(12, "Andreson", 0123456897 , 75000, 1, "Google LLC", "USA"); // 12 - boss, boss, boss, boss salary, company id, company name, company location.
            //bossobj.EmployeeInfo(); // We did create boss function yet we can use employee functions to create boss properties.
            //bossobj.SalaryDetails(); // We can also use or get functions of interface that is with child class employee.
            // Flow - parent - company2 inherited by employee(child class) interface - Iemployeesalary inherited by employee(Child class), the Boss class inherits all these from already a child class employee. This is called multilevel inheritance.
            // upto this multilevel inheritance, interface, single, multiple inheritance and how only using interface then only we achieve multiple inheritance achieved done.
            //ParttimeEmployee PTEobj = new ParttimeEmployee("TIM", 123546871, 20000, 1, "Google LLC", "USA");
            //PTEobj.CompanyData();
            // PTEobj.EmployeeInfo(); // we cannot get employee datas but we can get company2 class details.
            //PTEobj.DisplayPTEmployee();
            // Hierachical inheritance done here. Company2 is parent class, Employee and ParttimeEmployee are 2 child classes.
            // for one parent multiple children are there then they are called hierarchical inheritance.

            /* Company2 - parent
             * Employee - child
             * ParttimeEmployee - child 
             * this is called hierarchical.*/
            // for a child multiple parents are not possible in C# directly. 
//        }
//    }
//}
