using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianDoll
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RussianDoll innerDoll1 = DollFactory.of("Diamond", 1);
            RussianDoll innerDoll2 = DollFactory.of("Diamond", 5, innerDoll1);
            RussianDoll innerDoll3 = DollFactory.of("Diamond", 2, innerDoll2);
            RussianDoll innerDoll4 = DollFactory.of("Diamond", 15, innerDoll3);
            RussianDoll outterDoll = DollFactory.of("OuterDoll", 20, innerDoll4);

            Console.WriteLine($"Number of dolls = {outterDoll.NumberOfDolls()}, expected number of dolls is : 5");
            Console.WriteLine($"Total weight of dolls = {outterDoll.TotalWeight()}, expected weight is : 43");
            Console.ReadLine();
        }
    }
}