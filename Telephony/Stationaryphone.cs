using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Stationaryphone : ICall
    {
        public void Call(string number)
        {
            if (IsPhoneNumberValid(number))
            {
                if (number.Length == 7)
                    Console.WriteLine($"Dialing... {number}");
            }
            else
            {
                throw new ArgumentException("Invalid number!");
            }
        }

        private bool IsPhoneNumberValid(string number)
        {
            return number.All(char.IsDigit) && number.Length == 7;
        }
    }
}
