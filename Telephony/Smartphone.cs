using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : ICall, IBrowse
    {
        public void Call(string number)
        {
            if (IsPhoneNumberValid(number))
            {
                if (number.Length == 10)
                    Console.WriteLine($"Calling... {number}");
            }
            else
            {
                throw new ArgumentException("Invalid number!");
            }
        }

        public void Browse(string website)
        {
            if (IsWebsiteValid(website))
            {
                Console.WriteLine($"Browsing: {website}!");
            }
            else
            {
                throw new ArgumentException("Invalid URL!");
            }
        }

        private bool IsPhoneNumberValid(string number)
        {
            return number.All(char.IsDigit) && number.Length == 10;
        }

        private bool IsWebsiteValid(string website)
        {
            return !website.Any(char.IsDigit);
        }
    }
}
