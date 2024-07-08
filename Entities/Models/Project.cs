using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Project
    {
        [Column("ProjectId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Proje adı gerekli bir alandır.")]
        [MaxLength(60, ErrorMessage = "İsim uzunluğu en fazla 60 karakterdir.")]
        public string? Name { get; set; }

        public string? Description { get; set; }
        public string? Field { get; set; }
        public string? ImageUrl { get; set; }

        public ICollection<Employee>? Employees { get; set; }
    }
}
