using System;

namespace ZompareNumbers
{
    class Program
    {
        static void Main()

        {
            //Easier way:
            int a, b, c;

            //Console.WriteLine("Enter the first number");
            //a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the second number");
            //b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the third number");
            //c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the first number");
            string stringnumberA = Console.ReadLine();
            int.TryParse(stringnumberA, out a);

            Console.WriteLine("Enter the second number");
            string stringnumberB = Console.ReadLine();
            int.TryParse(stringnumberB, out b);

            Console.WriteLine("Enter the third number");
            string stringnumberC = Console.ReadLine();
            int.TryParse(stringnumberC, out c);

            CompareValues(a, b, c);



        }
        static void CompareValues(int a, int b, int c)        // To be honest, I can't figure out how to add extra method here, 
        {
            if (a == b && a == c)
            {
                Console.WriteLine("all the  same");
            }
            else if (a == b || b == c || c == a)
            {
                Console.WriteLine("two numbers match");
            }
            else if (a != b || b != c || c != a)
            {
                Console.WriteLine("all different");
            }
        }
    }
}
    

