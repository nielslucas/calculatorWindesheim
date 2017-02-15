using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unknown
{
    class GraphicCalc : Calculator
    {
        public int graphXLength = 0;
        public int graphYHeight = 0;
        List<char> methods = new List<char>();
        char[] methodsDelimiter = { '+', '-', '-', '*' };
        List<double> outcomes = new List<double>();

        public List<double> Calculation(string calc)
        {
            int y = 0;
            Calculator calculator = new Calculator();
            //split the string on the methodsdelimiter
           
            //gets all the operators in the calculation
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
            //for every x calculate y
            for (int i = 0; i < graphXLength; i++)
            {
                List<string> numbers = calc.Split(methodsDelimiter).ToList();
                foreach (string number in numbers)
                {
                    if (number != "x")
                    {
                        calculator.number1 = number;
                    }
                    else
                    {
                        calculator.number1 = i.ToString();
                    }
                    if (y < numbers.Count)
                    {
                        if (numbers[y + 1] != "x")
                        {
                            calculator.number2 = numbers[y + 1];
                        }
                        else
                        {
                            calculator.number2 = i.ToString();
                        }
                        //removes it because it was used already
                        numbers.RemoveAt(y);
                    }

                    calculator.method = methods[y];
                    outcomes.Add(double.Parse(calculator.calculate()));
                    y++;
                }
                y = 0;
            }
            return outcomes;
        }

    }
}

