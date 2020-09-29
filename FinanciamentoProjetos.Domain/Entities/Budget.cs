using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanciamentoProjetos.Domain.Entities
{
    [Table("Budget")]
    public class Budget : BaseEntity
    {
        [Required]
        [Column("Customer")]
        public int IdCustomer { get; set; }

        [ForeignKey("IdCustomer")]
        public virtual User Customer { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public int FullStackAmount { get; set; }

        [Required]
        public int DesignerAmount { get; set; }

        [Required]
        public int ScrumMasterAmount { get; set; }

        [Required]
        public int ProjectOwnerAmount { get; set; }

        [Required]
        public int DurationDays { get; set; }

        [Required]
        public double Value { get; set; }
    }
}
