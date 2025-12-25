//namespace datatypes // namespace is important and it gives the place of where the class is in folder or directory
//{
//    class Program // class and class name
//    {
        //static void Main(String[] args) //main function or simply a function, "Main" should be used not "main".
        //{
            /*int a = 10; // variable a is integer and 10 is stored 
            Console.WriteLine("Integer: " +a); // this act as print statement in C#
            float b = 1.45F; // F or f should always be used at end.
            float c = a+b;
            Console.WriteLine("decimal: " + c); // Write wont go to nextline WriteLine after printing goes to nextline.
            double d = 3.14; // f or F need not to be mentioned
            double e = 5.268;
            double f = d / e;
            Console.WriteLine("double: " +f);*/  // upto this assigning values to variables, diff between float, double, int & long, diff between write and writeline


            /*float n = 3.1561F;
            int n2 = (int)n; // implicit conversion
            int n3 = 15; 
            long n4 = n3; // explicit conversion
            Console.WriteLine(n2);
            Console.WriteLine(n3.GetType());
            Console.WriteLine(n4.GetType());*/ //upto this its implicit and explicit conversion


            /*int num1 = 19;
            Console.WriteLine(num1);
            Console.WriteLine(num1.GetType());
            string data = num1.ToString(); // store and give ToString or inside print statement directly giving ToString.
            Console.WriteLine(data);
            Console.WriteLine(data.GetType());*/ // Type conversion : int to string, float to string, double to string etc


            /*Console.WriteLine("Enter the data: ");
            string getdata1 = Console.ReadLine();
            string getdata2 = Console.ReadLine(); // this two getdata will be always in string as we didn't store both as int rather we directly gave inputs inside getdata3.
            int getdata3 = Int32.Parse(getdata1) + Int32.Parse(getdata2); // both getdata values given directly inside getdata3 so if GetType() is used it will still give it as String data type.
            Console.WriteLine(getdata3);*/ // getting input from user



            /*int age = 21;
            string Location = "Tamilnadu";
            string name = "Yoga";
            Console.WriteLine("HI I am " + name + " my age is " + age + " I am from " + Location); // string concatenation
            Console.WriteLine("HI I am {1} my age is {0} from {2}", age, name, Location); // String formatting here why index is 1 yet name is as second in comma seperated because that age,name, location is the one decide placeholder so if i need to change i have to change inisde placeholder or {} or change based on placeholder.
            Console.WriteLine($"HI I am {name} my age is {age} from {Location}"); // String interpretation here instead of placeholder directly the variable is given to do that $ symbol is used.
            Console.WriteLine($"HI I am {name} \nmy age is {age} from {Location}");
            Console.WriteLine(@"HI I am {0} \n my age is {1} from {2}", name, age, Location);*/ // String Verbattium.
                                                                                             // String Manipulation techniques.


            /*string firstname = "Goo";
            string lastname = "gle";
            Console.WriteLine(firstname.ToUpper() + lastname.ToLower()); // String Manipulation functions like ToUpper, ToLower, Length, Substring, IndexOf, Replace, Remove, Trim etc.
            string fullName = String.Concat(" "+firstname, lastname+" "); // example to create space and another way to concatenate strings.
            Console.WriteLine(fullName);
            Console.WriteLine(fullName.Trim()); // Trim is used to remove spaces before and after the string.
            Console.WriteLine(firstname.Substring(2)); // Substring is used to get part of string from given index.
            Console.WriteLine(firstname.IndexOf('e')); // IndexOf is used to get index of given character in string.
            Console.WriteLine(fullName.Replace("Goo", "Moo")); // Replace is used to replace part of string with given string.
            Console.WriteLine(fullName.Remove(0, 6)); // Remove is used to remove part of string from given index with given length including space.
            bool data = String.IsNullOrWhiteSpace(fullName); // IsNullOrWhiteSpace is used to check if string is null or empty or has only spaces.);
            bool data2 = String.IsNullOrEmpty(fullName); // IsNullOrEmpty is used to check if string is null or empty.
            Console.WriteLine(data);
            Console.WriteLine(data2);*/ // String Manipulation functions.


            /*int data = Console.Read();
            Console.WriteLine(data); // Read() function to read single character and give its ASCII value.
            Console.ReadKey(); // ReadKey() function to wait for a key press before closing the console window.
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine($"\nYou pressed {key.Key}");*/ // ReadKey() function to read single character and give the character itself.



//        }
//    }
//}