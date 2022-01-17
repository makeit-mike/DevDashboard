namespace DevDashboard.Models
{
    public class ToDoItem
    {
        public int ID { get; set; }
        public string Task { get; set; }
        public string Owner { get; set; }
        public string Comments { get; set; }
        public string Status { get; set; }  // ToDo Convert to Enum.
        public DateTime DateTimeAdded { get; set; }
        public string DateDue { get; set; } // ToDo Convert to DateTime.
        public DateTime DateTimeCompleted { get; set; }
    }
}

