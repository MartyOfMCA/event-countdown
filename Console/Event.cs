namespace Console
{
    internal class Event
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Shared.Priority Priority { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateHappening { get; set; }
    }
}
