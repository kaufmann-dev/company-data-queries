using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.model
{
    [Table("PERSON")]
    public class Person
    {
        [Column("PERSON_ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Column("FIRST_NAME")]
        [Required]
        public string FirstName { get; set; }
        
        [Column("LAST_NAME")]
        [Required]
        public string LastName { get; set; }
    }
}