using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface IDepartmentService
    {
        Task<DepartmentModel?> GetById(int DepartmentId);
        Task<List<DepartmentModel>> GetAll();

        Task<int> CreateDepartment(DepartmentModel Department);
        Task UpdateDepartment(DepartmentModel Department);
        Task DeleteDepartment(int DepartmentId);
    }
}
