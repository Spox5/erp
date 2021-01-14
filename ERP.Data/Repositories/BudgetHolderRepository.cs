using System;
using ERP.Data.Models;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ERP.Data.Repositories
{
    public class BudgetHolderRepository
    {
        private readonly ERPContext erpContext;

        public BudgetHolderRepository(ERPContext erpContext)
        {
            this.erpContext = erpContext;
        }

        public List<BudgetHolder> GetAll()
        {
            return erpContext.BudgetHolders.ToList();
        }

        public void Add(BudgetHolder budgetHolder)
        {
            erpContext.BudgetHolders.Add(budgetHolder);
            erpContext.SaveChanges();
        }
    }
}
