using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.model
{
    public class Teacher : Person
    {
        [Required]
        [Column("KUERZEL")]
        public string Short { get; set; }
    }
}