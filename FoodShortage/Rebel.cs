using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public class Rebel: IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public string Name { get; set; }
        public int Age { get; private set; }
        public string Group { get; private set; }
        public int Food { get; set; }

        public int BuyFood()
        {
            Food += 5;
            return 5;
        }
        public override string ToString()
        {
            return Food.ToString();
        }
    }
}
