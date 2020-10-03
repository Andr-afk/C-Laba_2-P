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
            PNumber a = new PNumber("16f","16", "0");
            PNumber b = new PNumber("67", "16", "0");

            Console.WriteLine(a - b);
        }


        




        
    }
}
