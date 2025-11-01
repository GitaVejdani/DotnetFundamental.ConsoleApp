namespace SampleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            string num1str = Console.ReadLine() ?? "";
            int numb1=int.Parse(num1str);

            Console.WriteLine("Enter second number");
            string? num2str = Console.ReadLine() ?? "";
            int numb2 = int.Parse(num2str);

            int sumResult = Sum(numb1, numb2);
            int minusResult = Minus(numb1, numb2);
            int multiplyResult = Multiply(numb1, numb2);
            double divideResult = Divide(numb1, numb2);

            Console.WriteLine($"Sum:{sumResult} ,Minus:{minusResult} ,Multiply:{multiplyResult} ,Divide:{divideResult}");

            static int Sum(int numb1, int numb2)
            {
                int sum = numb1 + numb2;
                return sum;
            }

            static int Minus(int numb1, int numb2)
            {
                int minus = numb1 - numb2;
                return minus;
            }
            static int Multiply(int numb1, int numb2)
            {
                int multiply = numb1 * numb2;
                return multiply;
            }
            static double Divide(int numb1, int numb2)
            {
                if (numb2==0)
                    {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return 0;
                }
                else {
                   double divide = numb1 / numb2;
                   return divide;
                }
               
            }
        }
    }
}
