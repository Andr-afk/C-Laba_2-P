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
            PNumber a = new PNumber("10001,34","2", "3");
            PNumber b = new PNumber("11101001,32", "2", "2");

            Console.WriteLine(a + b);
        }


        




        
    }
}
