using System.Collections.Concurrent;
using System.ComponentModel.Design;

namespace Console_Blank_6
{
    internal class Program
    {

        static void Question1()
        {
            int number;
            Console.Write("enter an integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter another integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                number = num1 / num2;
            }
            else
            {
                number = num2 / num1;
            }
            int count = 0;
            while (count != number)
            {
                count++;
                if (count % 10 == 0)
                {
                    Console.Write("X");
                }
                else if (count % 5 == 0)
                {
                    Console.Write("V");
                }
                else
                {
                    Console.Write("/");
                }
            }
        }

        static void Question2()
        {
            Console.WriteLine("enter and integer greater than 1: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int x = 2;
            int count = 0;
            while (number > 1)
            {
                bool multi = false;
                while(number % x == 0)
                {
                    if (!multi)
                    {
                        Console.WriteLine(x);
                    }
                    count++;
                    multi = true;
                    number = number / x;

                }
                x++;
            }
            Console.WriteLine(count);
        }

        static void Question3()
        {
            Console.WriteLine("enter an integer greater than 1: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int product = 1;
            int factor = 0;
            while (product < x)
            {
                factor++;
                product = product * factor;
            }
            if (product == x)
            {
                product = 1;
                for (int n = 1; n <= factor; n++)
                {
                    product = product * n;
                    Console.WriteLine(n);
                }
            }
            else
            {                
                Console.WriteLine("No results");
            }
        }

        static void Question4()
        {
            Console.Write("Enter integer (0-99): ");
            int value = int.Parse(Console.ReadLine());

            Console.Write("Calculate additive or multiplicative persistence (a/m)? ");
            char operation = Console.ReadLine()[0];

            int count = 0;
            while (value > 9)
            {
                if (operation == 'a')
                {
                    value = (value / 10) + (value % 10);
                }
                else if (operation == 'm')
                {
                    value = (value / 10) * (value % 10);
                }
                count++;
            }

            Console.WriteLine("The persistence is: " + count);

        }

        
        static void Main(string[] args)
        {
            //Question1();
            //Question2();
            //Question3();
            //Question4();
        }
    }
}