using System;

namespace FinalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //writing the variables 
            double a = 1.234;
            double b = 0.756;
            double c = 2.23;
            double d = -1.653;

            //added a b c d 
            // for sin a = x
            // for square root of c  = f
            // for b x f = g
            // *** bxf should be absolute ***
            // 2.x + cos g = h
            // then h to the power of d  = y

            int x = math.sin(a);
            int f = math.sqrt(c);
            int g = Abs(b * f);
            int h = 2 * x + math.cos(g);
            int y = pow(h, d);


            System.Console.WriteLine("equals = " + y);

        }
    }
}
