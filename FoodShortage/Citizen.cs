namespace FoodShortage
{
    public class Citizen : IBuyer
    {
        public Citizen(string name, int age, string iD, string birthDate)
        {
            Name = name;
            Age = age;
            ID = iD;
            BirthDate = birthDate;
        }

        public string Name { get; set; }
        public int Age { get; private set; }
        public string ID { get; private set; }
        public string BirthDate { get; private set; }
        public int Food { get; set; }

        public int BuyFood()
        {
            Food += 10;
            return 10;
        }

        public override string ToString()
        {
            return Food.ToString();
        }
    }
}
