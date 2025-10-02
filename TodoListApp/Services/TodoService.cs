
using System.Collections.ObjectModel;
using System.ComponentModel;
using TodoListApp.Models;

namespace TodoListApp.Services;

// The class that contains the To Do list and methods to operate on it
public class TodoService()
{
    // The list of items, kept private
    private List<TodoItem> _Items = [];

    // Public interface for reading the list
    public IReadOnlyList<TodoItem> Items => _Items;

    // Method to add a new item to the list
    public int AddItem(string Task)
    {
        // Check for empty input
        if (string.IsNullOrWhiteSpace(Task))
        {
            Console.WriteLine("Task must be a string.");
            return 1;
        }

        // Add the new item to the To Do list
        TodoItem newItem = new(_Items.Count + 1, Task);
        _Items.Add(newItem);

        return 0;
    }

    // Method to mark an item on the list as completed
    public int MarkDone(int Id)
    {
        // Checks for an ID in a valid range
        if (Id > _Items.Count || Id < 1)
        {
            Console.WriteLine("{0} is not a valid ID in the list.", Id);
            return 1;
        }

        // Make a new record that is marked as completed
        TodoItem oldItem = _Items[Id - 1];
        TodoItem updatedItem = new(Id, oldItem.Task, true);

        // Update the list with the new record
        _Items[Id - 1] = updatedItem;

        return 0;

    }
}