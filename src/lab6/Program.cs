using System;

namespace ArrayOperations {
class ArrayUtils {
    public static void ArrayInput(int[] array) {
        Console.WriteLine("Enter the elements of the array separated by spaces:");
        string[] input = Console.ReadLine().Split(' ');
        if (input.Length != array.Length) {
            Console.WriteLine("Number of elements provided does not match the array size.");
            Console.WriteLine("Please provide exactly " + array.Length + " elements.");
            ArrayInput(array); // Re-prompt for input
            return;
        }
        for (int i = 0; i < array.Length; i++) {
            array[i] = Convert.ToInt32(input[i]);
        }
    }

    public static void ArrayPrint(int[] array) {
        foreach (var item in array) {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

    class Sort {
        public static void BubbleSort(int[] array) {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++) {
                for (int j = 0; j < n - i - 1; j++) {
                    if (array[j] > array[j + 1]) {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static void SelectionSort(int[] array) {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++) {
                int minIndex = i;
                for (int j = i + 1; j < n; j++) {
                    if (array[j] < array[minIndex]) {
                        minIndex = j;
                    }
                }
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }
}

namespace ProgramInterface {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];

            ArrayOperations.ArrayUtils.ArrayInput(array);

            Console.WriteLine("Original array:");
            ArrayOperations.ArrayUtils.ArrayPrint(array);

            int[] bubbleSortedArray = new int[size];
            Array.Copy(array, bubbleSortedArray, size);
            ArrayOperations.Sort.BubbleSort(bubbleSortedArray);

            Console.WriteLine("Array after Bubble Sort:");
            ArrayOperations.ArrayUtils.ArrayPrint(bubbleSortedArray);

            int[] selectionSortedArray = new int[size];
            Array.Copy(array, selectionSortedArray, size);
            ArrayOperations.Sort.SelectionSort(selectionSortedArray);

            Console.WriteLine("Array after Selection Sort:");
            ArrayOperations.ArrayUtils.ArrayPrint(selectionSortedArray);
        }
    }
}
