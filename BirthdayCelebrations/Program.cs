/*
Citizen Peter 22 9010101122 10/10/1990
Pet Sharo 13/11/2005
Robot MK-13 558833251
End
1990

Citizen Stam 16 0041018380 01/01/2000
Robot MK-10 12345678
Robot PP-09 00000001
Pet Topcho 24/12/2000
Pet Rex 12/06/2002
End
2000

Robot VV-XYZ 11213141
Citizen Corso 35 7903210713 21/03/1979
Citizen Kane 40 7409073566 07/09/1974
End
1975

*/

using BirthdayCelebrations;

public class StartUp
{
    public static void Main()
    {
        string command;
        List<IBirthdate> birthDays = new List<IBirthdate>();
        while ((command = Console.ReadLine()) != "End")
        {
            string[] arguments = command.Split();
            if (arguments[0] == "Citizen")
            {
                IBirthdate person = new Person(arguments[0], arguments[1], int.Parse(arguments[2]), arguments[3], arguments[4]);
                birthDays.Add(person);
            }
            else if (arguments[0] == "Robot")
            {
                IBorder robot = new Robot(arguments[0], arguments[1], arguments[2]);
            }
            else
            {
                IBirthdate pet = new Pet(arguments[0], arguments[1], arguments[2]);
                birthDays.Add(pet);
            }
        }
        string year = Console.ReadLine();

        foreach (var item in birthDays)
        {
            string lastDigits = item.BirthDate.Substring(item.BirthDate.Length - year.Length);
            if (lastDigits == year)
            {
                Console.WriteLine(item);
            }
        }
    }
}