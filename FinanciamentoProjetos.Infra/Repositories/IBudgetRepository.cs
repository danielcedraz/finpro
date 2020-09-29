using FinanciamentoProjetos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanciamentoProjetos.Infra.Repositories
{
    public interface IBudgetRepository
    {
        public Budget FindBudget(int Id);
        public List<Budget> BudgetList(int UserId);
        public Budget RegisterBudget(Budget Budget);
    }
}
