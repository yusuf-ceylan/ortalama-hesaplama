using System;

namespace ortalama_hesaplama
{
    public class FibonacciCalculator
    {
        public static int Fibonacci(int n)
        {
            if (n <= 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static double CalculateFibonacciAverage(int depth)
        {
            if (depth <= 0)
                return 0;

            double sum = 0;
            for (int i = 0; i < depth; i++)
            {
                sum += Fibonacci(i);
            }

            return sum / depth;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fibonacci serisi derinliği: ");
            int depth = int.Parse(Console.ReadLine());

            double average = FibonacciCalculator.CalculateFibonacciAverage(depth);

            Console.WriteLine($"Fibonacci serisinin ilk {depth} teriminin ortalaması: {average}");
        }
    }
}
