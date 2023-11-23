/*
Peter 22 9010101122
MK-13 558833251
MK-12 33283122
End
122

Teo 31 7801211340
Peter 29 8007181534
IV-228 999999
Sam 54 3401018380
KKK-666 80808080
End
340

George 954614
Ron 124610
VI-228 999999
Mike 13 7604128614
Peter 90 5602142414
T500 131313130
End
14
*/

using BorderControl;

public class StartUp
{
    public static void Main()
    {
        string command;
        List<IBorder> border = new List<IBorder>();
        while ((command = Console.ReadLine()) != "End") 
        {
            string[] arguments = command.Split();
            if (arguments.Length == 3)
            {
                IBorder person = new Person(arguments[0], int.Parse(arguments[1]), arguments[2]);
                border.Add(person);
            }
            else
            {
                IBorder robot = new Robot(arguments[0], arguments[1]);
                border.Add(robot);
            }
        }
        string digits = Console.ReadLine();

        foreach (var item in border)
        {
            string lastDigits = item.ID.Substring(item.ID.Length - digits.Length);
            if (lastDigits == digits)
            {
                Console.WriteLine(item);
            }
        }
    }
}