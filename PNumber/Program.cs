using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            PNumber a = new PNumber("10001","2", "3");
            PNumber b = new PNumber("1110101", "2", "2");

            Console.WriteLine(a + b);
        }


        




        
    }
}
