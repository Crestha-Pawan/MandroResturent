using FiboInfraStructure.Data;
using FiboOffice.InfraStructure.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FiboInfraStructure.BaseInfraStructure
{
    public interface IUserAndBranchInfo
    {
        Task<long> getCurrentUser();
        Task<long> getCurrentBranch();
    }

    public class UserAndBranchInfo : IUserAndBranchInfo
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserAndBranchInfo(UserManager<ApplicationUser> userManager
            , IEmployeeRepository employeeRepository
            , IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _employeeRepository = employeeRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<long> getCurrentBranch()
        {
            long branchId = 0;
            var currentUser = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            var employee = await _employeeRepository.GetEmployee(currentUser.Email);
            if (employee != null)
            {
                if (employee.BranchId.HasValue)
                {
                    branchId = employee.BranchId.Value;
                }
            }
            return branchId;
        }

        public async Task<long> getCurrentUser()
        {
            long employeeId = 0;
            var currentUser = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            var employee = await _employeeRepository.GetEmployee(currentUser.Email);
            if (employee != null)
            {
                employeeId = employee.Id;
            }
            return employeeId;
        }

    }
}
