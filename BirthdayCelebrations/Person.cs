namespace BirthdayCelebrations
{
    public class Person : IBorder, IBirthdate
    {
        public Person(string type, string name, int age, string iD, string birthDate)
        {
            Type = type;
            Name = name;
            Age = age;
            ID = iD;
            BirthDate = birthDate;
        }

        public string Type { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string ID { get; set; }
        public string BirthDate { get; set; }

        public override string ToString()
        {
            return BirthDate;
        }
    }
}
