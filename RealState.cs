using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning_Csharp
{
    public class RealState
    {
        public string Address { get; set; }
        public int Price { get; set; }
        public int SquareFoot { get; set; }
        public int CalculatePricePerSquareFoot() => Price / SquareFoot;
    }
}