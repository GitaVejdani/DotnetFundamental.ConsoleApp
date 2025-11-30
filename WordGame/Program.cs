using System;
using WordGame.Word;

namespace WordGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();


            Console.WriteLine("What is your firstName?");
            person.firstName = Console.ReadLine();
            Console.WriteLine("What is your lastName?");
            person.lastName = Console.ReadLine();
            Console.WriteLine("What is your fatherName?");
            person.fatherName = Console.ReadLine();
            Console.WriteLine("What is your age?");
            person.age =int.Parse(Console.ReadLine());
        }

       
    }
}
