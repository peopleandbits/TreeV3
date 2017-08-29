namespace TreeV3.Payloads
{
    public class LevelFive
    {
        public LevelFive(string name) { Name = name; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
