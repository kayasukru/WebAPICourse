using Entities.Models;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDto> GetAllEmployeesByProjectId(Guid projectId, bool trackChanges);
        EmployeeDto GetOneEmployeeByProjectId(Guid projectId, Guid employeeId, bool trackChanges);
        EmployeeDto CreateOneEmployeeByProjectId(Guid projectId, EmployeeDtoForCreation employeeDto, bool trackChanges);
    }
}
