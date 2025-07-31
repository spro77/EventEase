namespace EventEase.Services;

using EventEase.Models;

public class SessionService
{
    private string? _currentUserEmail;
    private List<Registration> _userRegistrations = new();
    private DateTime? _sessionStart;

    public event Action? OnSessionChanged;

    public bool IsLoggedIn => !string.IsNullOrEmpty(_currentUserEmail);
    public string? CurrentUserEmail => _currentUserEmail;
    public DateTime? SessionStart => _sessionStart;
    public TimeSpan SessionDuration => _sessionStart.HasValue ? DateTime.Now - _sessionStart.Value : TimeSpan.Zero;

    public void StartSession(string userEmail)
    {
        _currentUserEmail = userEmail;
        _sessionStart = DateTime.Now;
        OnSessionChanged?.Invoke();
    }

    public void EndSession()
    {
        _currentUserEmail = null;
        _sessionStart = null;
        _userRegistrations.Clear();
        OnSessionChanged?.Invoke();
    }

    public void AddUserRegistration(Registration registration)
    {
        if (!_userRegistrations.Any(r => r.EventId == registration.EventId))
        {
            _userRegistrations.Add(registration);
        }
    }

    public List<Registration> GetUserRegistrations() => _userRegistrations.ToList();

    public bool IsRegisteredForEvent(int eventId)
    {
        return _userRegistrations.Any(r => r.EventId == eventId);
    }

    public Registration? GetRegistrationForEvent(int eventId)
    {
        return _userRegistrations.FirstOrDefault(r => r.EventId == eventId);
    }
}