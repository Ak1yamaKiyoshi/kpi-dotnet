using System;

public class Tasks
{
    public static double Task1Var28(double a, double b, double c, double d)
    {
        return 2 * (Math.Log(Math.Abs(b / a)) + Math.Sqrt(Math.Sinh(c) + Math.Exp(d)));
    }

    public static double Task2Var29(double a, double b, double c, double d)
    {
        return Math.Pow((2 * Math.Cos(Math.Sqrt(a / b)) + 4 * Math.Asinh(d)), c);
    }

    public static double Task3Var30(double a, double b, double c, double d)
    {
        return (3 * a / Math.Cos(a)) + Math.Sqrt(Math.Tanh(Math.Abs(b) * c) / Math.Log(d));
    }
}

public class Program
{
    public static void Main()
    {
        double t1Result = Tasks.Task1Var28(1.478, 9.26, 0.68, 2.24);
        Console.WriteLine("Task 1  result: " + t1Result);

        double t2Result = Tasks.Task2Var29(-2.86, 1.62, 10.874, 2.91);
        Console.WriteLine("Task 2  result: " + t2Result);

        double t3Result = Tasks.Task3Var30(0.58, -0.34, 1.25, 1.89);
        Console.WriteLine("Task 3  result: " + t3Result);
    }
}
