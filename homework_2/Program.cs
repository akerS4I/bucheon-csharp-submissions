using System;
using System.Net;
using System.Runtime.Remoting.Messaging;
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
                try
                {
                    Console.Clear();
                    Console.WriteLine("welcome to job application stranger...");

                    int score = 0;
                    string name = ReadString("enter your name: ");
                    int age = ReadInt("enter your age: ");
                    if (age < 18 || age > 65)
                    {
                        Console.WriteLine("your age is invalid! press 'enter' to restart...");
                        Console.ReadLine();
                        continue;
                    }
                    else if (age <= 25)
                    {
                        score += 1;
                    }
                    else if (age <= 40)
                    {
                        score += 2;
                    }
                    else
                    {
                        score += 1;
                    }
                        string citizenship = ReadString("what is your country of citizenship?: ");
                    if (citizenship != "Uzbekistan")
                    {
                        Console.WriteLine("your citizenship is invalid! press 'enter' to restart...");
                        Console.ReadLine();
                        continue;
                    } else
                    {
                        Console.WriteLine("your citizenship in confirmed");
                    }

                    int exp = ReadInt("how many years of experience do u have?: ");
                    // level checker
                    string level;
                    if (exp >= 0)
                    {
                        if (exp <= 2)
                        {
                            level = "junior";
                            score += 1;
                        } 
                        else if(exp <= 5)
                        {
                            level = "middle";
                            score += 2;
                        }
                        else
                        {
                            level = "senior";
                            score += 3;
                        }
                    }
                    else
                    {
                        Console.WriteLine("your experience is invalid! press 'enter' to restart...");
                        Console.ReadLine();
                        continue;
                    }

                    string education = ReadString("what education do you have? (higher, secondary, none): ");
                    switch (education)
                    {
                        case "higher":
                            score += 2;
                            break;
                        case "secondary":
                            score += 1;
                            break;
                        case "none":
                            Console.WriteLine("denied! no education. press 'enter' to restart...");
                            Console.ReadLine();
                            continue;
                        default:
                            Console.WriteLine("invalid education. press 'enter' to restart...");
                            Console.ReadLine();
                            continue;
                    }

                    int languages = ReadInt("how many languages do u know?: ");
                    string languageLevel;
                    if (languages >= 0)
                    {
                        if (languages == 1)
                        {
                            languageLevel = "base";
                            score += 1;
                        }
                        else if (languages <= 3)
                        {
                            languageLevel = "intermediate";
                            score += 2;
                        }
                        else
                        {
                            languageLevel = "advanced";
                            score += 3;
                        }
                    }
                    else
                    {
                        Console.WriteLine("your languages value is invalid! press 'enter' to restart...");
                        Console.ReadLine();
                        continue;
                    }
                    Console.WriteLine($"your language level is {languageLevel}");

                    string recommendations = ReadString("do u have recommendation letters? (y, n): ");
                    if (recommendations == "y")
                    {
                        score += 2;
                    }
                    else if (recommendations != "n")
                    {
                        Console.WriteLine("invalid recommendations. press 'enter' to restart...");
                        Console.ReadLine();
                        continue;
                    }

                    int exam = ReadInt("what score did u get on the exam?: ");
                    string examResult;
                    if (exam >= 0 && exam <= 100)
                    {
                        if (exam >= 91)
                        {
                            examResult = "A";
                            score += 3;
                        }
                        else if (exam >= 71)
                        {
                            examResult = "B";
                            score += 2;
                        }
                        else if (exam >= 50)
                        {
                            examResult = "C";
                            score += 1;
                        }
                        else
                        {
                            Console.WriteLine("you failed the exam! press 'enter' to restart...");
                            Console.ReadLine();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("your exam score is invalid! press 'enter' to restart...");
                        Console.ReadLine();
                        continue;
                    }
                    Console.WriteLine($"your exam score is {examResult}");

                    string decision;
                    if (score >= 11)
                    {
                        decision = "you are accepted";
                    } else if (score >= 8)
                    {
                        decision = "you are accepted for a trial";
                    }
                    else
                    {
                        decision = "you are denied. sorry...";
                    }

                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("           CANDIDATE SUMMARY");
                    Console.WriteLine("----------------------------------------");

                    Console.WriteLine($"{"name",-20}{name,20}");
                    Console.WriteLine($"{"age",-20}{age,20}");
                    Console.WriteLine($"{"citizenship",-20}{citizenship,20}");
                    Console.WriteLine($"{"experience",-20}{exp + " years",20}");
                    Console.WriteLine($"{"level",-20}{level,20}");
                    Console.WriteLine($"{"education",-20}{education,20}");
                    Console.WriteLine($"{"languages",-20}{languages,20}");
                    Console.WriteLine($"{"language level",-20}{languageLevel,20}");
                    Console.WriteLine($"{"recommendations",-20}{recommendations,20}");
                    Console.WriteLine($"{"exam result",-20}{examResult + " (" + exam + ")",20}");
                    Console.WriteLine($"{"total score",-20}{score,20}");
                    Console.WriteLine($"{"decision",-20}{decision,20}");

                    Console.WriteLine("-----------------------------------------");


                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("\nR.I.P. an error occured. press 'enter' to restart...");
                    Console.ReadLine();
                }
            }
        }
        static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    return value;
                }

                Console.WriteLine("invalid number input. try again.");
            }
        }
        static string ReadString(string message)
        {
            while (true)
            {
                Console.Write(message);

                string value = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(value))
                {
                    return value;
                }

                Console.WriteLine("invalid text input. try again.");
            }
        }
    }
}