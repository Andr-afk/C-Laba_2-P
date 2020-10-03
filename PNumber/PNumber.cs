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
