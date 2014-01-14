using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Finances.Model;

namespace Finances.Repository
{
    public interface IExpenseRepository
    {
        List<Expense> GetExpenses();
    }
}
