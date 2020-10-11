using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNumber_test
{
    class Program
    {
        static void Main(string[] args)
        {
            PNumber a = new PNumber("100741,34","8", "2");
            PNumber b = new PNumber("126311,32", "8", "2");

            Console.WriteLine(a - b);
        }


        




        
    }
}
