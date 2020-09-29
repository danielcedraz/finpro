using FinanciamentoProjetos.Domain.Entities;
using System;
using System.Collections.Generic;

namespace FinanciamentoProjetos.Domain.Services
{
    public interface IUserService
    {
        public User FindUser(int Id);
        public User FindUserByEmail(string Email);
        public User LoginUser(string Email, string Password);
        public List<State> StateList();
        public User RegisterUser(User User);
    }
}
