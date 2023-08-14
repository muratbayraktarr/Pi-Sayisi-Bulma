using System;

namespace PiApproximation
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int totalPoints = 1000000; 
            int insideCircle = 0; 

            for (int i = 0; i < totalPoints; i++)
            {
                double x = random.NextDouble(); 
                double y = random.NextDouble();

                
                if (x * x + y * y <= 1)
                {
                    insideCircle++;
                }
            }

            double piApproximation = ((double)insideCircle / totalPoints) * 4;
            Console.WriteLine("Ödev 1");
            Console.WriteLine("Yaklaşık Pi Değeri: " + piApproximation);
            Console.ReadKey();
        }
    }
}
