using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanciamentoProjetos.Domain.Entities
{
    [Table("State")]
    public class State
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string UF { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
