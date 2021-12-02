using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianDoll
{
    public class RootRussianDoll : RussianDoll
    {
        private string Name { get; }
        private double Weight { get; }

        public RootRussianDoll(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        public override bool HasInnerDoll()
        {
            return false;
        }

        public override int NumberOfDolls()
        {
            return 1;
        }

        public override double TotalWeight()
        {
            return Weight;
        }
    }
}
