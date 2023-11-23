namespace BirthdayCelebrations
{
    public class Robot : IBorder
    {
        public Robot(string type, string model, string iD)
        {
            Type = type;
            Model = model;
            ID = iD;
        }

        public string Type { get; private set; }
        public string Model { get; private set; }
        public string ID { get; set; }
        public override string ToString()
        {
            return ID;
        }
    }
}
