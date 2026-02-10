using System;
using System.Collections.Generic;
using System.Text;

namespace To_Do_List_Manager.Entities
{
    internal class ShoppingItem
    {
        public required string Name { get; set; }
        public decimal? Price { get; set; }
        public int? Amount { get; set; }
        public bool IsPurchased { get; set; } = false;
    }
}
