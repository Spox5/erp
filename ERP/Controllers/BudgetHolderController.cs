using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP.Data.Models;
using ERP.Data.Repositories;

namespace ERP.Controllers
{
    public class BudgetHolderController : Controller
    {
        private readonly BudgetHolderRepository budgetHolderRepository;
        public BudgetHolderController(BudgetHolderRepository budgetHolderRepository)
        {
            this.budgetHolderRepository = budgetHolderRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public int AddBudgetHolder([FromBody] BudgetHolder budgetHolder)
        {
            budgetHolderRepository.Add(budgetHolder);

            return 0;
        }
    }
}
