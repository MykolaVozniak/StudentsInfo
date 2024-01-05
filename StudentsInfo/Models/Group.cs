namespace StudentsInfo.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? FacultyId { get; set; }

        // Навігаційне властивість до Faculty
        public Faculty Faculty { get; set; }

        // Навігаційні властивості
        public List<Student> Students { get; set; }
    }
}
