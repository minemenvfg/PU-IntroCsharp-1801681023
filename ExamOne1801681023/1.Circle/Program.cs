using System;

namespace _1.Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            //S=pi*r
            Random rnd = new Random();
            int r = rnd.Next(33, 187);
            int Doubler = r * r;

            double S = Math.PI * Doubler;

            Console.WriteLine("The triangle random heigh is ={0} ",r);
            Console.WriteLine("The circle area is = {0} ",S);
            
        }
    }
}
