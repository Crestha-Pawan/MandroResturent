using FiboInfraStructure;
using FiboInfraStructure.Entity.FiboBilling;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInfraStructure.Entity.Payroll;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FiboBilling.Src.ViewModel
{
    public  class DashBoardViewModel
    {
        public List<Billing> Billings { get; set; }
        public PaginatedList<Billing> billings { get; set; }
        public List<ExpenseDetail> ExpnsesD { get; set; }
        public List<Inventory> Inventories { get; set; }
        public List<SalarySheet> salarySheets { get; set; }
        public List<Expense> Expenses { get; set; }
        public List<BillingInfo> BillingInfoList { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public DateTime? FromDate { get; set; }
        [NotMapped]
        public DateTime? ToDate { get; set; }
        [NotMapped]
        public string FromMiti { get; set; }
        [NotMapped]
        public string ToMiti { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public string PaymentMethod { get; set; }
    }
}
