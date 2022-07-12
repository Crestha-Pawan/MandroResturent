using System;
using System.Collections.Generic;
using System.Text;
using FiboInfraStructure.Entity.FiboAddress;
using FiboInfraStructure.Entity.FiboBilling;
using FiboInfraStructure.Entity.FiboInventory;
using FiboInfraStructure.Entity.FiboLodge;
using FiboInfraStructure.Entity.FiboOffice;
using FiboInfraStructure.Entity.FiboParty;
using FiboInfraStructure.Entity.FiboUser;
using FiboInfraStructure.Entity.Ledger;
using FiboInfraStructure.Entity.Payroll;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FiboInfraStructure.Data
{
    public class ApplicationUser : IdentityUser
    {

    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public ApplicationDbContext()
        {

        }

        //Address
        public virtual DbSet<Provience> Proviences { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<LocalLevel> LocalLevels { get; set; }

        //Office
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<FiscalYear> FiscalYears { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<MeasuringUnit> MeasuringUnits { get; set; }

        //Inventory
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductSubCategory> ProductSubCategory { get; set; }

        //User
        public virtual DbSet<UserBranch> UserBranch { get; set; }

        //Billings

        public virtual DbSet<BillingStatus> BillingStatus { get; set; }
        public virtual DbSet<Billing> Billings { get; set; }
        public virtual DbSet<BillingInfo> BillingInfo { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
       
        public virtual DbSet<Table> Table { get; set; }
        public virtual DbSet<InventorySummary> InventorySummary { get; set; }

        public virtual DbSet<Tax> Tax { get; set; }
        public virtual DbSet<ServiceCharge> ServiceCharge { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<Year> Years { get; set; }
        public virtual DbSet<Month> Months { get; set; }
        public virtual DbSet<StockAdjustment> StockAdjustments { get; set; }

        public virtual DbSet<StockAdjustmentDetail> StockAdjustmentDetails { get; set; }

        public virtual DbSet<Expense> Expense { get; set; }
        public virtual DbSet<ExpenseDetail> ExpenseDetails { get; set; }
        public virtual DbSet<PettyCashFund> PettyCashFunds { get; set; }

        //Room
        public virtual DbSet<RoomSetup> RoomSetups { get; set; }
        public virtual DbSet<RoomCheckIn> RoomCheckIns { get; set; }

        //Party//
        public virtual DbSet<Party> Parties { get; set; }

        //Ledger//
        public virtual DbSet<Ledger> Ledgers { get; set; }

        //LedgerDetails//
        public virtual DbSet<LedgerDetail> LedgerDetails { get; set; }

        //Payroll

        public virtual DbSet<SalarySheet> SalarySheets { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<LodgeBilling> LodgeBillings { get; set; }
        public virtual DbSet<DayCashBook> DayCashBooks { get; set; }
        public virtual DbSet<OpeningClosing> OpeningClosings { get; set; }
    }
}
