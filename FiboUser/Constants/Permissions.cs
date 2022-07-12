using System;
using System.Collections.Generic;
using System.Text;

namespace FiboUser.Constants
{
    public class Permissions
    {
        public static List<string> GeneratePermissionsForModule(string module)
        {
            return new List<string>()
            {
                $"Premissions.{module}.Create",
                $"Premissions.{module}.Delete",
                $"Premissions.{module}.Update",
                $"Premissions.{module}.View",
                $"Premissions.{module}.Index",
                $"Premissions.{module}.BranchReport",
            };
        }
        public static class ApplicationPermission
        {
            //Account Register
            public const string AccountView = "Permissions.Account.View";
            public const string AccountRegister = "Permissions.Account.Register";
            public const string AccountIndex = "Permissions.Account.Index";
            public const string Delete = "Permissions.Products.Delete";

            //Billing
            public const string BillingView = "Permissions.Billing.View";
            public const string BillingCreate = "Permissions.Billing.Create";
            public const string BillingIndex = "Permissions.Billing.Index";
            public const string BillingLatest = "Permissions.Billing.LatestBilling";

            //Branch
            public const string BranchView = "Permissions.Branch.View";
            public const string BranchCreate = "Permissions.Branch.Create";
            public const string BranchDelete = "Permissions.Branch.Delete";
            public const string BranchIndex = "Permissions.Branch.Index";
            public const string BranchUpdate = "Permissions.Branch.Update";
            public const string BranchRerport = "Permissions.Branch.BranchReport";


            //District
            public const string DistrictView = "Permissions.District.View";
            public const string DistrictCreate = "Permissions.District.Create";
            public const string DistrictDelete = "Permissions.District.Delete";
            public const string DistrictIndex = "Permissions.District.Index";
            public const string DistrictUpdate = "Permissions.District.Update";

            //Employee
            public const string EmployeeView = "Permissions.Employee.View";
            public const string EmployeeCreate = "Permissions.Employee.Create";
            public const string EmployeeDelete = "Permissions.Employee.Delete";
            public const string EmployeeDetails = "Permissions.Employee.Details";
            public const string EmployeeIndex = "Permissions.Employee.Index";
            public const string EmployeeUpdate = "Permissions.Employee.Update";

            //Post
            public const string PostView = "Permissions.Post.View";
            public const string PostCreate = "Permissions.Post.Create";
            public const string PostDelete = "Permissions.Post.Delete";
            public const string PostDetails = "Permissions.Post.Details";
            public const string PostIndex = "Permissions.Post.Index";
            public const string PostUpdate = "Permissions.Post.Update";

            //Fascal Year
            public const string FiscalYearView = "Permissions.FiscalYear.View";
            public const string FiscalYearCreate = "Permissions.FiscalYear.Create";
            public const string FiscalYearUpdate = "Permissions.FiscalYear.Update";
            public const string FiscalYearDelete = "Permissions.FiscalYear.Delete";
            public const string FiscalYearIndex = "Permissions.FiscalYear.Index";

            //Inventory
            public const string InventoryView = "Permissions.Inventory.View";
            public const string InventoryCreate = "Permissions.Inventory.Create";
            public const string InventoryUpdate = "Permissions.Inventory.Update";
            public const string InventoryDelete = "Permissions.Inventory.Delete";
            public const string InventoryIndex = "Permissions.Inventory.Index";

            //Item
            public const string ItemView = "Permissions.Item.View";
            public const string ItemCreate = "Permissions.Item.Create";
            public const string ItemUpdate = "Permissions.Item.Update";
            public const string ItemDelete = "Permissions.Item.Delete";
            public const string ItemIndex = "Permissions.Item.Index";

            //Local Level
            public const string LocalLevelView = "Permissions.LocalLevel.View";
            public const string LocalLevelCreate = "Permissions.LocalLevel.Create";
            public const string LocalLevelDelete = "Permissions.LocalLevel.Delete";
            public const string LocalLevelIndex = "Permissions.LocalLevel.Index";
            public const string LocalLevelUpdate = "Permissions.LocalLevel.Update";

            //Measuring Unit
            public const string MeasuringUnitView = "Permissions.MeasuringUnit.View";
            public const string MeasuringUnitCreate = "Permissions.MeasuringUnit.Create";
            public const string MeasuringUnitUpdate = "Permissions.MeasuringUnit.Update";
            public const string MeasuringUnitDelete = "Permissions.MeasuringUnit.Delete";
            public const string MeasuringUnitIndex = "Permissions.MeasuringUnit.Index";

            //Office
            public const string OfficeView = "Permissions.Office.View";
            public const string OfficeCreate = "Permissions.Office.Create";
            public const string OfficeDelete = "Permissions.Office.Delete";
            public const string OfficeDetails = "Permissions.Office.Details";
            public const string OfficeIndex = "Permissions.Office.Index";
            public const string OfficeUpdate = "Permissions.Office.Update";

