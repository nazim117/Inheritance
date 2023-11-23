using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool isEmpty()
        {
            return this.Count == 0;
        }
        public Stack<string> AddRange() 
        {
            return this;
        }
    }
}
