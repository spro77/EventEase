namespace EventEase;

using EventEase.Models;

public class TaskService
{
    private List<TaskItem> _tasks = new();
    private int _nextId = 1;

    public TaskService()
    {
        // Add some sample tasks
        AddTask(new TaskItem { Name = "Learn Blazor", Description = "Study Blazor WASM fundamentals" });
        AddTask(new TaskItem { Name = "Build Todo App", Description = "Create a simple task management application" });
        AddTask(new TaskItem { Name = "Practice C#", Description = "Review C# concepts and syntax" });
    }
    
    public List<TaskItem> GetTasks() => _tasks;
    
    public void AddTask(TaskItem task)
    {
        task.Id = _nextId++;
        _tasks.Add(task);
    }
    
    public void ToggleComplete(int id)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == id);
        if (task != null) task.IsCompleted = !task.IsCompleted;
    }
    
    public void DeleteTask(int id)
    {
        _tasks.RemoveAll(t => t.Id == id);
    }
}