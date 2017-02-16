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
                for (int j = 0; j < numbers.Count; j++)
                //foreach (string number in numbers)
                {
                    if (numbers[j] != "x")
                    {
                        if (y == 0)
                        {
                            calculator.number1 = numbers[0];
                            numbers.RemoveAt(0);//remove the number used
                        }
                        //else it is previous calculation outcome(done at bottom)
                        // else calculator.number1 = outcomes[y].ToString();
                    }
                    // else
                    //{//if it is x 
                    //  calculator.number1 = i.ToString();
                    //}
                    if (y < numbers.Count)
                    {//if it is the start number1 will have been the first in the list and then removed
                        //so the second number is now the first in the list
                        if (y == 0)
                        {
                            calculator.number2 = numbers[0];
                        }
                        else
                        if (numbers[1] != "x")
                        {
                            calculator.number2 = numbers[1];
                            //removes it because it was used already
                            numbers.RemoveAt(1);
                        }
                        else
                        {
                            calculator.number2 = i.ToString();
                        }

                    }
                    if (methods.Count > 1)
                    {
                        calculator.method = methods[0];
                        methods.RemoveAt(0);
                    }
                    calculator.number1 = calculator.calculate();
                    outcomes.Add(double.Parse(calculator.number1));
                    y++;
                }
                y = 0;
            }
            return outcomes;
        }

    }
}

