using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unknown
{
    class Calculator
    {
        public string number1 { get; set; }
        public char method { get; set; }
        public string number2 { get; set; }
        public bool check { get; set; }
        private List<string> calculation = new List<string>();

        public void reset()
        {
            number1 = "";
            method = ' ';
            number2 = "";
            check = false;
        }


        public string calculate()
        {
            if (number1.Length >= 1 && number2.Length >= 1 && method.ToString().Length == 1)
            {
                //parse strings to ints
                double temp1 = double.Parse(number1);
                double temp2 = double.Parse(number2);
                //stars switch
                switch (method)
                {
                    case '+':
                        //show result
                        //set number 1 result
                        number1 = (temp1 + temp2).ToString();
                        cases(temp1, temp2);
                        return (temp1 + temp2).ToString();

                    case '*':
                        //show result
                        //set number 1 result
                        number1 = (temp1 * temp2).ToString();
                        this.cases(temp1, temp2);
                        return (temp1 * temp2).ToString();


                    case '-':
                        //set number 1 result
                        number1 = (temp1 - temp2).ToString();
                        this.cases(temp1, temp2);
                        return (temp1 - temp2).ToString();


                    case '/':
                        //set number 1 result
                        number1 = (temp1 / temp2).ToString();
                        this.cases(temp1, temp2);
                        return (temp1 / temp2).ToString();


                    default:
                        return "";

                }
            }
        }
        public double cases()
        {

            if (!this.number1.Contains(","))
            {

                if (this.check)
                {
                    this.number2 += ",";
                    this.textBox1.Text = this.number2;

                }
                else
                {

                    this.number1 += ",";
                    this.textBox1.Text = this.number2;
                }
            }
        }

    }
}
}
