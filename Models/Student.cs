using System.ComponentModel.DataAnnotations;

namespace CRUDApplication.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Gender { get; set; }

        public string? Standard { get; set; }

    }
}
