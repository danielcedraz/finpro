using FinanciamentoProjetos.Domain.Entities;
using System;

namespace FinanciamentoProjetos.Domain.DTO
{
    public class UserRegisterDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string LastName { get; set; }
        public string CPF { get; set; }
        public string CompanyName { get; set; }
        public string CNPJ { get; set; }
        public string CEP { get; set; }
        public string Address { get; set; }
        public string AddressNumber { get; set; }
        public string AddressComplement { get; set; }
        public State AddressState { get; set; }
        public string AddressCity { get; set; }
    }
}
