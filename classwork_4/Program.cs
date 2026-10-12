using System;
using System.Text;

namespace classwork_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int[] scores = { 78, 92, 65, 88, 95, 71, 84 };

            Console.Write("all scores: ");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"{scores[i]} ");
            }

            Console.Write($"\nnumber of scores: {scores.Length}");

            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }

            double avg = (double)sum / scores.Length;
            Console.WriteLine($"\navg score: {avg:F2}");


            int min = scores[0];

            foreach (int score in scores)
            {
                if (score < min)
                {
                    min = score;
                }
            }

            Console.WriteLine($"min score: {min}");


            int max = scores[0];

            foreach (int score in scores)
            {
                if (score > max)
                {
                    max = score;
                }
            }

            Console.WriteLine($"max score: {max}");


            Array.Sort(scores);

            Console.WriteLine("ascending: ");

            foreach (int score in scores)
            {
                Console.Write(score + " ");
            }


            Array.Reverse(scores);

            Console.WriteLine("\ndescending: ");

            foreach (int score in scores)
            {
                Console.Write(score + " ");
            }
        }
    }
}
