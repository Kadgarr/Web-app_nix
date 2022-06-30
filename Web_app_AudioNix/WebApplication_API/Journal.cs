namespace WebApplication_API
{
    public class Journal
    {
        
        public Journal(Guid id, string fullName, DateTime date, bool attendance)
        {
            Id = id;
            FullName = fullName;
            Date = date;
            Attendance = attendance;
        }

        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateTime Date { get; set; }
        public bool Attendance { get; set; } 
    }
}
