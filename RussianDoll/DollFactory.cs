using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianDoll
{
    public abstract class DollFactory
    {
        public static RussianDoll of(String name, double weight)
        {
            return new RootRussianDoll(name, weight);
        }

        public static RussianDoll of(String name, double weight, RussianDoll innerDoll)
        {
            if (innerDoll == null)
            {
                throw new ArgumentNullException("Inner Doll cannot be null");
            }
            return new OutterRussianDoll(name, weight, innerDoll);
        }
    }
}