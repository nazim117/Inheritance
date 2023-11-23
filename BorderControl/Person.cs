using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Person : IBorder
    {
        public Person(string name, int age, string iD)
        {
            Name = name;
            Age = age;
            ID = iD;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string ID { get; set; }
        public override string ToString()
        {
            return ID;
        }
    }
}
