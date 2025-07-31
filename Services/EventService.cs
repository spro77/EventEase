namespace EventEase;

using EventEase.Models;

public class EventService
{
    private List<Event> _events = new();
    private List<Registration> _registrations = new();
    private int _nextEventId = 1;
    private int _nextRegistrationId = 1;

    public EventService()
    {
        // Add sample events
        _events.Add(new Event 
        { 
            Id = _nextEventId++,
            Name = "Annual Tech Conference 2024", 
            Description = "Join industry leaders for cutting-edge tech discussions, networking, and innovation showcases.",
            Date = DateTime.Now.AddDays(30),
            Location = "San Francisco Convention Center",
            Price = 299.99m,
            MaxAttendees = 500,
            CurrentAttendees = 247,
            ImageUrl = "/images/tech-conference.jpg"
        });
        
        _events.Add(new Event 
        { 
            Id = _nextEventId++,
            Name = "Corporate Team Building Retreat", 
            Description = "Strengthen team bonds with outdoor activities, workshops, and collaborative challenges.",
            Date = DateTime.Now.AddDays(15),
            Location = "Lake Tahoe Resort",
            Price = 450.00m,
            MaxAttendees = 100,
            CurrentAttendees = 67,
            ImageUrl = "/images/team-building.jpg"
        });
        
        _events.Add(new Event 
        { 
            Id = _nextEventId++,
            Name = "Startup Networking Mixer", 
            Description = "Connect with entrepreneurs, investors, and innovators in the startup ecosystem.",
            Date = DateTime.Now.AddDays(7),
            Location = "Downtown Innovation Hub",
            Price = 25.00m,
            MaxAttendees = 200,
            CurrentAttendees = 134,
            ImageUrl = "/images/networking.jpg"
        });
    }
    
    public List<Event> GetEvents() => _events;
    
    public Event? GetEventById(int id) => _events.FirstOrDefault(e => e.Id == id);
    
    public List<Registration> GetRegistrations() => _registrations;
    
    public List<Registration> GetRegistrationsByEvent(int eventId) => 
        _registrations.Where(r => r.EventId == eventId).ToList();
    
    public bool RegisterForEvent(Registration registration)
    {
        var eventItem = GetEventById(registration.EventId);
        if (eventItem == null || eventItem.CurrentAttendees >= eventItem.MaxAttendees)
            return false;
            
        registration.Id = _nextRegistrationId++;
        registration.RegistrationDate = DateTime.Now;
        _registrations.Add(registration);
        eventItem.CurrentAttendees++;
        return true;
    }
}