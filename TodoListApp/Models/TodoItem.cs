
namespace TodoListApp.Models;

// Record to store the information about each To Do list item
public record TodoItem(int Id, string Task, bool IsDone = false)
{
    // Overriding the ToString() function to print the To Do list in the desired format
    public override string ToString()
    {
        // Mark completed items with an 'x'
        string boxContents = "";
        if (IsDone == true)
        {
            boxContents = "x";
        }

        // Create the output string to print
        string output = string.Format("{0}. {1} [{2}]", Id, Task, boxContents);
        return output;
    }
}
