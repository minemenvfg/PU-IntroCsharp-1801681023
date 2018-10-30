using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            double EvenCounter = 0;
            double EvenSum = 0;
           
            while (true)
            {
                Console.WriteLine("Enter Number:");

                int EnteredNumber = int.Parse(Console.ReadLine());

                

                if(EnteredNumber == 0)
                {
                    break;
                }
                if(EnteredNumber >1 && EnteredNumber < 255)
                {
                    if (EnteredNumber % 2 == 0)
                    {
                        EvenCounter++;
                        EvenSum = EvenSum + EnteredNumber;

                    }
                }
                
            }


            if (EvenCounter == 0)
            {
                Console.WriteLine("There arent even numbers in this diapason [1,255]!!!! ");
            }
            if (EvenCounter > 0)
            {
                Console.WriteLine("Average {0}", EvenSum / EvenCounter);
            }
            Console.ReadKey(true);
        }
    }
}
