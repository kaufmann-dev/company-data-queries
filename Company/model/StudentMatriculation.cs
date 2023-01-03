using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.model
{
    [Table("STUDENT_MATRICULATION")]
    public class StudentMatriculation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("MATRICULATIONS_ID")]
        public int Id { get; set; }

        [ForeignKey("STUDENT_ID")]
        public Student Student { get; set; }
    }
}