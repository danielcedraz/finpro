using FinanciamentoProjetos.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FinanciamentoProjetos.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ApplicationContext _context;
        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }
        public User FindUser(int Id)
        {
            return _context.User.Find(Id);
        }

        public User FindUserByEmail(string Email)
        {
            return _context.User.Where(u => u.Email == Email).FirstOrDefault();
        }

        public User LoginUser(string Email, string Password)
        {
            return _context.User.Where(u => u.Email == Email && u.Password == Password).FirstOrDefault();
        }

        public List<State> StateList()
        {
            return _context.State.ToList();
        }

        public User RegisterUser(User User)
        {
            var user = _context.User.Add(User).Entity;
            _context.SaveChanges();

            return user;
        }
    }
}
