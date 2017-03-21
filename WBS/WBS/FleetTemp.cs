using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBS
{
    public partial class Fleet
    {
        public List<Car> CarsFleet { get; set; }

        public Fleet(string name)
        {
            Name = name;
        }
    }
}
