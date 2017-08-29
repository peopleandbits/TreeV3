namespace TreeV3.Payloads
{
    public class LevelFour
    {
        public LevelFour(string name) { Name = name; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
