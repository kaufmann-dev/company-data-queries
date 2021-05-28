using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.model
{
    [Table("PRODUCT")]
    public class Product
    {
        [Column("PRODUCT_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        
        [Column("PRODUCT_NAME", TypeName = "VARCHAR(45)")]
        [Required]
        public string Name { get; set; }
        
        [Column("PRODUCT_LICENSE", TypeName = "VARCHAR(45)")]
        public ELicense License { get; set; }
        
        [Column("PRODUCT_DESCRIPTION", TypeName = "VARCHAR(255)")]
        public string Description { get; set; }

        /*public Company Company { get; set; }
        
        [Column("COMPANY_ID")]
        public int? CompanyId { get; set; }*/

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(License)}: {License}, {nameof(Description)}: {Description}";
        }
    }
}