using FinanciamentoProjetos.Domain.Entities;
using FinanciamentoProjetos.Infra.Repositories;
using System.Collections.Generic;

namespace FinanciamentoProjetos.Domain.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public User FindUser(int Id)
        {
            return _repository.FindUser(Id);
        }

        public User FindUserByEmail(string Email)
        {
            return _repository.FindUserByEmail(Email);
        }

        public User LoginUser(string Email, string Password)
        {
            return _repository.LoginUser(Email, Password);
        }

        public List<State> StateList()
        {
            return _repository.StateList();
        }

        public User RegisterUser(User User)
        {
            return _repository.RegisterUser(User);
        }
    }
}
