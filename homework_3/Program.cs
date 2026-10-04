using System;
using System.Text;

namespace homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("welcome stranger...");
            Console.WriteLine("enter N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // level 1 tasks
            Console.WriteLine("nums from 1-N:");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("even nums from 1-N:");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("nums from N-1:");
            for (int i = n; i >= 1; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //level 2 tasks
            int sum = 0;
            long product = 1;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
                product *= i;
            }
            Console.WriteLine($"sum: {sum} \nproduct: {product}");

            int evenSum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
            }
            Console.WriteLine($"even nums sum: {evenSum}");

            int whileSum = 0;
            while (true)
            {
                Console.Write("enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                {
                    break;
                }
                else
                {
                    whileSum += number;
                }
            }
            Console.WriteLine($"sum: {whileSum}");
            Console.WriteLine($"bye!");
        }
    }
}
