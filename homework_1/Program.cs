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
                    Console.WriteLine("welcome to taxi cost calculator stranger...");

                    double distance = ReadDouble("enter the distance in km: ");
                    double startPrice = ReadDouble("enter the starting price ($): ");
                    double perKmPrice = ReadDouble("enter the price per km ($): ");

                    double price = startPrice + distance * perKmPrice;
                    Console.WriteLine($"your taxi ride costs: {price:F2}$");

                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("\nR.I.P. an error occured. press 'enter' to restart...");
                    Console.ReadLine();
                }
            }
        }
        static double ReadDouble(string message)
        {
            while (true)
            {
                Console.Write(message);

                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                }

                Console.WriteLine("invalid number input. try again.");
            }
        }
    }
}