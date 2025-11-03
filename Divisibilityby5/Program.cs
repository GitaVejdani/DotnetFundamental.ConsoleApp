using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Divisibilityby5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check divisibility by 5:");
            string num1str = Console.ReadLine() ?? "";
            int num1 = int.Parse(num1str);

            if (num1 %5==0)
                 Console.WriteLine("The number is divisible by 5 ");
            else 
                Console.WriteLine("The number is not divisible by 5 ");



        }
    }
}
