namespace TreeV3.Payloads
{
    public class LevelOne
    {
        public LevelOne(string name) { Name = name; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
