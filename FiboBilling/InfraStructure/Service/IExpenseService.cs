using FiboBilling.InfraStructure.Assembler;
using FiboBilling.InfraStructure.Repository;
using FiboBilling.Src.Dto;
using FiboInfraStructure.Entity.FiboBilling;
using FiboInfraStructure.Entity.Payroll;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FiboBilling.InfraStructure.Service
{
    public interface IExpenseService
    {
        Task<ExpenseDto> InsertAsync(ExpenseDto dto);
        Task<Expense> Delete(long Id);
       
    }
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _repository;
        private readonly IExpenseAssembler _assembler;
        public ExpenseService(IExpenseRepository repository,IExpenseAssembler assembler)
        {
            _repository = repository;
            _assembler = assembler;
        }
        public async Task<Expense> Delete(long Id)
        {
            var expense = await _repository.GetByIdAsync(Id) ?? throw new Exception();
            return await _repository.DeleteAsync(expense).ConfigureAwait(true);
        }

        public async Task<ExpenseDto> InsertAsync(ExpenseDto dto)
        {
            Expense expense = new Expense();
            _assembler.copyTo(expense, dto);
            await _repository.AddAsync(expense);
            return dto;
        }

      
    }
}
