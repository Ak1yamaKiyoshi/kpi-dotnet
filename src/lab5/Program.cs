using System;

namespace MatrixTasks {
    public class MatrixOperations {
        public static void Transpose(int[][] matrix) {
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            for (int i = 0; i < rows; i++) {
                for (int j = i + 1; j < cols; j++) {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
        }

        public static void ClearNE(int[][] matrix) {
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    if (i >= j) {
                        matrix[i][j] = 0;
                    }
                }
            }
        }
    }
}

namespace MatrixInterface {
    public class MatrixUtils {
        public static void PrintMatrix(int[][] matrix) {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            for (int row = 0; row < rows; row++) {
                for (int col = 0; col < cols; col++)
                    Console.Write($"{matrix[row][col],4}");
                Console.WriteLine();
            }
        }

        public static int[][] InputMatrix(int rows, int cols) {
            int[][] matrix = new int[rows][];
            for (int i = 0; i < rows; i++) {
                matrix[i] = new int[cols];
                for (int j = 0; j < cols; j++) {
                    Console.Write($"Enter element at position [{i}][{j}]: ");
                    if (!int.TryParse(Console.ReadLine(), out matrix[i][j])) {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                        j--;
                    }
                }
            }
            return matrix;
        }
    }

    class Program {
        public static void Main(String[] args) {
            int rows = 0;

            Console.WriteLine("Input size of matrix: ");
            int.TryParse(Console.ReadLine(), out rows);
            int[][] matrix = MatrixUtils.InputMatrix(rows, rows);
            Console.WriteLine("Task: Transpose Matrix\nDescription: ");
            Console.WriteLine("> Input: ");
            MatrixUtils.PrintMatrix(matrix);
            Console.WriteLine("> Result: ");
            MatrixTasks.MatrixOperations.Transpose(matrix);
            MatrixUtils.PrintMatrix(matrix);

            Console.WriteLine("Task: ClearNE\nDescription: ");
            Console.WriteLine("> Input: ");
            MatrixUtils.PrintMatrix(matrix);
            Console.WriteLine("> Result: ");
            MatrixTasks.MatrixOperations.ClearNE(matrix);
            MatrixUtils.PrintMatrix(matrix);
        }
    }
}
