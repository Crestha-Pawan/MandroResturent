using FiboAddress.InfraStructure.Assembler;
using FiboAddress.InfraStructure.Repository;
using FiboAddress.InfraStructure.Service;
using FiboBilling.InfraStructure.Assembler;
using FiboBilling.InfraStructure.Repository;
using FiboBilling.InfraStructure.Service;
using FiboCounterSystem.Permission;
using FiboInfraStructure.BaseInfraStructure;
using FiboInfraStructure.Data;
using FiboInventory.InfraStructure.Assembler;
using FiboInventory.InfraStructure.Repository;
using FiboInventory.InfraStructure.Service;
using FiboLodge.InfraStructure.Assembler;
using FiboLodge.InfraStructure.Repository;
using FiboLodge.InfraStructure.Service;
using FiboOffice.InfraStructure.Assembler;
using FiboOffice.InfraStructure.Repository;
using FiboOffice.InfraStructure.Service;
using FiboParty.Infrastructure.Assembler;
using FiboParty.Infrastructure.Repository;
using FiboParty.Infrastructure.Service;
using FiboUser.InfraStructure;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Payroll.InfraStructure.Assembler;
using Payroll.InfraStructure.Repository;
using Payroll.InfraStructure.Service;
using System;

namespace FiboCounterSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IAuthorizationPolicyProvider, PermissionPolicyProvider>();
            services.AddScoped<IAuthorizationHandler, PermissionAuthorizationHandler>();
            services.AddDbContext<ApplicationDbContext>(options =>
                   options.UseSqlServer(Configuration.GetConnectionString("CounterBilling"), x => x.MigrationsAssembly("FiboInfraStructure")));
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromHours(24);
            });
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            services.AddTransient<IProvienceRepository, ProvienceRepository>();
            services.AddTransient<IProvienceAssembler, ProvienceAssembler>();
            services.AddTransient<IProvienceService, ProvienceService>();

            services.AddTransient<IDistrictRepository, DistrictRepository>();
            services.AddTransient<IDistrictAssembler, DistrictAssembler>();
            services.AddTransient<IDistrictService, DistrictService>();

            services.AddTransient<ILocalLevelRepository, LocalLevelRepository>();
            services.AddTransient<ILocalLevelAssembler, LocalLevelAssembler>();
            services.AddTransient<ILocalLevelService, LocalLevelService>();

            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeAssembler, EmployeeAssembler>();
            services.AddTransient<IEmployeeService, EmployeeService>();

            services.AddTransient<IBranchRepository, BranchRepository>();
            services.AddTransient<IBranchAssembler, BranchAssembler>();
            services.AddTransient<IBranchService, BranchService>();

            services.AddTransient<IFiscalYearRepository, FiscalYearRepository>();
            services.AddTransient<IFiscalYearAssembler, FiscalYearAssembler>();
            services.AddTransient<IFiscalYearService, FiscalYearService>();


            services.AddTransient<IOfficeRepository, OfficeRepository>();
            services.AddTransient<IOfficeAssembler, OfficeAssembler>();
            services.AddTransient<IOfficeService, OfficeService>();

            services.AddTransient<IMeasuringUnitAssembler, MeasuringUnitAssembler>();
            services.AddTransient<IMeasuringUnitRepository, MeasuringUnitRepository>();
            services.AddTransient<IMeasuringUnitService, MeasuringUnitService>();
            
            services.AddTransient<IItemAssembler, ItemAssembler>();
            services.AddTransient<IItemRepository, ItemRepository>();
            services.AddTransient<IItemService, ItemService>();

            services.AddTransient<IInventoryAssembler, InventoryAssembler>();
            services.AddTransient<IInventoryRepository, InventoryRepository>();
            services.AddTransient<IInventoryService, InventoryService>();

            services.AddTransient<IProductCategoryAssembler, ProductCategoryAssembler>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddTransient<IProductCategoryService, ProductCategoryService>();

            services.AddTransient<IProductSubCategoryAssembler, ProductSubCategoryAssembler>();
            services.AddTransient<IProductSubCategoryRepository, ProductSubCategoryRepository>();
            services.AddTransient<IProductSubCategoryService, ProductSubCategoryService>();

            services.AddTransient<IProductAssembler, ProductAssembler>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProductService, ProductService>();

            services.AddTransient<IBillingAssembler, BillingAssembler>();
            services.AddTransient<IBillingRepository, BillingRepository>();
            services.AddTransient<IBillingService, BillingService>();

            services.AddTransient<IBillingInfoAssembler, BillingInfoAssembler>();
            services.AddTransient<IBillingInfoRepository, BillingInfoRepository>();
            services.AddTransient<IBillingInfoService, BillingInfoService>();

            services.AddTransient<IPettyCashFundAssembler, PettyCashFundAssembler>();
            services.AddTransient<IPettyCashFundRepository,PettyCashFundRepository >();
            services.AddTransient<IPettyCashFundService, PettyCashFundService>();


            services.AddTransient<ITableAssembler, TableAssembler>();
            services.AddTransient<ITableRepository, TableRepository>();
            services.AddTransient<ITableService, TableService>();

            services.AddTransient<IIngredientRepository, IngredientRepository>();
            services.AddTransient<IIngredientService, IngredientService>();
            services.AddTransient<IIngredientAssembler, IngredientAssembler>();

            services.AddTransient<IInventorySummaryRepository, InventorySummaryRepository>();
            services.AddTransient<IInventorySummaryService, InventorySummaryService>();
            services.AddTransient<IInventorySummaryAssembler, InventorySummaryAssembler>();

            services.AddTransient<ITaxRepository, TaxRepository>();
            services.AddTransient<ITaxService, TaxService>();
            services.AddTransient<ITaxAssembler, TaxAssembler>();

            services.AddTransient<IServiceChargeRepository, ServiceChargeRepository>();
            services.AddTransient<IServiceChargeService, ServiceChargeService>();
            services.AddTransient<IServiceChargeAssembler, ServiceChargeAssembler>();
            
            services.AddTransient<IUserAndBranchInfo, UserAndBranchInfo>();

            services.AddTransient<IVendorRepository, VendorRepository>();
            services.AddTransient<IVendorService, VendorService>();
            services.AddTransient<IVendorAssembler, VendorAssembler>();

            services.AddTransient<IMonthRepository, MonthRepository>();
            services.AddTransient<IYearRepository, YearRepository>();

            services.AddTransient<IStockAdjustmentRepository, StockAdjustmentRepository>();
            services.AddTransient<IStockAdjustmentService, StockAdjustmentService>();
            services.AddTransient<IStockAdjustmentAssembler, StockAdjustmentAssembler>();

            services.AddTransient<IStockAdjustmentDetailRepository, StockAdjustmentDetailRepository>();
            services.AddTransient<IStockAdjustmentDetailService, StockAdjustmentDetailService>();
            services.AddTransient<IStockAdjustmentDetailAssembler, StockAdjustmentDetailAssembler>();

            services.AddTransient<IRoomSetupRepository, RoomSetupRepository>();
            services.AddTransient<IRoomSetupService, RoomSetupService>();
            services.AddTransient<IRoomSetupAssembler, RoomSetupAssembler>();

            services.AddTransient<IRoomCheckInRepository, RoomCheckInRepository>();
            services.AddTransient<IRoomCheckInService, RoomCheckInService>();
            services.AddTransient<IRoomCheckInAssembler, RoomCheckInAssembler>();

            services.AddTransient<IPartyRepository, PartyRepository>();
            services.AddTransient<IPartyService, PartyService>();
            services.AddTransient<IPartyAssembler, PartyAssembler>();

            services.AddTransient<ILedgerRepository, LedgerRepository>();
            services.AddTransient<ILedgerService, LedgerService>();
            services.AddTransient<ILedgerAssembler, LedgerAssembler>();

            services.AddTransient<ILedgerDetailRepository, LedgerDetailRepository>();
            services.AddTransient<ILedgerDetailService, LedgerDetailService>();
            services.AddTransient<ILedgerDetailAssembler, LedgerDetailAssembler>();

            services.AddTransient<IPostRepository, PostRepository>();
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<IPostAssembler, PostAssembler>();

            services.AddTransient<ISalarySheetRepository, SalarySheetRepository>();
            services.AddTransient<ISalarySheetService, SalarySheetService>();
            services.AddTransient<ISalarySheetAssembler, SalarySheetAssembler>();

            services.AddTransient<INotificationRepository, NotificationRepository>();
            services.AddTransient<INotificationService, NotificationService>();
            services.AddTransient<INotificationAssembler, NotificationAssembler>();

            services.AddTransient<ILodgeBillingRepository, LodgeBillingRepository>();
            services.AddTransient<ILodgeBillingService, LodgeBillingService>();
            services.AddTransient<ILodgeBillingAssembler, LodgeBillingAssembler>();

            services.AddTransient<IUserBranchRepository, UserBranchRepository>();
            services.AddTransient<IUserBranchService, UserBranchService>();

            services.AddTransient<IExpenseRepository, ExpenseRepository>();
            services.AddTransient<IExpenseService, ExpenseService>();
            services.AddTransient<IExpenseAssembler, ExpenseAssembler>();

            services.AddTransient<IExpenseDetailRepository, ExpenseDetailRepository>();
            services.AddTransient<IExpenseDetailService, ExpenseDetailService>();
            services.AddTransient<IExpenseDetailAssembler, ExpenseDetailAssembler>();

            services.AddTransient<IDayCashBookRepository, DayCashBookRepository>();
            services.AddTransient<IDayCashBookService, DayCashBookService>();
            services.AddTransient<IDayCashBookAssembler, DayCashBookAssembler>();

            services.AddTransient<IBillingStatusAssembler, BillingStatusAssembler>();
            services.AddTransient<IBillingStatusRepository, BillingStatusRepository>();
            services.AddTransient<IBillingStatusService, BillingStatusService>();

            services.AddTransient<IOpeningClosingAssembler, OpeningClosingAssembler>();
            services.AddTransient<IOpeningClosingRepository, OpeningClosingRepository>();
            services.AddTransient<IOpeningClosingService, OpeningClosingService>();

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.User.RequireUniqueEmail = false;
            })
           .AddEntityFrameworkStores<ApplicationDbContext>()
           .AddDefaultTokenProviders();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/login";
                options.Cookie.IsEssential = true;
                options.SlidingExpiration = true; // here 1
                options.ExpireTimeSpan = TimeSpan.FromSeconds(10);// here 2
            });


            services.AddHttpContextAccessor();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}
