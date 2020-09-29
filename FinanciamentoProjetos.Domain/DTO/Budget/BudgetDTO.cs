using FinanciamentoProjetos.Domain.Entities;
using System;

namespace FinanciamentoProjetos.Domain.DTO
{
    public class BudgetDTO
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public UserDTO Customer { get; set; }
        public int FullStackAmount { get; set; }
        public int DesignerAmount { get; set; }
        public int ScrumMasterAmount { get; set; }
        public int ProjectOwnerAmount { get; set; }
        public int DurationDays { get; set; }
        public double Value { get; set; }
        public ErrorDTO Error { get; set; }
    }
}
