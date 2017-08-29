namespace TreeV3.Payloads
{
    public class LevelThree
    {
        public LevelThree(string name) { Name = name; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
