namespace Console
{
    internal class Event
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public Shared.Priority Priority { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateHappening { get; set; }

        public Event(string name, string? description, Shared.Priority priority, DateTime dateHappening)
        {
            this.Name = name;
            this.Description = description;
            this.Priority = priority;
            this.DateAdded = DateTime.Now;
            this.DateHappening= dateHappening;
        }
    }
}
