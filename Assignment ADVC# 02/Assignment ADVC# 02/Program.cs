//// 1. Employee Class and IComparable Implementation
//#region EmployeeClass
//namespace AdvancedG02S01.Generics
//{
//    internal class Employee : IComparable
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public double Salary { get; set; }

//        public Employee(int id, string name, double salary)
//        {
//            Id = id;
//            Name = name;
//            Salary = salary;
//        }

//        public override string ToString()
//        {
//            return $"{Id}::{Name}::{Salary}";
//        }

//        public int CompareTo(object? obj)
//        {
//            Employee PassedEmployee = (Employee)obj; // Explicit Casting Unsafe
//            if (this.Salary > PassedEmployee.Salary)
//                return 1;
//            else if (this.Salary < PassedEmployee.Salary)
//                return -1;
//            else return 0;
//        }
//    }
//}
//#endregion

//// 2. Reverse List Method
//#region ReverseListMethod
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void ReverseList(List<int> list)
//    {
//        int left = 0;
//        int right = list.Count - 1;

//        while (left < right)
//        {
//            int temp = list[left];
//            list[left] = list[right];
//            list[right] = temp;

//            left++;
//            right--;
//        }
//    }
//}
//#endregion

//// 3. Main Method for Reverse List Program
//#region MainMethodForReverseList
//static void Main(string[] args)
//{
//    Console.WriteLine("Enter the numbers for the list, separated by spaces:");
//    string input = Console.ReadLine();

//    List<int> numbers = new List<int>();
//    string[] parts = input.Split(' ');

//    foreach (string part in parts)
//    {
//        if (int.TryParse(part, out int number))
//        {
//            numbers.Add(number);
//        }
//        else
//        {
//            Console.WriteLine($"Invalid number skipped: {part}");
//        }
//    }

//    Console.WriteLine("Original list: " + string.Join(", ", numbers));
//    ReverseList(numbers);
//    Console.WriteLine("Reversed list: " + string.Join(", ", numbers));
//}
//#endregion

//// 4. Even Numbers Program
//#region EvenNumbersProgram
//using System;
//using System.Collections.Generic;

//class EvenNumbersProgram
//{
//    static List<int> GetEvenNumbers(List<int> numbers)
//    {
//        List<int> evenNumbers = new List<int>();

//        foreach (int number in numbers)
//        {
//            if (number % 2 == 0)  // Check if the number is even
//            {
//                evenNumbers.Add(number);
//            }
//        }

//        return evenNumbers;
//    }
//}
//#endregion

//// 5. Main Method for Even Numbers Program
//#region MainMethodForEvenNumbers
//static void Main(string[] args)
//{
//    Console.WriteLine("Enter the numbers for the list, separated by spaces:");
//    string input = Console.ReadLine();
//    List<int> numbers = new List<int>();
//    string[] parts = input.Split(' ');

//    foreach (string part in parts)
//    {
//        if (int.TryParse(part, out int number))
//        {
//            numbers.Add(number);
//        }
//        else
//        {
//            Console.WriteLine($"Invalid number skipped: {part}");
//        }
//    }

//    List<int> evenNumbers = GetEvenNumbers(numbers);
//    Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
//}
//#endregion

//// 6. FixedSizeList Class
//#region FixedSizeListClass
//using System;

//public class FixedSizeList<T>
//{
//    private T[] items;
//    private int currentSize;

//    public FixedSizeList(int capacity)
//    {
//        if (capacity <= 0)
//        {
//            throw new ArgumentException("Capacity must be greater than zero.");
//        }

//        items = new T[capacity];
//        currentSize = 0;
//    }

//    public void Add(T element)
//    {
//        if (currentSize >= items.Length)
//        {
//            throw new InvalidOperationException("The list is full. Cannot add more elements.");
//        }

//        items[currentSize] = element;
//        currentSize++;
//    }

//    public T Get(int index)
//    {
//        if (index < 0 || index >= currentSize)
//        {
//            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
//        }

//        return items[index];
//    }

//    public int Size()
//    {
//        return currentSize;
//    }

//    public int Capacity()
//    {
//        return items.Length;
//    }
//}
//#endregion

//// 7. Main Method for FixedSizeList Program
//#region MainMethodForFixedSizeList
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        try
//        {
//            Console.Write("Enter the capacity of the list: ");
//            int capacity = int.Parse(Console.ReadLine());

//            FixedSizeList<int> list = new FixedSizeList<int>(capacity);

//            Console.WriteLine($"Enter up to {capacity} elements for the list:");
//            for (int i = 0; i < capacity; i++)
//            {
//                Console.Write($"Enter element {i + 1}: ");
//                int element = int.Parse(Console.ReadLine());
//                list.Add(element);
//            }

//            Console.WriteLine("\nElements in the list:");
//            for (int i = 0; i < list.Size(); i++)
//            {
//                Console.WriteLine($"Element at index {i}: {list.Get(i)}");
//            }

//            Console.Write("Enter the index of the element you want to retrieve: ");
//            int index = int.Parse(Console.ReadLine());
//            Console.WriteLine($"Element at index {index}: {list.Get(index)}");

//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Exception: {ex.Message}");
//        }
//    }
//}
//#endregion
