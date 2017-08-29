using System;

namespace TreeV3.Ids
{
    public class SpecificId : IEquatable<SpecificId>
    {
        public SpecificId(int id) { Id = id; }
        public int Id { get; set; }

        public bool Equals(SpecificId other)
        {
            return Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var result = 0;
                result = (result * 397) ^ Id;
                result += Id;
                return result;
            }
        }

        public override string ToString()
        {
            return $"{Id}";
        }
    }
}
