using To_Do_List_Manager.Models;

TaskItem item1 = new("Buy groceries", "Milk, Bread, Eggs", DateTime.Now.AddDays(2));
item1.Completed();
Console.WriteLine(item1);