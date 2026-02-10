using To_Do_List_Manager.Entities;
using To_Do_List_Manager.Interfaces;

namespace To_Do_List_Manager.Models
{
    internal class ShoppingList(string title, string description, DateTime? dueDate) : ToDoItem(title, description, dueDate), IItemList
    {
        private readonly List<ShoppingItem> _items = [];
        public IReadOnlyCollection<ShoppingItem> Items => _items;
        
        public void AddItem(ShoppingItem item)
        {
            _items.Add(item);
        }
        public void RemoveItem(ShoppingItem item)
        {
            _items.Remove(item);
        }
        public override string ToString()
        {
            return $"Shopping List: {Title} - {Description} (Due: {DueDate?.ToShortDateString() ?? "No due date"})\nItems:\n{string.Join("\n", Items.Select(i => $"- {i}"))}";
        }
    }
}
