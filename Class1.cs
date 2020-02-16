using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace libtest
{
    public class figura
    {
        public double a,b,c;
        public figura() { a = 0; b = -1; c = -1; }
        public figura(double a1) { a = a1; b = -1; c = -1; }
        public figura(double a1, double b1) { a = a1; b = b1; c = b1; }
        public figura(double a1, double b1, double c1) { a = a1; b = b1; c = c1; }

        public void area()
        {
            double s;

            if (b == -1)
            {
                s = 3.14 * a * a;
            } 
                else
            {
                double p = (a + b + c) / 2;
                s = p * (p - a) * (p - b) * (p - c);
                s = Math.Sqrt(s);

            }
            
            
            Console.WriteLine("Area = {0} ", s);
            Console.ReadLine();
        }

    }
}
