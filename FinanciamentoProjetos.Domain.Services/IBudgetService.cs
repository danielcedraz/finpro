using FinanciamentoProjetos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanciamentoProjetos.Domain.Services
{
    public interface IBudgetService
    {
        public Budget FindBudget(int Id);
        public List<Budget> BudgetList(int UserId);
        public Budget RegisterBudget(Budget Budget);
    }
}
