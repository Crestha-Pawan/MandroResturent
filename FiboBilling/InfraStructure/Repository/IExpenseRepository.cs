using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Data;
using FiboInfraStructure.Entity.FiboBilling;
using FiboInfraStructure.Entity.Payroll;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FiboBilling.InfraStructure.Repository
{
    public interface IExpenseRepository : IRepository<Expense>
    {
        Task<List<Expense>> GetAllExpense();
    }

    public class ExpenseRepository : Repository<Expense>, IExpenseRepository
    {
        public ExpenseRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<Expense>> GetAllExpense()
        {
            return await GetAllAsync().ToListAsync();
        }
    }
}
