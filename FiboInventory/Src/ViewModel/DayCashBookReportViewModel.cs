using FiboInfraStructure.Entity.FiboBilling;
using FiboInfraStructure.Entity.FiboInventory;
using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Entity.FiboParty;
using FiboInfraStructure.Entity.Ledger;
using System.ComponentModel.DataAnnotations.Schema;
using FiboInfraStructure.Entity.Payroll;
using FiboInfraStructure.Entity.FiboOffice;

namespace FiboInventory.Src.ViewModel
{
    public class DayCashBookReportViewModel
    {
        public List<Inventory> InventoryList { get; set; }
        public List<Expense> Expenses { get; set; }
        public List<DayCashBook> DayCashBook { get; set; }
        public List<Billing> BillingList { get; set; }
        public List<BillingInfo> BillingInfoList { get; set; }
        public List<Ledger> LedgerList { get; set; }
        public List<LedgerDetail> LedgerDetailList { get; set; }
        public List<SalarySheet> SalarySheets { get; set; }
        public DateTime? Date { get; set; }
        [NotMapped]
        public DateTime? FromDate { get; set; }
        [NotMapped]
        public DateTime? ToDate { get; set; }
        [NotMapped]
        public string FromMiti { get; set; }
        [NotMapped]
        public string ToMiti { get; set; }
    }
}
