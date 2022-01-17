namespace DevDashboard.Models
{
    public class CodeReview
    {
        public int ID { get; set; }

        public string Application { get; set; }

        public string ReviewDate { get; set; } //ToDo: Make these work as DateTimes
        public string ReleaseDate { get; set; } //ToDo: Make these work as DateTimes

        public string Approver1 { get; set; }
        public string Approver2 { get; set; }

        public string Status { get; set; } //ToDo: Make these work as ReviewStatus enum type.


        // Needs implementing.
        public int FailCount { get; set; } = 0;
        public bool ContainsSQL { get; set; } = false;
    }
}


