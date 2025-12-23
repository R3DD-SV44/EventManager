namespace EventManager.Server.Models
{
    public class Event
    {
        string Name { get; set; }
        string Date { get; set; }
        string Description { get; set; }
        Scene Location { get; set; }

    }
}
