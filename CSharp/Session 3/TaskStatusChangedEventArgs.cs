using System;

public class TaskStatusChangedEventArgs : EventArgs
{
    public Task Task { get; }

    public TaskStatusChangedEventArgs(Task task)
    {
        Task = task;
    }
}
