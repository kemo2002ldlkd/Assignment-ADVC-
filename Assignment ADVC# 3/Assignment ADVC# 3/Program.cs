/*
 Part 01
Implement The Session  And Try Run All Examples :
 public static T Swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;

            return temp;
        }
        #endregion

        #region Search Array
        public static int SearchArray(T[] arr, T Value)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (Value.Equals(arr[i]))
                        return i;
                }
            }
            return -1;
        }
        #endregion

        #region BubbleSort
        public static void BubbleSort(T[] arr)
        {
            if(arr is not null)
            {
                for(int i = 0;i < arr.Length;i++)//2
                {
                    for(int j=0;j<arr.Length -i -1;j++)//0 Length = 6 -3 =3
                    {
                        if (arr[j].CompareTo(arr[j+1])==1)
                            Swap(ref arr[j],ref arr[j+1]);
                    }
                }
            }
        }

        #endregion



  internal class Employee:IComparable
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id,string name,double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Id}::{Name}::{Salary}";
        }

        //public static bool operator ==(Employee left, Employee right)
        //{
        //    return left.Equals(right);
        //}
        //public static bool operator !=(Employee left, Employee right)
        //{
        //    return !left.Equals(right) ;
        //}

        public override bool Equals(object? obj)
        {
            Employee PassedEmployee = (Employee)obj;
            return (this.Id == PassedEmployee.Id) && (this.Name == PassedEmployee.Name) && (this.Salary == PassedEmployee.Salary);
        }

        public int CompareTo(object? obj)
        {
            Employee PassedEmployee = (Employee)obj;//Explicit Casting Unsafe
            if (this.Salary > PassedEmployee.Salary)
                return 1;
            else if (this.Salary < PassedEmployee.Salary)
                return -1;
            else return 0;
        }

        
    }
}




 */

//------------------------------------------------------------------------------//



/*
 Write a Report about all Collections Given in the Session :
# Report on Collections in C#

## Introduction
In software development, collections are essential for storing and managing groups of related objects. C# provides several types of collections, each designed to suit specific use cases. This report examines the structure, time complexity, and business cases for different types of collections with implemented examples.

---

## 1. **List<T>**

### Structure
- A **List<T>** is a dynamic array.
- It provides indexed access to elements.
- Resizes dynamically as elements are added or removed.

### Time Complexity
- **Access (by index):** O(1)
- **Insert/Remove (at end):** O(1) (amortized for insert)
- **Insert/Remove (at specific position):** O(n)
- **Search (Contains):** O(n)

### Business Case
- Suitable for scenarios requiring frequent access by index.
- Example: Storing a list of user IDs for a web application.

### Implementation
```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30 };
        numbers.Add(40);
        numbers.Remove(20);
        
        Console.WriteLine("List elements:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
```

---

## 2. **LinkedList<T>**

### Structure
- A **LinkedList<T>** is a doubly linked list.
- Each node contains a value and references to the previous and next nodes.

### Time Complexity
- **Access (by index):** O(n)
- **Insert/Remove (at start or end):** O(1)
- **Insert/Remove (at middle):** O(1) if you have the node reference; otherwise, O(n)

### Business Case
- Suitable for scenarios requiring frequent insertions and deletions at both ends.
- Example: Implementing undo functionality in a text editor.

### Implementation
```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<string> tasks = new LinkedList<string>();
        tasks.AddLast("Task 1");
        tasks.AddLast("Task 2");
        tasks.AddFirst("Task 0");

        Console.WriteLine("Tasks:");
        foreach (string task in tasks)
        {
            Console.WriteLine(task);
        }
    }
}
```

---

## 3. **Dictionary<TKey, TValue>**

### Structure
- A **Dictionary<TKey, TValue>** is a collection of key-value pairs.
- It uses a hash table for efficient lookup.

### Time Complexity
- **Access (by key):** O(1) on average, O(n) in worst case
- **Insert/Remove:** O(1) on average, O(n) in worst case

### Business Case
- Suitable for scenarios requiring fast lookups by key.
- Example: Storing user profiles by unique user ID.

### Implementation
```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> userProfiles = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
        };

        Console.WriteLine("User profiles:");
        foreach (var profile in userProfiles)
        {
            Console.WriteLine($"ID: {profile.Key}, Name: {profile.Value}");
        }
    }
}
```

---

## 4. **Queue<T>**

### Structure
- A **Queue<T>** is a FIFO (First-In, First-Out) collection.
- Elements are added at the rear and removed from the front.

### Time Complexity
- **Enqueue (Add):** O(1)
- **Dequeue (Remove):** O(1)
- **Peek:** O(1)

### Business Case
- Suitable for scenarios requiring sequential processing.
- Example: Task scheduling in an operating system.

### Implementation
```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Task 1");
        queue.Enqueue("Task 2");

        Console.WriteLine("Processing tasks:");
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}
```

---

## 5. **Stack<T>**

### Structure
- A **Stack<T>** is a LIFO (Last-In, First-Out) collection.
- Elements are added and removed from the top.

### Time Complexity
- **Push (Add):** O(1)
- **Pop (Remove):** O(1)
- **Peek:** O(1)

### Business Case
- Suitable for scenarios requiring reverse-order processing.
- Example: Expression evaluation in a calculator.

### Implementation
```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);

        Console.WriteLine("Stack elements:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
    }
}
```

---

## Comparison Summary
| Collection         | Structure                | Time Complexity        | Business Case                           |
|--------------------|--------------------------|------------------------|-----------------------------------------|
| **List<T>**        | Dynamic Array            | Access: O(1), Insert: O(n) | Frequent index-based access             |
| **LinkedList<T>**  | Doubly Linked List       | Access: O(n), Insert: O(1) | Frequent insertions/deletions           |
| **Dictionary<TKey, TValue>** | Hash Table           | Access: O(1)*, Insert: O(1)* | Fast key-based lookups                  |
| **Queue<T>**       | FIFO Queue               | Enqueue/Dequeue: O(1)   | Sequential processing                   |
| **Stack<T>**       | LIFO Stack               | Push/Pop: O(1)          | Reverse-order processing                |

*Worst-case complexity can degrade to O(n) for hash table-based collections if hash collisions occur.

---


 */
