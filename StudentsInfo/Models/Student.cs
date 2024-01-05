namespace StudentsInfo.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public double? AverageScore { get; set; }
        public int? GroupId { get; set; }

        // Навігаційне властивість до Group
        public Group Group { get; set; }
    }
}
