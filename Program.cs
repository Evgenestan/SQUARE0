using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libtest;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            figura f0 = new figura();
            figura f1 = new figura(5);
            figura f2 = new figura(4,6);
            figura f3 = new figura(4,6,6);
            f1.area();


        }
    }
}
