using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.model
{
    [Table("EMPLOYEE")]
    public class Employee
    {
        [Column("EMPLOYEE_ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Column("EMPLOYEE_FIRST_NAME")]
        [Required]
        public string FirstName { get; set; }
        
        [Column("EMPLOYEE_LAST_NAME")]
        [Required]
        public string LastName { get; set; }
        
        public Employee Superior { get; set; }
        
        [Column("SUPERIOR_ID")]
        public int? SuperiorId { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(Superior)}: {Superior}, {nameof(SuperiorId)}: {SuperiorId}";
        }
    }
}