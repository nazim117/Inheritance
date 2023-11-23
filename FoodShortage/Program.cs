/*
2
Peter 25 8904041303 04/04/1989
Stan 27 WildMonkeys
Peter
George
Peter
End

4
Stam 23 TheSwarm
Ton 44 7308185527 18/08/1973
George 31 Terrorists
Pen 27 881222212 22/12/1988
John
Geo rge
John
Joro
Stam
Pen
End

*/

namespace FoodShortage
{
    public class StartUp
    {
        public static void Main()
        {
            int iterations = int.Parse(Console.ReadLine());
            List<IBuyer> listOfBuyers = new List<IBuyer>();
            for (int i = 0; i < iterations; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                if (arguments.Length ==4)
                {
                    IBuyer citizen = new Citizen(arguments[0], int.Parse(arguments[1]), arguments[2], arguments[3]);
                    listOfBuyers.Add(citizen);
                }
                else
                {
                    IBuyer rebel = new Rebel(arguments[0], int.Parse(arguments[1]), arguments[2]);
                    listOfBuyers.Add(rebel);
                }
            }

            string command;
            int totalBoughtFood = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                foreach (IBuyer buyer in listOfBuyers)
                {
                    if (buyer.Name == command)
                    {
                        totalBoughtFood += buyer.BuyFood();
                    }
                }
            }
            Console.WriteLine(totalBoughtFood);
        } 
    }
}