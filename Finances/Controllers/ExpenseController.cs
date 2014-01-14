using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Finances.Repository;

namespace Finances.Controllers
{
    public class ExpenseController : Controller
    {
        IExpenseRepository _ExpenseRepo;

        public ExpenseController()
            : this(null)
        {
        }

        public ExpenseController(IExpenseRepository expenseRepo)
        {
            _ExpenseRepo = expenseRepo ?? new ExpenseRepository();
        }

        public ActionResult Index()
        {
            return null;
        }

        public ActionResult GetExpenses()
        {
            return View("Index", _ExpenseRepo.GetExpenses());

            
            //return Json(_ExpenseRepo.GetExpenses());
        }

    }
}
