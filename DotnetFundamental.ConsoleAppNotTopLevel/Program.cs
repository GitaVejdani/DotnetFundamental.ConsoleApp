namespace DotnetFundamental.ConsoleAppNotTopLevel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName = "Vejdani";
            string fatherName = "Mohammad";

            Console.WriteLine("What is your firstName?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your lastName?");
            lastName = Console.ReadLine();

            if (string.IsNullOrEmpty(firstName))
            {
                Console.WriteLine("invalid name");
            }
            if (firstName.Length < 2)
            {
                Console.WriteLine("invalid name");
            }

            Console.WriteLine("Hello, World !");
            Console.WriteLine(firstName);

            Console.WriteLine("How old are you?");
            string ageStr = Console.ReadLine();
            int age = int.Parse(ageStr);
            ageStr = age.ToString();

            short shortNumber = 5;
            int intNumber = 15;
            intNumber = shortNumber;
            shortNumber = (short)intNumber;
        }
    }
}
