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
            Console.WriteLine(sum("101", "101", 2));
        }


        private static int translatorTo10(string value, int base_value)
        {
            int result = 0;
            int[] val = SplitInt(value);

            for(int i = 0; i < val.Length; i++)
            {
                result += val[i] * Convert.ToInt32(Math.Pow(base_value, val.Length - i - 1));
            }
            return result;
        }

        private static string translatorToP(int value, int base_value)
        {
            string result = "";

            while (value != 0)
            {
                result = (value % base_value) + result;
                value /= base_value;
            }
            return result;
        }

        private static string sum(string value1, string value2, int base_value)
        {
            int data1 = translatorTo10(value1, base_value);
            int data2 = translatorTo10(value2, base_value);

            return translatorToP(data1 + data2, base_value);
        } 

        private static string dec(string value1, string value2, int base_value)
        {
            int data1 = translatorTo10(value1, base_value);
            int data2 = translatorTo10(value2, base_value);

            return translatorToP(data1 - data2, base_value);
        }

        private static int[] SplitInt(string value)
        {
            int[] result = new int[value.Length];
            for(int i = 0; i < value.Length; i++)
            {
                result[i] = Convert.ToInt32(value[i]) - '0';
            }

            return result;
        }
        
    }
}
