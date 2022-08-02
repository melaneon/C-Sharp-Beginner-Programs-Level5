using System;
using System.Data;

namespace SortOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            string stringnumberA = Console.ReadLine();
            int a = Int32.Parse(stringnumberA);

            Console.WriteLine("Enter the second number");
            string stringnumberB = Console.ReadLine();
            int b = Int32.Parse(stringnumberB);

            Console.WriteLine("Enter the third number");
            string stringnumberC = Console.ReadLine();
            int c = Int32.Parse(stringnumberC);



            if (a < b)
            {
                if (a < c)
                {
                    if (b < c)
                    {
                        string numA = Convert.ToString(a);
                        string numB = Convert.ToString(b);
                        string numC = Convert.ToString(c);

                        Console.Clear();
                        Console.WriteLine(numA);
                        Console.WriteLine(numB);
                        Console.WriteLine(numC);
                    }
                    else if (b > c)
                    {
                        string numA = Convert.ToString(a);
                        string numB = Convert.ToString(b);
                        string numC = Convert.ToString(c);
                       
                        Console.Clear();
                        Console.WriteLine(numA);
                        Console.WriteLine(numC);
                        Console.WriteLine(numB);
                    }
                }
                else if (a > c)
                {
                    string numA = Convert.ToString(a);
                    string numB = Convert.ToString(b);
                    string numC = Convert.ToString(c);
                    
                    Console.Clear();
                    Console.WriteLine(numC);
                    Console.WriteLine(numA);
                    Console.WriteLine(numB);
                }
            }
            else if (a > b)
            {
                if (b < c)
                {
                    if (a < c)
                    {
                        string numA = Convert.ToString(a);
                        string numB = Convert.ToString(b);
                        string numC = Convert.ToString(c);
                        
                        Console.Clear();
                        Console.WriteLine(numB);
                        Console.WriteLine(numA);
                        Console.WriteLine(numC);
                    }
                    else if (a > c)
                    {
                        string numA = Convert.ToString(a);
                        string numB = Convert.ToString(b);
                        string numC = Convert.ToString(c);
                        
                        Console.Clear();
                        Console.WriteLine(numB);
                        Console.WriteLine(numC);
                        Console.WriteLine(numA);
                    }
                }
                else if (b > c)
                {
                    string numA = Convert.ToString(a);
                    string numB = Convert.ToString(b);
                    string numC = Convert.ToString(c);
                    
                    Console.Clear();
                    Console.WriteLine(numC);
                    Console.WriteLine(numB);
                    Console.WriteLine(numA);
                }
            }
            


        }
    }
}
