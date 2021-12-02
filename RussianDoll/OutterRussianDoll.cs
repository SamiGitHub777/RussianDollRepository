using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianDoll
{
    public class OutterRussianDoll : RussianDoll
    {
        private string Name { get; }
        private double Weight { get; }
        private RussianDoll InnerDoll { get; }

        public OutterRussianDoll(string name, double weight, RussianDoll doll)
        {
            Name = name;
            Weight = weight;
            InnerDoll = doll;
        }
        public override bool HasInnerDoll()
        {
            return InnerDoll != null;
        }

        public override int NumberOfDolls()
        {
            //if (InnerDoll == null) no need for null checks as the factory method prevents null values
            return 1 + InnerDoll.NumberOfDolls();
        }

        public override double TotalWeight()
        {
            return Weight + InnerDoll.TotalWeight();
        }
    }
}
