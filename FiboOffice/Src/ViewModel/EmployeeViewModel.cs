using FiboInfraStructure.Entity.FiboOffice;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiboOffice.Src.ViewModel
{
    public class EmployeeViewModel
    {
        public string Status { get; set; }
        public virtual List<Employee> Employees { get; set; }
        public string Name { get; set; }
    }
}
