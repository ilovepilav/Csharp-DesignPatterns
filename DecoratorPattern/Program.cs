using DecoratorPattern.Abstraction;
using DecoratorPattern.BaseCoffees;
using DecoratorPattern.Extras;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Espresso espressoCoffee = new Espresso();

            AddOn caramelEspresso = new Caramel(espressoCoffee);

            AddOn chocolateEspresso = new Chocolate(espressoCoffee);

            AddOn chocoCaramelEspresso = new Chocolate(caramelEspresso);

            Console.WriteLine($"Espresso price is {espressoCoffee.Cost()}");
            Console.WriteLine($"Caramel Espresso price is {caramelEspresso.Cost()}");
            Console.WriteLine($"Chocolate Espresso price is {chocolateEspresso.Cost()}");
            Console.WriteLine($"Chocolate Caramel Espresso price is {chocoCaramelEspresso.Cost()}");

            Console.Read();
        }
    }
}
