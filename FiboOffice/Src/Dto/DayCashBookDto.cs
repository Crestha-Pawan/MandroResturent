using FiboInfraStructure.Entity.FiboBilling;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInfraStructure.Entity.Ledger;
using FiboInfraStructure.Entity.Payroll;
using FiboInfraStructure.Src;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboOffice.Src.Dto
{
    public class DayCashBookDto : BaseDto
    {
        public DateTime? OpeningDate { get; set; }
        public string OpeningBalance { get; set; }

        public List<Inventory> InventoryList { get; set; }
        public List<Expense> Expenses { get; set; }
        public List<Billing> BillingList { get; set; }
        public List<BillingInfo> BillingInfoList { get; set; }
        public List<Ledger> LedgerList { get; set; }
        public List<LedgerDetail> LedgerDetailList { get; set; }
        public List<SalarySheet> SalarySheets { get; set; }

    }
}
