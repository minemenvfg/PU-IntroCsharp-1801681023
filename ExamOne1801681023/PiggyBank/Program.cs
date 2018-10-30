using System;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RandomNumber = new Random();
            int RealRandomNumber = RandomNumber.Next(1, 999);
             

            double sqrt = Math.Sqrt(RealRandomNumber);
            if (RealRandomNumber >=1 || RealRandomNumber <= 300)
            {
               
                sqrt = sqrt * 5.1;

                for (int i = 0; i < 31; i++)
                {
                    sqrt++;
                    Math.Round(sqrt, 4);
                        
                }
            }
            if (RealRandomNumber >= 301 || RealRandomNumber <= 600)
            {

                sqrt = sqrt * 10.098;

                for (int i = 0; i < 31; i++)
                {
                    sqrt++;
                    Math.Round(sqrt, 4);
                }
            }
            if (RealRandomNumber >= 601 || RealRandomNumber <= 999)
            {

                sqrt = sqrt * 100.00001;

                for (int i = 0; i < 31; i++)
                {
                    sqrt++;
                    Math.Round(sqrt, 4);
                }
            }
            Console.WriteLine(RealRandomNumber);
            Console.WriteLine("for one mounth you will save {0}", Math.Round(sqrt, 4));

        }
    }
}
