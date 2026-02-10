using To_Do_List_Manager.Entities;

namespace To_Do_List_Manager.Interfaces
{
    internal interface IItemList
    {
        public IReadOnlyCollection<ShoppingItem> Items { get; }
    }
}