using System;

namespace Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            BlackCoffee black = new BlackCoffee();
            Cortado corta = new Cortado();
            Latte latte = new Latte();
            
            Console.WriteLine($"The price is {black.Price()}kr and the strength is {black}.");
            Console.WriteLine($"The price is {corta.Price()}kr and the strength is {corta} with {corta.mlMilk()} ml milk.");
            Console.WriteLine($"The price is {latte.Price()}kr and the strength is {latte} with {latte.mlMilk()} ml milk.");

        }
    }
}
