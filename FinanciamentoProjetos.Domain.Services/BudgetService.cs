using FinanciamentoProjetos.Domain.Entities;
using FinanciamentoProjetos.Infra;
using FinanciamentoProjetos.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanciamentoProjetos.Domain.Services
{
    public class BudgetService : IBudgetService
    {
        private IBudgetRepository _repository;
        public BudgetService(IBudgetRepository repository)
        {
            _repository = repository;
        }
        public List<Budget> BudgetList(int UserId)
        {
            return _repository.BudgetList(UserId);
        }

        public Budget FindBudget(int Id)
        {
            return _repository.FindBudget(Id);
        }

        public Budget RegisterBudget(Budget Budget)
        {
            return _repository.RegisterBudget(Budget);
        }
    }
}
