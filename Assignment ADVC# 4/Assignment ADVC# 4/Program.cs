#region Part 01:Try Every Point Covered in the Lecture.



#region Intro to Delegate & Example
////What is a Delegate?
////A Delegate is a type that holds a reference to a method. It allows methods to be called dynamically.
//class Program
//{
//    static void PrintMessage(string message)
//    {
//        Console.WriteLine(message);
//    }

//    static void Main()
//    {
//        PrintDelegate del = PrintMessage;
//        del("Hello, Delegate!");
//    }
//}

#endregion
////----------------------------------------------------

#region Delegate Example 02 [Without Generics]
//// Delegate Example 02 [Without Generics]

////Without Generics: A strongly typed delegate.

//public delegate int MathOperation(int x, int y);

//class Program
//{
//    static int Add(int x, int y) => x + y;

//    static void Main()
//    {
//        MathOperation operation = Add;
//        Console.WriteLine($"Result: {operation(5, 3)}");
//    }
//} 
#endregion


////--------------------------------------------------------------

#region Delegate Example 02 [With Generics]
////Delegate Example 02 [With Generics]

////With Generics: Using built-in Func as a delegate

//using System;

//class Program
//{
//    static int Add(int x, int y) => x + y;

//    static void Main()
//    {
//        Func<int, int, int> operation = Add;
//        Console.WriteLine($"Result: {operation(5, 3)}");
//    }
//} 
#endregion


////--------------------------------------------------------------------------------

#region Delegate Example 03 [Without Generics]
////4. Delegate Example 03 [Without Generics]

////A Delegate with multiple methods:

//public delegate void PrintDelegate(string message);

//class Program
//{
//    static void PrintUpper(string message) => Console.WriteLine(message.ToUpper());
//    static void PrintLower(string message) => Console.WriteLine(message.ToLower());

//    static void Main()
//    {
//        PrintDelegate del = PrintUpper;
//        del += PrintLower;

//        del("Hello, World!");
//    }
//} 
#endregion

////-----------------------------------------------

#region Delegate Example 03 [With Generics]
////5.Delegate Example 03 [With Generics]

////Same example as above but using built-in Action:

//using System;

//class Program
//{
//    static void PrintUpper(string message) => Console.WriteLine(message.ToUpper());
//    static void PrintLower(string message) => Console.WriteLine(message.ToLower());

//    static void Main()
//    {
//        Action<string> del = PrintUpper;
//        del += PrintLower;

//        del("Hello, World!");
//    }
//} 
#endregion


////-------------------------------------------------------------

#region Built-In Delegates [Func, Predicate, Action]
////6. Built-In Delegates [Func, Predicate, Action]

////Func: Represents a method that returns a value.

//Func<int, int, int> add = (x, y) => x + y;
//Console.WriteLine(add(3, 4));

////Action: Represents a method that doesn't return a value.

//Action<string> print = message => Console.WriteLine(message);
//print("Hello Action!");

////Predicate: Represents a method that returns bool.

//Predicate<int> isEven = number => number % 2 == 0;
//Console.WriteLine(isEven(4)); // True 
#endregion

////----------------------------------------------------------


#region Anonymous Method and Lambda Expression
///7. Anonymous Method and Lambda Expression

////Anonymous Method:

//Action<string> print = delegate (string message)
//{
//    Console.WriteLine(message);
//};
//print("Hello Anonymous Method!");

////Lambda Expression:

//Action<string> print = message => Console.WriteLine(message);
//print("Hello Lambda Expression!"); 
#endregion


////-----------------------------------------------------------

#region New Features at Delegate in C#
////8. New Features at Delegate in C#

////Example of concise delegate definition:

//Action print = () => Console.WriteLine("Hello from Delegate!");
//print(); 
#endregion

////------------------------------------------------------------

#region List Methods (That Take Functions As Parameters)
////9. List Methods (That Take Functions As Parameters)

////Examples like Where, Select:

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        var evenNumbers = numbers.Where(n => n % 2 == 0);
//        Console.WriteLine(string.Join(", ", evenNumbers));
//    }
//} 
#endregion

////----------------------------------------------------

#region Var vs Dynamic
////10. Var vs Dynamic

////Var: The type is determined at compile - time.

//var number = 5; // Inferred as int

////Dynamic: The type is determined at runtime.

//dynamic value = 5;
//value = "Hello";
//Console.WriteLine(value);

#endregion
////------------------


#endregion

//----------------------------------------------------------------------

//Part 2.1 :

#region Part 2

#region Considering the Code Below, Write Down the Body of all Listed Methods and Properties and Constructor:

using System;
using System.Net.NetworkInformation;

public class Book
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string[] Authors { get; set; }
    public DateTime PublicationDate { get; set; }
    public decimal Price { get; set; }

    // Constructor
    public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
    {
        ISBN = _ISBN;
        Title = _Title;
        Authors = _Authors;
        PublicationDate = _PublicationDate;
        Price = _Price;
    }

    // Override ToString
    public override string ToString()
    {
        string authorsList = string.Join(", ", Authors);
        return $"ISBN: {ISBN}, Title: {Title}, Authors: {authorsList}, Publication Date: {PublicationDate.ToShortDateString()}, Price: {Price:C}";
    }
}

public class BookFunctions
{
    // Method to get the title of a book
    public static string GetTitle(Book B)
    {
        return B?.Title ?? "Title not available";
    }

    // Method to get the authors of a book as a single string
    public static string GetAuthors(Book B)
    {
        return B?.Authors != null ? string.Join(", ", B.Authors) : "Authors not available";
    }

    // Method to get the price of a book formatted as currency
    public static string GetPrice(Book B)
    {
        return B != null ? B.Price.ToString("C") : "Price not available";
    }
}
#endregion


//--------------------------------
// Part 2.2 :  

#region You need to parameterize ProcessBooks function to accept BookFunctions Methods using following cases: 

// User-defined delegate
//public delegate string BookFunctionDelegate(Book book);

//public class LibraryEngine
//{
//    public static void ProcessBooks(List<Book> blist, BookFunctionDelegate fPtr)
//    {
//        foreach (Book B in blist)
//        {
//            Console.WriteLine(fPtr(B));
//        }
//    }

//    List<Book> books = new List<Book>
//    {
//        new Book("12345", "C# Programming", new[] { "Author A", "Author B" }, DateTime.Now, 29.99m),
//        new Book("67890", "Learning Java", new[] { "Author C" }, DateTime.Now.AddYears(-1), 39.99m)
//    };

//}


//// Using user-defined delegate
//LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);
//LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);
//LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);

//Using a Built-In Delegate

//public class LibraryEngine
//{
//    public static void ProcessBooks(List<Book> blist, Func<Book, string> fPtr)
//    {
//        foreach (Book B in blist)
//        {
//            Console.WriteLine(fPtr(B));
//        }
//    }
//}

//List<Book> books = new List<Book>
//{
//    new Book("12345", "C# Programming", new[] { "Author A", "Author B" }, DateTime.Now, 29.99m),
//    new Book("67890", "Learning Java", new[] { "Author C" }, DateTime.Now.AddYears(-1), 39.99m)
//};

//// Using built-in delegate
//LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);
//LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);
//LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);

#endregion


#endregion