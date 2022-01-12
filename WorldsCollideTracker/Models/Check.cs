namespace WorldsCollideTracker.Models
{
    public class Check
    {
        public string Name { get; }
        public bool IsDone { get; set; }
        public bool IsAvailable { get; set; }

        public Check(string name, bool isAvailable = false, bool isDone = false)
        {
            Name = name;
            IsAvailable = isAvailable;
            IsDone = isDone;
        }
    }
}