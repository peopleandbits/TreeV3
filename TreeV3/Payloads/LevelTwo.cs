namespace TreeV3.Payloads
{
    public class LevelTwo
    {
        public LevelTwo(string name) { Name = name; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
