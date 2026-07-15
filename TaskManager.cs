using System;
using System.Collections.Generic;
using System.Linq;

public class TaskManager
{
    private readonly List<string> _tasks = new()
    {
        "Review pull request",
        "Write unit tests",
        "Deploy to staging"
    };

    private readonly HashSet<string> _completedTasks =
        new(StringComparer.OrdinalIgnoreCase)
        {
            "Write unit tests"
        };

    public int GetPendingTaskCount()
    {
        return _tasks.Count(t => !_completedTasks.Contains(t));
    }

    public int GetCompletedTaskCount()
    {
        return _completedTasks.Count;
    }

    public string GetNextTask()
    {
        var pending = _tasks.FirstOrDefault(t => !_completedTasks.Contains(t));

        return pending ?? "No pending tasks";
    }
}