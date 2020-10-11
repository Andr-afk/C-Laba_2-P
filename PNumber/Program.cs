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
            PNumber a = new PNumber("10081,34","5", "20");
            PNumber b = new PNumber("11112311,32", "5", "2");

            Console.WriteLine(a / b);
        }


        




        
    }
}
