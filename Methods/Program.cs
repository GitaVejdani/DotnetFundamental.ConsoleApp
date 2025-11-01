namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                Console.WriteLine("enter first number ");
                string  num1str = Console.ReadLine() ?? "";
                int num1=int.Parse(num1str);

                Console.WriteLine("enter second number ");
                string num2str = Console.ReadLine() ?? "" ;
                int num2= int.Parse(num2str);

                int result=Sum(num1, num2); 
                Console.WriteLine($"First number:{ num1}and Second number is:{num2} and result is:{ result}");
            }

            static int Sum(int num1,int num2)
            {
                int result = num1 + num2;
                return result;  
            }
        }
    }
}
