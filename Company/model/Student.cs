using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.model
{
    public class Student : Person
    {
        [Column("KATALOGNUMMER", TypeName = "NUMBER")]
        [Required]
        public int Number { get; set; }
        
        [Column("CLASS")]
        [Required]
        public Class Class { get; set; }
    }
}