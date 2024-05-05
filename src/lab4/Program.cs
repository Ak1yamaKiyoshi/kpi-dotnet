using System;
using System.Linq;


namespace Program  {

    class Program {
        public static void Main(string[] args) {

            LabTask task;
            
            task = new Task1();
            ExecuteTask(task);
            task = new Task2();
            ExecuteTask(task);
            task = new Task3();
            ExecuteTask(task);
        }

        static void ExecuteTask(LabTask task) {

            Console.WriteLine("Input array in one line separating numbers with spaces;\n + Example 1 2 3 1 32 1\n > Input:  ");
            for (int i = 0; i < 3; i++) {
                try {
                    int[] arr = Array.ConvertAll(Console.ReadLine()!.Trim().Split(' '), int.Parse);
                    task.Main(arr);

                    break;
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
        }
    }


    class LabTask {
        public virtual void Main(int[] arr) {
            throw new NotImplementedException();
        }
    }

    class Task1:LabTask {
        public override void Main(int[] arr) {
            CalculateAndPrint(arr);
        }

        public static void CalculateAndPrint(int[] arr) {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Array cannot be null or empty.");

            int sum = 0;
            foreach (int i in arr) {
                sum += i;
            }

            Console.WriteLine("Average: " + sum / arr.Length);

            if (arr.Length >= 2) {
                int max = arr.Max();
                Console.WriteLine("Difference: " + (max - arr[1]));
            } else {
                throw new ArgumentException("Array length should be at least 2.");
            }
        }
    }

    class Task2:LabTask {
        public override void Main(int[] arr) {
            ModifyAndPrint(arr);
        }

        public static void ModifyAndPrint(int[] arr) {
            if (arr == null || arr.Length < 3)
                throw new ArgumentException("Array cannot be null.");
            int max=arr[0];
            foreach (int i in arr) {
                if (i > max)
                    max = i;
            }
            Console.WriteLine("Max: " + (max - arr[2]));
        }
    }

    class Task3:LabTask {
        public override void Main(int[] arr) {
            ModifyAndPrint(arr);
        }

        public static void ModifyAndPrint(int[] arr) {
            if (arr == null)
                throw new ArgumentException("Array cannot be null.");

            int max = arr.Max();
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] < 0) {
                    arr[i] += max;
                } else if (arr[i] == 0) {
                    arr[i] = 1;
                } else {
                    arr[i] *= 2;
                }
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
    } 
}