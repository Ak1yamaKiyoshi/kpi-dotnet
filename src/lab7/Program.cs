using System;

namespace ArrayOperations
{
    public static class ArrayUtils
    {
        public static void ArrayInput(int[] array)
        {
            Console.WriteLine("Enter the elements of the array separated by spaces:");
            string[] input = Console.ReadLine().Split(' ');
            if (input.Length != array.Length)
            {
                Console.WriteLine("Number of elements provided does not match the array size.");
                Console.WriteLine("Please provide exactly " + array.Length + " elements.");
                ArrayInput(array); 
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(input[i]);
            }
        }

        public static void ArrayPrint(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    namespace Strategies
    {
        public interface SortStrategy
        {
            void Sort(int[] array);
        }

        public class BubbleSortStrategy : SortStrategy
        {
            public void Sort(int[] array)
            {
                int temp;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
        }

        public class SelectionSortStrategy : SortStrategy
        {
            public void Sort(int[] array)
            {
                int n = array.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (array[j] < array[minIndex])
                        {
                            minIndex = j;
                        }
                    }
                    int temp = array[minIndex];
                    array[minIndex] = array[i];
                    array[i] = temp;
                }
            }
        }

        public class InsertionSortStrategy : SortStrategy
        {
            public void Sort(int[] array)
            {
                int n = array.Length;
                for (int i = 1; i < n; ++i)
                {
                    int key = array[i];
                    int j = i - 1;
                    while (j >= 0 && array[j] > key)
                    {
                        array[j + 1] = array[j];
                        j = j - 1;
                    }
                    array[j + 1] = key;
                }
            }
        }
    }
}

namespace Contextes
{
    public class SortingAlgorithm
    {
        private ArrayOperations.Strategies.SortStrategy strategy;

        public SortingAlgorithm(ArrayOperations.Strategies.SortStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Sort(int[] array)
        {
            strategy.Sort(array);
        }
    }
}

namespace ProgramInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            ArrayOperations.ArrayUtils.ArrayInput(array);
            Console.WriteLine("Original array:");
            ArrayOperations.ArrayUtils.ArrayPrint(array);

            while (true)
            {
        
                int[] copyOfArray = new int[size];
                Array.Copy(array, copyOfArray, size);
                Console.WriteLine("Original array:");
                ArrayOperations.ArrayUtils.ArrayPrint(copyOfArray);


                ArrayOperations.Strategies.SortStrategy strategy;
                Console.WriteLine("Select sorting algorithm: \n 1 - Bubble Sort \n 2 - Selection Sort \n 3 - Insertion Sort \n -1 - Exit");
                string algorithmChoice = Console.ReadLine().Trim().ToLower();

                if (algorithmChoice == "-1")
                {
                    break;
                }
                else if (algorithmChoice == "1" || algorithmChoice == "bubble sort")
                {
                    strategy = new ArrayOperations.Strategies.BubbleSortStrategy();
                }
                else if (algorithmChoice == "2" || algorithmChoice == "selection sort")
                {
                    strategy = new ArrayOperations.Strategies.SelectionSortStrategy();
                }
                else if (algorithmChoice == "3" || algorithmChoice == "insertion sort")
                {
                    strategy = new ArrayOperations.Strategies.InsertionSortStrategy();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                Contextes.SortingAlgorithm sorted = new Contextes.SortingAlgorithm(strategy);
                sorted.Sort(copyOfArray);
                Console.WriteLine("Sorted array: ");
                ArrayOperations.ArrayUtils.ArrayPrint(copyOfArray);
            }
        }
    }
}