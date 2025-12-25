//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace OOPS
//{
    //public class Company // public means accessible to all other classes.
    //{
        //public int Id = 1;     // private by default, accessible only within this class. These are called class members or fields. When added public from private they change to public class.
        //private string Name = "Google LLC";// private by default, accessible only within this class. These are called class members or fields. When added public from private they change to public class.
                                           // we can provide id and name values in main function too thats why public is used.
                                           // If we keep it private we can only access it within this class(Company) not even in main class.

        // simplified getter and setter methods.
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value; // whatever value is passed from main function it will be assigned to private name variable. For that value key is used here.
        //                      // This will set the value of name variable whatever is passed from main function. 
        //    }
        //}

        //public void SetteR(string namesetter) {
        //    this.name = namesetter; // this will assign our inputed value or name value to the private name declared above.
        //}
        //public string GetteR() {
        //    return name; // this will return the private name value to the main function when called.
        //}

        // Another simplified version for accessing variables by directly using get and set this will set and get from main function itself.
        //public int Id { get; set; } // = 1; // this get and set will allow us to change id variable directly from main function.
        //public string Name { get; set; } // = "Google LLC"; // this get and set will allow us to change name variable directly from main function.
        //public string Location { get; set; } // = "USA";
        // Constructor - special method, It will always run first whatever code is inside it then remaining functions or methods will run.
        //public int CorelatedID { get; set; } // ="GoogleLLC";
        
        //public Company(int id, string name, string location) // constructor name should be same as class name and it will not have any return type.
        //{
        //    this.Id = id; // what here doing is instead of assigning values by implicitly by our selves we run the constructor and pass values to it.
        //    this.Name = name; // we can also give without this keyword but its not a good practice and both input should be different ex - Id != id - correct Id = Id means it will show error.
        //    Location = location; // example for not using this 
            
            //Console.WriteLine("Hi I am from Constructor of Company class"); // This will be first printed and remaining code will run after this. 
        //}
        
        //public Company()
        //{
            // For location not calling.
        //}
    //    public Company(int id, string name, int corelatedID) // new another constructor // multiple constructor.
    //    {
    //        Id = id;
    //        Name = name; // here why this constructor created was sometimes we would not want something to call or print here its 'location' so this will remove error of asking location in obj calling.
    //        // so whenever we run the main code, this constructor is picked by main function as they not wanting something particular. This makes sometimes we can give location and at the same time if dont want to then this will remove error of needing some property in object creation.
    //        CorelatedID = corelatedID;
    //    }
    //    public void DisplayCompanyInfo() // if this method was static , we could call it without creating an object of the class anywhere around the classes. Here its not static, so we need to create an object of the class to call this method.
    //    {
    //        Console.WriteLine($"Company ID: {Id} Company Name: {Name} Location: {Location}"); // here mentioned are direct Location, Name and Id not the value in constructor.
    //    }
    //    public void DisplayRequiredData()
    //    {
    //        Console.WriteLine($"Company ID: {Id} Company Name: {Name} Corelated With: {CorelatedID}");
    //    }
    //}
//}
