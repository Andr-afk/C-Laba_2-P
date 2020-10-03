using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNumber
{
    class PNumber
    {
        string value;
        int base_value;
        int accuracy;

        public PNumber(string value, string base_value, string accuracy)
        {
            this.value = value;
            this.base_value = checkInputData(base_value);
            this.accuracy = checkInputData(accuracy);


            if (this.base_value > 16 || this.base_value < 2) throw new Exception("Недопустимый диаппозон основания числа");
            //дублирование кода!!!!
        }

        public PNumber(int value, int base_value, int accuracy)
        {
            this.value = Convert.ToString(value);
            this.base_value = base_value;
            this.accuracy = accuracy;

            if (this.base_value > 16 || this.base_value < 2) throw new Exception("Недопустимый диаппозон основания числа");
        }



        public PNumber Copy()
        {
            return new PNumber(Convert.ToString(this.value), Convert.ToString(this.base_value), Convert.ToString(this.accuracy));
        }


        public static int translatorTo10(string value, int base_value)
        {
            int result = 0;
            string[] val = SplitString(value);
            int n;

            if (base_value > 10)
            {
                for(int i = 0; i < val.Length; i++)
                {

                    if (!int.TryParse(val[i], out n))
                    {
                        val[i] = val[i].ToUpper();
                        switch (val[i])
                        {
                            case "A": val[i] = "10"; break;
                            case "B": val[i] = "11"; break;
                            case "C": val[i] = "12"; break;
                            case "D": val[i] = "13"; break;
                            case "E": val[i] = "14"; break;
                            case "F": val[i] = "15"; break;
                            default: throw new Exception("Недопустимый символ");
                        }
                    }
                }
            }

            for (int i = 0; i < val.Length; i++)
            {
                result += Convert.ToInt32(val[i]) * Convert.ToInt32(Math.Pow(base_value, val.Length - i - 1));
            }
            return result;
        }

        public static string translatorToP(int value, int base_value)
        {
            string result = "";
            string remainder;

            if (base_value > 10)
            {
                while (value != 0)
                {
                    remainder = Convert.ToString(value % base_value);

                    switch (remainder)
                    {
                        case "10": remainder = "A"; break;
                        case "11": remainder = "B"; break;
                        case "12": remainder = "C"; break;
                        case "13": remainder = "D"; break;
                        case "14": remainder = "E"; break;
                        case "15": remainder = "F"; break;
                        default: break;
                    }

                    result = remainder + result;
                    value /= base_value;
                }
            }
            else
            {
                while (value != 0)
                {
                    remainder = Convert.ToString(value % base_value);
                    result = remainder + result;
                    value /= base_value;
                }
            }

            
            return result;
        }

        public static string operator +(PNumber a, PNumber b)
        {
            if (a.base_value != b.base_value)
                throw new Exception("Нет возможности складывать числа с разной системой счисления");

            int data1 = translatorTo10(a.value, a.base_value);
            int data2 = translatorTo10(b.value, b.base_value);

            return translatorToP(data1 + data2, a.base_value);
        }

        public static string operator -(PNumber a, PNumber b)
        {
            if (a.base_value != b.base_value)
                throw new Exception("Нет возможности вычитать числа с разной системой счисления");

            int data1 = translatorTo10(a.value, a.base_value);
            int data2 = translatorTo10(b.value, b.base_value);

            return translatorToP(data1 - data2, a.base_value);
        }

        public static string operator *(PNumber a, PNumber b)
        {
            if (a.base_value != b.base_value)
                throw new Exception("Нет возможности умножать числа с разной системой счисления");

            int data1 = translatorTo10(a.value, a.base_value);
            int data2 = translatorTo10(b.value, b.base_value);

            return translatorToP(data1 * data2, a.base_value);
        }

        public static string operator /(PNumber a, PNumber b)
        {
            if (a.base_value != b.base_value)
                throw new Exception("Нет возможности делить числа с разной системой счисления");

            int data1 = translatorTo10(a.value, a.base_value);
            int data2 = translatorTo10(b.value, b.base_value);

            return translatorToP(data1 / data2, a.base_value);
        }

        private static string[] SplitString(string value)
        {
            string[] result = new string[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                result[i] = Convert.ToString(value[i]);
            }

            return result;
        }


        public override string ToString()
        {
            return string.Format("{0}({1})", this.value, this.base_value);
        }

        private static int checkInputData(string input_value)
        {
            int outputValue;
            if (!int.TryParse(input_value, out outputValue))
            {
                throw new Exception("Недопустимый формат данных");
            }

            return outputValue;
        }

    }
}
