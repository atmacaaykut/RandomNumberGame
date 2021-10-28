using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int cpuNumber = 0;
            int userNumber = 1;
            int counter = 0;
            while (cpuNumber != userNumber)
            {
                Console.Write("Please enter a number between 1-20: ");
                cpuNumber = r.Next(1, 21);
                userNumber = Convert.ToInt16(Console.ReadLine());
                counter++;

            }
            Console.WriteLine("You found " + counter + ". try");
           
        
        }
    }
}
