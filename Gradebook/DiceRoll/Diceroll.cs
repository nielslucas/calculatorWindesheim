using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll
{
    class Diceroll
    {
        Random randomnumber = new Random();

        public string rolls(int rolls)
        {
            int face1rolls = 0;
            int face2rolls = 0;
            int face3rolls = 0;
            int face4rolls = 0;
            int face5rolls = 0;
            int face6rolls = 0;

            string outcome = "Face\tFrequency\n";

            for (int i = 0; i < rolls; i++)
            {

                switch (randomnumber.Next(1, 7))
                {
                    case 1:
                        face1rolls++;
                        break;
                    case 2:
                        face2rolls++;
                        break;
                    case 3:
                        face3rolls++;
                        break;
                    case 4:
                        face4rolls++;
                        break;
                    case 5:
                        face5rolls++;
                        break;
                    case 6:
                        face6rolls++;
                        break;
                }

            }
            outcome += String.Format("1:  \t{0}\n2:  \t{1}\n3:  \t{2}\n4:  \t{3}\n5:  \t{4}\n6:  \t{5}", face1rolls, face2rolls, face3rolls, face4rolls, face5rolls, face6rolls);
            return outcome;
        }
    }
}
