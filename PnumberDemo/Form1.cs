using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PNumber_test;


namespace PnumberDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void cbActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            PNumber firstNumber = new PNumber(number1.Text, udBase_value.Value.ToString(), udAccuracy.Value.ToString());
            PNumber secondNumber = new PNumber(number2.Text, udBase_value.Value.ToString(), udAccuracy.Value.ToString());

            try
            {
                switch (cbActions.SelectedItem)
                {
                    case "+":
                        tbResultNumber.Text = (firstNumber + secondNumber).getValueString;
                        break;

                    case "-":
                        tbResultNumber.Text = (firstNumber - secondNumber).getValueString;
                        break;

                    case "*":
                        tbResultNumber.Text = (firstNumber * secondNumber).getValueString;
                        break;
                    case "/":
                        tbResultNumber.Text = (firstNumber / secondNumber).getValueString;
                        break;
                    default:
                        break;

                }
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
