using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //part 1

            void GuessingGame()
            {
                Random random = new Random();
                int randomNumber = random.Next(50, 75);

                int guess;

                bool guessed = false;
                int counter = 1;

                while (!guessed)
                {
                    Console.WriteLine("Enter a guess! ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess != randomNumber)
                    {
                        counter++;

                        if (guess > randomNumber)
                        {
                            Console.WriteLine("Try a lower number.");
                        }
                        if (guess < randomNumber)
                        {
                            Console.WriteLine("Try a higher number.");
                        }
                    }
                    else
                    {
                        if (guess == randomNumber)
                        {
                            Console.WriteLine("Congratulations!");
                        }
                        guessed = true;
                    }


                }
                int points;
                if (counter == 1)
                {
                    points = 10;
                }
                else if (counter == 2)
                {
                    points = 7;
                }
                else if (counter == 3)
                {
                    points = 5;
                }
                else
                {
                    points = 0;
                }

                Console.WriteLine($"Number of attempts: {counter}\nPoints" +
                    $" earned {points}");
                Console.WriteLine($"*************************\n");
            }
            


            

            //part 2
            void StudentNames()
            {
                String[] names = new String[] { "Ahmad", "Sara", "Omar", "Lina", "Yazan" };
                for (int j = 0; j < names.Length; j++)
                {
                    Console.WriteLine($"{names[j]}\n");
                }
                Console.WriteLine($"*************************\n");
            }
            

            


            //part 3
            void StudentMarks()
            {
                int[] Marks = new int[] { 85, 92, 68, 75, 90 };
                foreach (int mark in Marks)
                {
                    Console.WriteLine(mark);
                }
                Console.WriteLine($"*************************\n");
            }
            

            


            //part 4
            void SearchName()
            {
                Console.WriteLine("Search for a student name: ");
                String name = Console.ReadLine();

                String[] names = new String[] { "Ahmad", "Sara", "Omar", "Lina", "Yazan" };

                int i = 0;

                while (i < names.Length)
                {
                    if (names[i].ToLower() == name.ToLower())
                    {
                        Console.WriteLine("Student Found!");
                        break;
                    }
                    else if (i == names.Length - 1)
                    {
                        Console.WriteLine("Student not found");
                    }

                    i++;
                }
                Console.WriteLine($"*************************\n");
            }


            

            //part 5
            void Grade()
            {
                Console.WriteLine("Enter a grade ");
                int grade = Convert.ToInt32(Console.ReadLine());

                if (grade >= 90 && grade <= 100)
                {
                    Console.WriteLine("Excellent");
                }
                else if (grade >= 80 && grade <= 89)
                {
                    Console.WriteLine("Very Good");
                }
                else if (grade >= 79 && grade <= 70)
                {
                    Console.WriteLine("Good");
                }
                else if (grade >= 69 && grade <= 60)
                {
                    Console.WriteLine("Pass");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
                Console.WriteLine($"*************************\n");
            }


            String[] menu = new string[] {"1. Display Students",
                        "2. Search for Student",
                         "3.Check Student Result","4.Exit"};
            int choice;

            do
            {
                Console.WriteLine("===== School System =====");
                foreach (string menuitem in menu)
                {
                    Console.WriteLine(menuitem);
                }
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        StudentNames();
                        break;

                    case 2:
                        SearchName();
                        break;

                    case 3:
                        Grade();
                        break;

                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            } while (choice != 4);
        }
    }
}
