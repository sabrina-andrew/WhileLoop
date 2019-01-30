using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int pickANumber = 1;
            

            while (pickANumber <= 100)
            {
                Console.WriteLine(pickANumber);
                pickANumber++;
            }
            Console.ReadKey();
        }
    }
}
