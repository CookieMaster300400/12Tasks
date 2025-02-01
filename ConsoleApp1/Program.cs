using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
            Task8();
            Task9();
            Task10();
            Task11();
            Task12();
        }
        public static void Task1()
        {
            Console.WriteLine("Task1\n");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine($"Hello {name}\nYou are {age} years old.");
            }
            else
            {
                Console.WriteLine($"Incorrect age");
            }
            Console.ReadLine();
        }
        public static void Task2()
        {
            Console.WriteLine("Task2\n");
            int numForT2 = 5;
            double DNumForT2 = 19.289465296143290;
            char symbForT2 = 'j';
            string strForT2 = "Hello man!";
            Console.WriteLine($"{numForT2}\n{DNumForT2}\n{symbForT2}\n{strForT2}");
            Console.ReadLine();
        }
        public static void Task3()

        {
            Console.WriteLine("Task3\n\nEnter number:");

            if (int.TryParse(Console.ReadLine(), out int numT3))
            {
                Console.WriteLine(numT3 * 2);
            }
            else
            {
                Console.WriteLine("This is not a number.");
            }
        }
        public static void Task4()
        {
            Console.WriteLine("Task4\n\nEnter number:");
            if (float.TryParse(Console.ReadLine(), out float numForT4))
            {
                if (numForT4 < 0)
                {
                    Console.WriteLine($"Number {numForT4} is negative");
                }
                else if (numForT4 == 0)
                {
                    Console.WriteLine($"Number {numForT4} = 0");
                }
                else
                {
                    Console.WriteLine($"Number {numForT4} is positive");
                }
            }
            else
            {
                Console.WriteLine("This is not a number");
            }
            Console.ReadLine();
        }
        public static void Task5()
        {
            Console.WriteLine("Task5\n\nEnter number:");
            int numForT5;
            if (int.TryParse(Console.ReadLine(), out numForT5))
            {
                switch (numForT5)
                {
                    case 1:
                        Console.WriteLine("January");
                        break;
                    case 2:
                        Console.WriteLine("February");
                        break;
                    case 3:
                        Console.WriteLine("March");
                        break;
                    case 4:
                        Console.WriteLine("April");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("June");
                        break;
                    case 7:
                        Console.WriteLine("July");
                        break;
                    case 8:
                        Console.WriteLine("August");
                        break;
                    case 9:
                        Console.WriteLine("September");
                        break;
                    case 10:
                        Console.WriteLine("October");
                        break;
                    case 11:
                        Console.WriteLine("November");
                        break;
                    case 12:
                        Console.WriteLine("December");
                        break;
                    default:
                        Console.WriteLine("you had to enter a number from 1 to 12");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введено некорректное значение");
            }
            Console.ReadLine();
        }
        public static void Task6()
        {
            Console.WriteLine("Task6\n");
            for (int i = 2; i < 101; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        public static void Task7()
        {
            Console.WriteLine("Task7\n");
            int sumForT7 = 0;
            int i = 0;
            while (i < 50)
            {
                ++i;
                sumForT7 = sumForT7 + i;
            }
                Console.WriteLine(sumForT7);
            Console.ReadLine();
        }
        public static void Task8()
        {
            Console.WriteLine("Task8\n");
            int[] arrForT8 = new int[10];
            for (int i = 0; i < arrForT8.Length; i++)
            {
                arrForT8[i] = i + 1;
                Console.WriteLine(arrForT8[i]);
            }
            Console.ReadLine();
        }
        public static void Task9()
        {
            Console.WriteLine("Task9\n");
            int randIntT9 = Random.Shared.Next(1, 101);
            Console.WriteLine(randIntT9);
            Console.ReadLine();
        }
        public static void Task10()
        {
            Console.WriteLine("Task10\n");
            int[,] arr3x3 = new int[3, 3];
            for (int i = 0; i < arr3x3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3x3.GetLength(1); j++)
                {
                    arr3x3[i, j] = Random.Shared.Next(1, 11);
                    Console.WriteLine(arr3x3[i, j]);
                }
            }
            Console.ReadLine();
        }
        public static int? Task11()
        {
            Console.WriteLine("Task11\n\nEnter the first number and then the second:");
            if (int.TryParse(Console.ReadLine(), out int fNumT11) && int.TryParse(Console.ReadLine(), out int sNumT11))
            {
                return fNumT11 + sNumT11;
            }
            else
            {
                Console.WriteLine("Incorrect number(s)");
                return null;
            }
        }
        public static void Task12()
        {
            Console.WriteLine("Task12\n");
            List<int> listT12 = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                listT12.Add(Random.Shared.Next(1, 101));
                Console.WriteLine(listT12[i]);
            }
            int sum = listT12.Sum();
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
