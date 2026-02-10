namespace To_Do_List_Manager.Models
{
    internal abstract class ToDoItem(string title, string description, DateTime? dueDate)
    {
        public static Guid Id { get; } = Guid.NewGuid();
        public string Title { get; set; } = title;
        public string Description { get; set; } = description;
        public DateTime CreationDate { get; } = DateTime.Now;
        public DateTime? DueDate { get; set; } = dueDate;
        public DateTime? CompletionDate { get; private set; } = null;
        public bool IsCompleted { get; set; } = false;
        public bool? IsOverdue =>
            DueDate is null
                ? null
                : DateTime.Now > DueDate.Value && !IsCompleted;
        public void Completed()
        {
            IsCompleted = true;
            CompletionDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Title: {Title}\nDescription: {Description}\nCreation Date: {CreationDate}\nDue Date: {DueDate}\n{(CompletionDate is null ? null : $"Completion Date: {CompletionDate}\n") }Is Completed: {IsCompleted}\nOverdue: {IsOverdue}";
        }
    }

    
}
