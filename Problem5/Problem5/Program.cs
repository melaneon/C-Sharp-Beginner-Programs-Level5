using System;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            float score= 90f;


            if (score >= 90f)
            {
                string gradeletter = "A";
                Console.WriteLine(gradeletter + score);
            }

            else if (score >= 80f)
            {
                string gradeletter = "B";
                Console.WriteLine(gradeletter + score);
            }
            else if (score >= 70f)
            {
                string gradeletter = "C";
                Console.WriteLine(gradeletter + score);
            }
            else if (score >= 60f)
            {
                string gradeletter = "D";
                Console.WriteLine(gradeletter + score);
            }
            else 
            {
                string gradeletter= "F";
                Console.WriteLine(gradeletter + score);
            }
            
        }
    }
}
