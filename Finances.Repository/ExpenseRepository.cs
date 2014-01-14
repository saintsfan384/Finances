using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Finances.Model;

namespace Finances.Repository
{
    public class ExpenseRepository : IExpenseRepository
    {
        Finances db = new Finances();

        public List<Expense> GetExpenses()
        {
            db.Expenses.Add(new Expense { ID = Guid.NewGuid(), Amount = 44, Description = "Test", DateIncurred = DateTime.Today, Required = true });
            db.SaveChanges();
            return db.Expenses.ToList();
        }
    }
}
