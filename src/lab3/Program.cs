

class Lab2 {
    public Lab2() {}

    public static void Main(string[] args) {  
        Console.WriteLine(Task5(4, 4));
        Console.WriteLine(Task6(4, 4));
        Console.WriteLine(Task12(4));
    }

    public static double Task5(int k, double s) {
        double sum = 0;
        for (int i = 1; i <= k; i++)
            sum += Math.Log10(Math.Sqrt(s * 1 / (i * i)));
        return sum;
    }


    public static double Task6(double t, int i) {
        if (i == 1)
            return Math.Sqrt(t);
        else if (i == 2)
            return 1 / Math.Sqrt(t);
        else {
            double result = 0;
            for (int k = 1; k <= i; k++)
                result += k * t;
            return result;
        }
    }

    public static double Task12(double epsilon) {
        double sum = 0;
        int i = 1;
        double term = 1.0 / (i * (i + 1));

        while (Math.Abs(term) >= epsilon) {
            sum += term;
            term = 1.0 / (++i * (i + 1));
        }
        return sum;
    }
    
}
