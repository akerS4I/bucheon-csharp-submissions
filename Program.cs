using System;
using System.Security.Cryptography;
using System.Text;

namespace akeraminai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try{
                    Console.Clear();
                    Console.WriteLine("welcome stranger...");

                    Console.Write("enter the distance: ");
                    string distanceInput = Console.ReadLine();
                    Console.Write("enter the price: ");
                    string priceInput = Console.ReadLine();

                    if (!double.TryParse(distanceInput, out double distance))
                    {
                        Console.WriteLine("Error!");
                        Console.ReadKey();
                        return;
                    }

                    if (!double.TryParse(priceInput, out double price))
                    {
                        Console.WriteLine("Error!");
                        Console.ReadKey();
                        return;
                    }

                    if (number > secNumber)
                    {
                        Console.WriteLine($"{number} is bigger");
                    }
                    else if (number < secNumber)
                    {
                        Console.WriteLine($"{secNumber} is bigger");
                    }
                    else
                    {
                        Console.WriteLine("they're equal");
                    }

                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("\nR.I.P. an error occured. press 'enter' to restart...");
                    Console.ReadLine();
                }
            }
        }
    }
}