using System;

namespace employee_present_or_abscent
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            Random random = new Random();
            int value=random.Next(0, 2);

            if (value == isPresent)
            {
                Console.WriteLine("is present");
            }
            else
            {
                Console.WriteLine("is absent");
            }
        }
    }
}
