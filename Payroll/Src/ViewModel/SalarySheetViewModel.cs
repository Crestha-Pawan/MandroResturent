using FiboInfraStructure.Entity.FiboOffice;
using FiboInfraStructure.Entity.Payroll;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Src.ViewModel
{
     public class SalarySheetViewModel
    {
        public List<SalarySheet> SalarySheets{ get; set; }
        public List<Employee> Employeee { get; set; }
        [NotMapped]
        public DateTime? FromDate { get; set; }
        [NotMapped]
        public DateTime? ToDate { get; set; }
        [NotMapped]
        public string FromMiti { get; set; }
        [NotMapped]
        public string ToMiti { get; set; }
        [ForeignKey("EmployeeId")]
        public long? EmployeeId { get; set; }
       
        public IList<Employee> Employees { get; set; } = new List<Employee>();
        public SelectList EmployeeList => new SelectList(Employees, nameof(Employee.Id), nameof(Employee.Name));

    }
}
