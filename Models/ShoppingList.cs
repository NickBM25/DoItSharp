using To_Do_List_Manager.Entities;
using To_Do_List_Manager.Interfaces;

namespace To_Do_List_Manager.Models
{
    internal class ShoppingList(string title, string description, DateTime? dueDate) : ToDoItem(title, description, dueDate), IItemList
    {
        private List<ShoppingItem> _items = [];
        public IReadOnlyCollection<ShoppingItem> Items => _items;
    }
}
