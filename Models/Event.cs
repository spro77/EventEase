using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class Event
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Event name is required")]
    [StringLength(100, ErrorMessage = "Event name cannot exceed 100 characters")]
    public string Name { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Description is required")]
    [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
    public string Description { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Event date is required")]
    public DateTime Date { get; set; }
    
    [Required(ErrorMessage = "Location is required")]
    [StringLength(200, ErrorMessage = "Location cannot exceed 200 characters")]
    public string Location { get; set; } = string.Empty;
    
    [Range(0, 10000, ErrorMessage = "Price must be between $0 and $10,000")]
    public decimal Price { get; set; }
    
    [Range(1, 10000, ErrorMessage = "Maximum attendees must be between 1 and 10,000")]
    public int MaxAttendees { get; set; }
    
    [Range(0, int.MaxValue, ErrorMessage = "Current attendees cannot be negative")]
    public int CurrentAttendees { get; set; }
    
    public string ImageUrl { get; set; } = string.Empty;
}

public class Registration
{
    public int Id { get; set; }
    public int EventId { get; set; }
    
    [Required(ErrorMessage = "Full name is required")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
    public string Name { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Email address is required")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    public string Email { get; set; } = string.Empty;
    
    [Phone(ErrorMessage = "Please enter a valid phone number")]
    public string Phone { get; set; } = string.Empty;
    
    public DateTime RegistrationDate { get; set; }
}