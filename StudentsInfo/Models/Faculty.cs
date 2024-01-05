namespace StudentsInfo.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Навігаційні властивості
        public List<Department> Departments { get; set; }
        public List<Group> Groups { get; set; }
    }
}
