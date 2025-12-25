//using System.Collections;
//using System.ComponentModel;

//namespace datatypes
//{
//    class Collections{
//        static void Main(string[] args)
//        {
//            types();
//        }
//        public static void types()
//        {
// Array and its Syntax
// int[] numbers = new int[5]; // int - datatype, [] - array syntax, new - keyword to create array box virtually, int[5] - size of the array - we can store 5 values or datas.
// string[] names = { "Alice", "Bob", "Charlie" }; // string - datatype, [] - array syntax, {} - array initializer with values, this is another way to create and initialize an array.
// double[] num1 = new double[] { 1.1, 2.2, 3.3 }; // double - datatype, [] - array syntax, new double[] - keyword to create array box virtually with datatype, {} - array initializer with values.

//int[] array = new int[5];
//array[0] = 10; // Assigning first value to the first index 0
//array[1] = 20; // Assigning second value to the second index 1
//array[2] = 30; // Assigning third value to the third index 2
//array[3] = 40; // Assigning fourth value to the fourth index 3
//array[4] = 50; // Assigning fifth value to the fifth index 4

//// OR

//int[] arr = new int[] { 100, 200, 300, 400, 500 };

//// OR

//int[] nums = { 5, 10, 15, 20, 25 };


// Console.WriteLine(array);
// Console.WriteLine(nums);
// Console.WriteLine(arr); // all these will print the reference of the array in the memory location or thier datatype.

// Console.WriteLine(array[0]); // prints 10, this is the way to access the value at index 0 of the array.
// Console.WriteLine(nums[3]); // prints 20, this is the way to access the value at index 3 of the array.
// Console.WriteLine(nums[1]); // prints 200, this is the way to access the value at index 1 of the array.
// Console.WriteLine(nums[5]); // This will throw an IndexOutOfRangeException because index 5 is out of bounds for an array of size 5 (valid indices are 0 to 4).
// This way of printing we need each Console.WriteLine for each value to print so we use for each loop to print our required values.

//array[1] = 25; // updating the value at index 1 of the array to 25 from 20. we can directly update the value by specifying the index and new value to update.
//arr[0] = 150; // updating the value at index 0 of the array to 150 from 100.
//nums[4] = 30; // updating the value at index 4 of the array to 30 from 25.

//foreach (int i in arr) // foreach - loop name or keyword, int - datatype we have or we need to print or use, i - our own variable to hold each value during iteration, in - keyword to specify the collection to iterate over, arr - the array we are iterating over.
//{
//    Console.WriteLine(i); // the i in foreach loop holds value of arr index not index itself thats why it prints each value of the array arr one by one.
//}


//for (int i = 0; i < array.Length; i++) // length - a keyword or property to get the size of the array, i - our own variable to hold the index value during iteration.
//{
//    Console.Write(array[i] + " "); // here we should give as [] to access the value at index i of the array.
//}

// Both Hashtable and ArrayList are not good for performance as they are non-generic collections and left out but learned basic concept.
// Hashtable will have key and value pair concept. Syntax: hashtable data = new hashtable(); to add values use data.add(key,value), boolean values cannot be added.
// In Hashtable key is the important and unique so it should not be repeated. Key can be of any datatype but value can be of any datatype except boolean.
// Both are non generic collections, so boxing and unboxing will be there which will impact performance. It can store any datatype as object.
// Boxing - converting a value type into an object, Unboxing - converting an object back to a value type.
// We can store NULL values in ArrayList both Hashtable for value part but key is absolute need.

// List
//List<int> num = new List<int>(); // List syntax, List is a generic collection so we need to specify the datatype inside <> angle brackets. List - keyword, <int> - datatype, num - our own variable, new - keyword to create list box virtually, () - constructor to initialize the list.
//num.Add(15); // Adding value 15 to the list using Add() method.
//num.Add(25); // Adding value 25 to the list using Add() method.
//num.Add(50); // Adding value 50 to the list using Add() method.
//num.Add(80);
//num.Add(99);
//num.Add("karan"); // This will throw a compile-time error because we are trying to add a string to a List<int> which only accepts integers.

