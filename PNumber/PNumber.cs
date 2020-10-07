using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNumber
{
    class PNumber
    {
        string valueNumber;
        int base_value;
        int accuracy;

        public PNumber(string value, string base_value, string accuracy)
        {
            this.valueNumber = IfCorrectNumber(value);
            this.base_value = checkInputData(base_value);
            this.accuracy = checkInputData(accuracy);


            if (this.base_value > 16 || this.base_value < 2) throw new Exception("Недопустимый диаппозон основания числа");
            
        }

        public PNumber(int value, int base_value, int accuracy)
        {
            this.valueNumber = Convert.ToString(value);
            this.base_value = base_value;
            this.accuracy = accuracy;

            if (this.base_value > 16 || this.base_value < 2) throw new Exception("Недопустимый диаппозон основания числа");
        }

        protected int getValueInt
        {
            get { return Convert.ToInt32(this.valueNumber); }
            set
            {
                this.valueNumber = Convert.ToString(value);
            }
        }

        

        public string getValueString
        {
            get { return this.valueNumber; }
            set
            {
                
                this.valueNumber = value;
            }
        }

        public int getBaseValueInt
        {
            get { return this.base_value; }
            set
            {
                if (this.base_value > 16 || this.base_value < 2) throw new Exception("Недопустимый диаппозон основания числа");
                this.base_value = value;
            }
        }

        public string getBaseValueString
        {
            get { return Convert.ToString(this.base_value); }
            set
            {
                if (Convert.ToInt32(value) > 16 || Convert.ToInt32(value) < 2) throw new Exception("Недопустимый диаппозон основания числа");
                this.base_value = Convert.ToInt32(value);
            }
        }

        public int getAccuracyInt
        {
            get { return this.accuracy; }
            set
            {
                if (Convert.ToInt32(value) < 0) throw new Exception("Недопустимая точность");
                this.accuracy = Convert.ToInt32(value);
            }
        }



        public PNumber Copy()
        {
            return new PNumber(Convert.ToString(this.valueNumber), Convert.ToString(this.base_value), Convert.ToString(this.accuracy));
        }


        public static double translatorTo10(string value, int base_value, int accuracy)
        {
            int result_integer = 0;
            string[] number = value.Split(',');  

            string[] integer_number = SplitString(number[0]);
            string[] fractional_number;


            if (number.Length > 1)
            {
                fractional_number = SplitString(number[1]);
            }
            else fractional_number = null;



            void replacerCharToInt(ref string[] input)
            {
                int n;

                for (int i = 0; i < input.Length; i++)
                {

                    if (!int.TryParse(input[i], out n))
                    {
                        input[i] = input[i].ToUpper();
                        switch (input[i])
                        {
                            case "A": input[i] = "10"; break;
                            case "B": input[i] = "11"; break;
                            case "C": input[i] = "12"; break;
                            case "D": input[i] = "13"; break;
                            case "E": input[i] = "14"; break;
                            case "F": input[i] = "15"; break;
                            default: throw new Exception("Недопустимый символ");
                        }
                    }

                }

            }

            if (base_value > 10)
            {
                replacerCharToInt(ref integer_number);
                if (number.Length > 1) replacerCharToInt(ref fractional_number);

            }

            for (int i = 0; i < integer_number.Length; i++)
            {
                result_integer += Convert.ToInt32(integer_number[i]) * Convert.ToInt32(Math.Pow(base_value, integer_number.Length - i - 1));
            }

            if (fractional_number != null)
            {
                double result_fractional = 0;
                for (int i = 0; i < fractional_number.Length; i++) 
                {
                    result_fractional += Convert.ToDouble(fractional_number[i]) * Convert.ToDouble(Math.Pow(base_value, -i - 1));
                }
                return result_integer + result_fractional;
            }
            else
            {
                return result_integer;
            }
            
        }

        public static string translatorToP(double value, int base_value, int accuracy)
        {
            string result_integer = "";
            string result_fractional = "";
            string remainder;

            double integer_number = Math.Truncate(value);
            double fractional_number = value - integer_number;


            void replacerIntToChar(ref string input_numb)
            {
                switch (input_numb)
                {
                    case "10": input_numb = "A"; break;
                    case "11": input_numb = "B"; break;
                    case "12": input_numb = "C"; break;
                    case "13": input_numb = "D"; break;
                    case "14": input_numb = "E"; break;
                    case "15": input_numb = "F"; break;
                    default: break;
                }

            }
                if (base_value > 10)
                {
                    while (integer_number != 0)
                    {
                        remainder = Convert.ToString(integer_number % base_value);

                        replacerIntToChar(ref remainder);

                        result_integer = remainder + result_integer;
                        integer_number = Math.Truncate(integer_number / base_value);
                    }

                    for (int i = 0; i < accuracy; i++) 
                    {
                    string x = Convert.ToString(Math.Truncate(fractional_number * base_value));
                    fractional_number = fractional_number*base_value - Math.Truncate(fractional_number * base_value);
                    replacerIntToChar(ref x);

                    result_fractional += x;
                }
                }

                else
                {
                    while (integer_number != 0)
                    {
                        remainder = Convert.ToString(integer_number % base_value);
                        result_integer = remainder + result_integer;
                        integer_number = Math.Truncate(integer_number / base_value);
                    }

                for (int i = 0; i < accuracy; i++)
                {
                    string x = Convert.ToString(Math.Truncate(fractional_number * base_value));
                    fractional_number = fractional_number * base_value - Math.Truncate(fractional_number * base_value);
                    replacerIntToChar(ref x);

                    result_fractional += x;
                }
            }
           
            return String.Format("{0},{1}", result_integer, result_fractional);
        }

        public static string operator +(PNumber a, PNumber b)
        {
            if (a.base_value != b.base_value)
                throw new Exception("Нет возможности складывать числа с разной системой счисления");

            double data1 = translatorTo10(a.valueNumber, a.base_value, a.accuracy);
            double data2 = translatorTo10(b.valueNumber, b.base_value, a.accuracy);

            return translatorToP(data1 + data2, a.base_value, a.accuracy);
        }

        public static string operator -(PNumber a, PNumber b)
        {
            if (a.base_value != b.base_value)
                throw new Exception("Нет возможности вычитать числа с разной системой счисления");

            double data1 = translatorTo10(a.valueNumber, a.base_value, a.accuracy);
            double data2 = translatorTo10(b.valueNumber, b.base_value, b.accuracy);

            return translatorToP(data1 - data2, a.base_value, a.accuracy);
        }

        public static string operator *(PNumber a, PNumber b)
        {
            if (a.base_value != b.base_value)
                throw new Exception("Нет возможности умножать числа с разной системой счисления");

            double data1 = translatorTo10(a.valueNumber, a.base_value, a.accuracy);
            double data2 = translatorTo10(b.valueNumber, b.base_value, b.accuracy);

            return translatorToP(data1 * data2, a.base_value, a.accuracy);
        }

        public static string operator /(PNumber a, PNumber b)
        {
            if (a.base_value != b.base_value)
                throw new Exception("Нет возможности делить числа с разной системой счисления");

            double data1 = translatorTo10(a.valueNumber, a.base_value, a.accuracy);
            double data2 = translatorTo10(b.valueNumber, b.base_value, b.accuracy);

            return translatorToP(data1 / data2, a.base_value, a.accuracy);
        }

        public string Square()
        {
            double data1 = translatorTo10(this.valueNumber, this.base_value, this.accuracy);

            return translatorToP(data1 * data1, this.base_value, this.accuracy);
        }

        public PNumber ConvertPnumber()
        {
            if (this.valueNumber == "0") throw new Exception("Число не может быть нулем при обращении");

            return new PNumber(this.valueNumber = "1/" + this.valueNumber, Convert.ToString(this.base_value), Convert.ToString(this.accuracy));
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
            return string.Format("{0}({1})", this.valueNumber, this.base_value);
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
        
        private string IfCorrectNumber(string input_string)
        {
            input_string = input_string.ToUpper();

            foreach(char i in input_string)
            {
                int char_number = Convert.ToInt32(i);
                if (!((char_number >= 48 && char_number <=57) ||(char_number >= 65 && char_number <= 70)))
                {
                    throw new Exception("Недопустимый символ: " + i);
                }
            }

            return input_string;
        }
    }
}
