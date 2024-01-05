namespace StudentsInfo.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FacultyId { get; set; }

        // Навігаційне властивість до Faculty
        public Faculty Faculty { get; set; }
    }
}
