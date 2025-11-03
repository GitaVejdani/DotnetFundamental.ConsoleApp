namespace Isprime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            string num1str = Console.ReadLine() ?? "";
            int num1 = int.Parse(num1str);
            bool IsPrime = true;
            if(num1<2)
            Console.WriteLine("The number is not prime");
            else
            {
             for (int i = 2; i < num1; i++)
                            {
                                if (num1 % i == 0)
                                {
                                    IsPrime = false;
                                    break;
                                }
                            }
                            if (IsPrime)
                                Console.WriteLine("The number is prime");
                            else Console.WriteLine("The number is not prime");

            
            }
               
           

        }
    }
}
