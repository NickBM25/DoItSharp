using Microsoft.VisualBasic;
using To_Do_List_Manager.Interfaces;


namespace To_Do_List_Manager.Models
{
    internal class TaskItem(string title, string description, DateTime? dueDate) : ToDoItem(title, description, dueDate)
    {

    }

}
