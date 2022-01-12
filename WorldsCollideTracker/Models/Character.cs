using System.Collections.Generic;

namespace WorldsCollideTracker.Models
{
    public class Character
    {
        public string Name { get; }
        public bool IsFound { get; set; }
        public List<Check> Checks { get; }

        public Character( string name, IEnumerable<Check> checks, bool isFound=false)
        {
            Name = name;
            Checks = new List<Check>(checks);
            IsFound = isFound;
        }
    }
}