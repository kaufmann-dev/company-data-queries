using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.model
{
    [Table("CLASS")]
    public class Class
    {
        [Key]
        [Column("CLASS_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [Column("CLASS_NAME", TypeName = "VARCHAR(45)")]
        public string Name { get; set; }
    }
}