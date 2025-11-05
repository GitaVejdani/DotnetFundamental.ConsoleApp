namespace FibonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < +10; i++)
                Console.WriteLine(Fibonacci(i) + "");
        }
            public static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
    
}