//foreach(var item in num) // var - keyword to let the compiler infer the datatype of item during iteration.
//{
//    Console.WriteLine(item); 
//}
//// remove value from list using value itself
//num.Remove(25); // Removing value 25 from the List using Remove() method. We should specify the value itself to be removed.
//// remove value from list using index
//num.RemoveAt(2); // Removing value at index 0 from the List using RemoveAt() method. We should specify the index to be removed.
// Console.WriteLine(string.Join(",", num)); // prints after values removed but string.Join makes num list to string.

// Dictionary - Dictionary<key datatype,value datatype> variable name = new Dictionary<key datatype, value datatype>();
//Dictionary<int, string> datas = new Dictionary<int, string>(); // Dictionary syntax, Dictionary is a generic collection so we need to specify the datatype of key and value inside <> angle brackets. Dictionary - keyword, <int, string> - datatype of key and value, datas - our own variable, new - keyword to create dictionary box virtually, () - constructor to initialize the dictionary.
//datas.Add(1, "BOOM"); // (key, value)
//datas.Add(2, "BANG"); // same key cannot be used and should be unique.
//datas.Add(3, "MAX");
////datas.Add("A1", "WIN"); // we mentioned key as int but if we put key as string it will throw error.
//datas.Add(4, "WILL");
//datas.Add(5, "KIN");
//datas.Remove(3); // here key is given to remove both key and value from dictionary.
//// datas.RemoveAt(4); // In Dictionary we cannot use RemoveAt.
//for (int i = 0; i < datas.Count; i++) // Here Count is used instead of length, only for array or index based collections length is used or else use Count.
//{
//    Console.WriteLine($"{datas.Keys.ElementAt(i)} : {datas.Values.ElementAt(i)}"); // if we just give i it will print index value of counted values inside datas(dictionary). if we give datas.Keys(multiple keys) then it will print datatype of key and value. When using with ElementAt() it will print keys only not the values.
//    // elementat() is used for getting value at particular index, datas is our variable, Values is values to get from datas dictionary using '.', same for Keys.
//}


// Stack - First IN Last OUT - Which value comes first goes out last. Value adding - push value remove - pop.
// syntax - Stack<int> variablename = new Stack<int>(); Stack - keyword to create stack <int> - datatype of stack, new - creating instance or virtual stack.
//Stack<int> st1 = new Stack<int>();
//st1.Push(10); // st1 is our stack name '.' operator Push keyword to add value 10 to st1 stack.
//st1.Push(90);
//st1.Push(80);
//st1.Push(50);
//st1.Push(40);
//Console.WriteLine(st1.Count()); // to check how many values inside stack - output: 5, not the value itself.
//Console.WriteLine(st1.Peek()); // Peek is like seeing at top output: 40, why 40 because the first value 10 is at bottom and we pushed 40 as last value so while peeking last pushed value will show.
//// Stack is like a water well.
//st1.Pop(); // this will remove top most value which is 40.
//           //for(int i = 0; i<st1.Count; i++)
//           //{
//           //    st1.Pop();
//           //}

//// OR we can use while loop too.

//while (st1.Count() > 0) {
//    Console.WriteLine(st1.Pop()); // First remove 50, then 80, then 90 at last 10 and we asked to print so it will print based on removed order.
//}


// Queue - First IN First Out - first inserted value will removed first from queue, ex: ticket counter
// Syntax - Queue<datatype of queue> variablename = new Queue<doq>();

//Queue<string> str = new Queue<string>();
//str.Enqueue("GOOGLE"); // Enqueue - keyword used to add data to queue.
//str.Enqueue("LOSPOLLOS");
//str.Enqueue("GAMBIT");
//str.Enqueue("MAPS");
//Console.WriteLine(str.Count()); // to check how many values inside str queue not the values itself.
//Console.WriteLine(str.Peek()); // show first inserted value output: GOOGLE.
//while(str.Count > 0)
//{
//    Console.WriteLine(str.Dequeue()); // This will remove first inserted element and prints elements based on removed order.
//}
//        }
//    }
//}
