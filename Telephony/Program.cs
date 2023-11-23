/*
0882134215 0882134333 0899213421 0558123 3333123
http://softuni.bg http://youtube.com http://www.g00gle.com
*/

namespace Telephony
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();
            Stationaryphone stationaryPhone = new Stationaryphone();

            foreach (var number in phoneNumbers)
            {
                try
                {
                    if (number.Length == 7)
                        stationaryPhone.Call(number);
                    else if (number.Length == 10)
                        smartphone.Call(number);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var website in websites)
            {
                try
                {
                    smartphone.Browse(website);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}