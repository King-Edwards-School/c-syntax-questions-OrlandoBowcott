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
            Console.WriteLine("")
        }

        static void Main(string[] args)
        {
            //Question1();
            //Question2();
            Question3();
        }
    }
}