            //Product
            public const string ProductView = "Permissions.Product.View";
            public const string ProductCreate = "Permissions.Product.Create";
            public const string ProductDelete = "Permissions.Product.Delete";
            public const string ProductDetails = "Permissions.Product.Details";
            public const string ProductIndex = "Permissions.Product.Index";
            public const string ProductUpdate = "Permissions.Product.Update";

            //Product Category
            public const string ProductCategoryView = "Permissions.ProductCategory.View";
            public const string ProductCategoryCreate = "Permissions.ProductCategory.Create";
            public const string ProductCategoryDelete = "Permissions.ProductCategory.Delete";
            public const string ProductCategoryDetails = "Permissions.ProductCategory.Details";
            public const string ProductCategoryIndex = "Permissions.ProductCategory.Index";
            public const string ProductCategoryUpdate = "Permissions.ProductCategory.Update";

            //Provience
            public const string ProvienceView = "Permissions.Provience.View";
            public const string ProvienceCreate = "Permissions.Provience.Create";
            public const string ProvienceDelete = "Permissions.Provience.Delete";
            public const string ProvienceIndex = "Permissions.Provience.Index";
            public const string ProvienceUpdate = "Permissions.Provience.Update";

            //Table
            public const string TableView = "Permissions.Table.View";
            public const string TableCreate = "Permissions.Table.Create";
            public const string TableDelete = "Permissions.Table.Delete";
            public const string TableIndex = "Permissions.Table.Index";
            public const string TableUpdate = "Permissions.Table.Update";
            
            //tax
            public const string TaxView = "Permissions.Tax.View";
            public const string TaxCreate = "Permissions.Tax.Create";
            public const string TaxUpdate = "Permissions.Tax.Update";
            public const string TaxDelete = "Permissions.Tax.Delete";
            public const string TaxIndex = "Permissions.Tax.Index";

            //Service Charge
            public const string ServiceChargeView = "Permissions.ServiceCharge.View";
            public const string ServiceChargeCreate = "Permissions.ServiceCharge.Create";
            public const string ServiceChargeUpdate = "Permissions.ServiceCharge.Update";
            public const string ServiceChargeDelete = "Permissions.ServiceCharge.Delete";
            public const string ServiceChargeIndex = "Permissions.ServiceCharge.Index";

            //Report
            public const string InventoryReport = "Permissions.InventoryReport.InventoryReport";
            public const string BillingReport = "Permissions.BillingReport.BillingReport";
            public const string SalesReport = "Permissions.SalesReport.SalesReport";
            public const string IngredientReport = "Permissions.IngredientReport.IngredientReport";
            public const string PurchaseReport = "Permissions.InventoryReport.PurchaseReport";
            public const string VendorList = "Permissions.VendorReport.VendorList";
            public const string DayCashBookReport = "Permissions.DayCashBookReport.DayCashBookReport";
            public const string LedgerReport = "Permissions.Ledger.PartiesReport";
            public const string SalarySheetReport = "Permissions.SalarySheet.SalaryReport";
            public const string BillingCreditReport = "Permissions.BillingReport.BillingCreditReport";

            //Service Charge
            public const string StockAdjustmentView = "Permissions.StockAdjustment.View";
            public const string StockAdjustmentCreate = "Permissions.StockAdjustment.Create";
            public const string StockAdjustmentUpdate = "Permissions.StockAdjustment.Update";
            public const string StockAdjustmentDelete = "Permissions.StockAdjustment.Delete";
            public const string StockAdjustmentIndex = "Permissions.StockAdjustment.Index";

            //RoomSetup
            public const string RoomSetupView = "Permissions.RoomSetup.View";
            public const string RoomSetupCreate = "Permissions.RoomSetup.Create";
            public const string RoomSetupUpdate = "Permissions.RoomSetup.Update";
            public const string RoomSetupDelete = "Permissions.RoomSetup.Delete";
            public const string RoomSetupIndex = "Permissions.RoomSetup.Index";

            //RoomCheckIn
            public const string RoomCheckInView = "Permissions.RoomCheckIn.View";
            public const string RoomCheckInCreate = "Permissions.RoomCheckIn.Create";
            public const string RoomCheckInUpdate = "Permissions.RoomCheckIn.Update";
            public const string RoomCheckInDelete = "Permissions.RoomCheckIn.Delete";
            public const string RoomCheckInIndex = "Permissions.RoomCheckIn.Index";
            public const string RoomCheckOut = "Permissions.RoomCheckIn.RoomCheckOut";
            public const string RoomSetupList = "Permissions.RoomCheckIn.RoomSetupList";

            //Party & Ledger 
            public const string Party = "Permissions.Party.Index";
            public const string Ledger = "Permissions.Ledger.Index";

            //Payroll
            public const string Payroll = "Permissions.Employee.SalaryIndex";
            public const string openingclosing = "Permissions.OpeningClosing.Index";

            //Administrative Expenses
            public const string Expensescreate = "Permissions.expenses.expensesCreate"; 
            public const string expensesview = "Permissions.expenses.expensesIndex"; 
            public const string update = "Permissions.expenses.expensesUpdate";
        }
    }
}
