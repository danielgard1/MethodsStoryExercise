using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whatsup Dude!");

            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();

            Console.WriteLine($"Hi {name}, what's your favorite color?");
            var favColor = Console.ReadLine();

            Console.WriteLine($"{favColor} is such a pretty color! Fun fact: mine is Teal. Do you have a favorite animal by chance?");
            var favAnimal = Console.ReadLine();

            if (favAnimal == "dog")
            {
                Console.WriteLine("Wow! I have a Husky myself.");
            }
            else
            {
                Console.WriteLine("Such a great animal!");
             }
        }

    }

}
