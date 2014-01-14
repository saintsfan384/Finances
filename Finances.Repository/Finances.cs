using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Finances.Model;

namespace Finances.Repository
{
    public class Finances : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }        
    }
}
