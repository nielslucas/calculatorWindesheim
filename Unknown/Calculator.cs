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
        public List<string> calculation = new List<string>();
        

        public void reset()
        {
            number1 = "";
            method = ' ';
            number2 = "";
            check = false;
            Form1._Form1.update("");
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
                        //TODO:: refresh label
                        cases(temp1, temp2);
                        return (temp1 + temp2).ToString();

                    case '*':
                        //show result
                        //set number 1 result
                        number1 = (temp1 * temp2).ToString();
                        cases(temp1, temp2);
                        return (temp1 * temp2).ToString();


                    case '-':
                        //set number 1 result
                        number1 = (temp1 - temp2).ToString();
                        cases(temp1, temp2);
                        return (temp1 - temp2).ToString();


                    case '/':
                        //set number 1 result
                        number1 = (temp1 / temp2).ToString();
                        cases(temp1, temp2);
                        return (temp1 / temp2).ToString();


                    default:
                        return "";

                }

            }
            return "oops 'calculate()'";
        }

        public void komma()
        {
            if (!number1.Contains(","))
            {

                if (check)
                {
                    number2 += ",";
                    Form1._Form1.update(number2);

                }
                else
                {

                    number1 += ",";
                    Form1._Form1.update(number1);
                }
            }
        }

        public void setnumber(double number)
        {
            if (check)
            {
                number2 += number.ToString();
                Form1._Form1.update(number2);
            }
            else
            {
                number1 += number.ToString();
                Form1._Form1.update(number1);
            }
        }

        private void cases(double temp1, double temp2)
        {
            //refresh label 1
            Form1._Form1.update(number1);
            //set number 2 empty
            number2 = "";
            //add calucation to list
            calculation.Add(temp1.ToString() +" " + method + " " + temp2.ToString()+" = "+ Form1._Form1.textBox1.Text);
        }
    }
}

