namespace BirthdayCelebrations
{
    public class Pet : IBirthdate
    {
        public Pet(string type, string name, string birthDate)
        {
            Type = type;
            Name = name;
            BirthDate = birthDate;
        }

        public string Type { get; private set; }
        public string Name { get; private set; }
        public string BirthDate { get; set; }
        public override string ToString()
        {
            return BirthDate;
        }
    }
}
