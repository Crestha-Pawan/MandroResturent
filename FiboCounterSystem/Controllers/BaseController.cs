using FiboInfraStructure.Data;
using FiboOffice.InfraStructure.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiboCounterSystem.Controllers
{
    public class BaseController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmployeeRepository _employeeRepository;
        public BaseController(UserManager<ApplicationUser> userManager, IEmployeeRepository employeeRepository)
        {
            _userManager = userManager;
            _employeeRepository = employeeRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<long> getUser()
        {
            long employeeId = 0;

            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            var employee = await _employeeRepository.GetEmployee(currentUser.Email);
            if (employee != null)
            {
                employeeId = employee.Id;
            }
            return employeeId;
        }
    }
}
