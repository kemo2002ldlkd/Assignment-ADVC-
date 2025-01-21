/* Eldemo








*/

















using System;

//namespace CombinedCode
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ExampleUsage_BubbleSort();
//            ExampleUsage_Range();
//        }

//        #region Bubble Sort Implementation
//        public static class BubbleSortHelper
//        {
//            public static void BubbleSort(int[] arr)
//            {
//                int n = arr.Length;
//                bool swapped;

//                for (int i = 0; i < n - 1; i++)
//                {
//                    swapped = false;

//                    for (int j = 0; j < n - i - 1; j++)
//                    {
//                        if (arr[j] > arr[j + 1])
//                        {
//                            int temp = arr[j];
//                            arr[j] = arr[j + 1];
//                            arr[j + 1] = temp;

//                            swapped = true;
//                        }
//                    }

//                    if (!swapped)
//                        break;
//                }
//            }
//        }

//        static void ExampleUsage_BubbleSort()
//        {
//            int[] array = { 64, 34, 25, 12, 22, 11, 90 };

//            Console.WriteLine("Unsorted array:");
//            Console.WriteLine(string.Join(", ", array));

//            BubbleSortHelper.BubbleSort(array);

//            Console.WriteLine("Sorted array:");
//            Console.WriteLine(string.Join(", ", array));
//        }
//        #endregion

//        #region Range<T> Class
//        public class Range<T> where T : IComparable<T>
//        {
//            public T Min { get; private set; }
//            public T Max { get; private set; }

//            public Range(T min, T max)
//            {
//                if (min.CompareTo(max) > 0)
//                    throw new ArgumentException("Minimum value cannot be greater than the maximum value.");

//                Min = min;
//                Max = max;
//            }

//            public bool IsInRange(T value)
//            {
//                return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
//            }

//            public double Length()
//            {
//                dynamic minValue = Min;
//                dynamic maxValue = Max;

//                return (double)(maxValue - minValue);
//            }
//        }

//        static void ExampleUsage_Range()
//        {
//            Range<int> intRange = new Range<int>(5, 15);
//            Console.WriteLine($"Is 10 in range (5-15): {intRange.IsInRange(10)}");
//            Console.WriteLine($"Is 20 in range (5-15): {intRange.IsInRange(20)}");
//            Console.WriteLine($"Length of range (5-15): {intRange.Length()}");

//            Range<double> doubleRange = new Range<double>(1.5, 3.7);
//            Console.WriteLine($"Is 2.5 in range (1.5-3.7): {doubleRange.IsInRange(2.5)}");
//            Console.WriteLine($"Length of range (1.5-3.7): {doubleRange.Length()}");

//            Range<char> charRange = new Range<char>('a', 'z');
//            Console.WriteLine($"Is 'm' in range ('a'-'z'): {charRange.IsInRange('m')}");
//            Console.WriteLine($"Is 'A' in range ('a'-'z'): {charRange.IsInRange('A')}");
//            Console.WriteLine($"Length of range ('a'-'z'): {charRange.Length()}");
//        }
//        #endregion
//    }
//}
