namespace Console
{
    internal static class Action
    {
        public static List<Event> Events { get; set; }

        public static DateTime SaveEvent(Event eventToBeSaved)
        {
            Events.Add(eventToBeSaved);
            return eventToBeSaved.DateAdded;
        }
    }
}
