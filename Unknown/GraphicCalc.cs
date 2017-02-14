using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unknown
{
    class GraphicCalc : Calculator
    {
        public int graphXLength;
        public int graphYHeight;
        List<char> methods = new List<char>();
        char[] methodsDelimiter = { '+', '-', '-', '*' };
        List<double> outcomes = new List<double>();
        
        public List<double> Calculation(string calc, int x)
        {
            int i = 0;
            Calculator calculator = new Calculator();
            //split the string on the methodsdelimiter
            string[] numbers = calc.Split(methodsDelimiter);
            //gets all the operators
            foreach (char method in calc)
            {
                if (method == '+')
                    methods.Add('+');
                else if (method == '-')
                    methods.Add('-');
                else if (method == '/')
                    methods.Add('/');
                else if (method == '*')
                    methods.Add('*');
            }

            foreach (string number in numbers)
            {
                if (number != "x")
                {
                    calculator.number1 = number;
                }
                else
                    calculator.number1 = x.ToString();
                if (i < numbers.GetUpperBound(0))
                {
                    if (numbers[i + 1] != "x")
                    {
                        calculator.number2 = numbers[i + 1];
                    }
                    else calculator.number2 = x.ToString();
                }

                calculator.method = methods[i];
                outcomes.Add(double.Parse(calculator.calculate()));
                i++;
            }
            return outcomes;
        }

    }
}

