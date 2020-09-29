using FinanciamentoProjetos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinanciamentoProjetos.Infra.Repositories
{
    public class BudgetRepository : IBudgetRepository
    {
        private ApplicationContext _context;

        public BudgetRepository(ApplicationContext context)
        {
            _context = context;
        }
        public List<Budget> BudgetList(int UserId)
        {
            return _context.Budget.Where(b => b.IdCustomer == UserId).ToList();
        }

        public Budget FindBudget(int Id)
        {
            return _context.Budget.Find(Id);
        }

        public Budget RegisterBudget(Budget Budget)
        {
            var bud = _context.Budget.Add(Budget).Entity;
            _context.SaveChanges();

            return bud;
        }
    }
}
