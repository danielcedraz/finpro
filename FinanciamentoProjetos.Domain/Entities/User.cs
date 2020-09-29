using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanciamentoProjetos.Domain.Entities
{
    [Table("User")]
    public class User : BaseEntity
    {      
        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(200)]
        public string Email { get; set; }

        [Required]
        [MaxLength(5000)]
        public string Password { get; set; }

        [Required]
        public Int64 PhoneNumber { get; set; }

        [Required]
        public Int64 CPF { get; set; }

        [Required]
        [MaxLength(100)]
        public string CompanyName { get; set; }

        [Required]
        public Int64 CNPJ { get; set; }

        [Required]
        public int CEP { get; set; }

        [Required]
        [MaxLength(200)]
        public string Address { get; set; }

        [Required]
        [MaxLength(10)]
        public string AddressNumber { get; set; }

        [MaxLength(100)]
        public string AddressComplement { get; set; }

        [Required]
        [Column("AddressState")]
        public string IdAddressState { get; set; }

        [ForeignKey("IdAddressState")]
        public virtual State AddressState { get; set; }

        [Required]
        [MaxLength(100)]
        public string AddressCity { get; set; }
    }
}
