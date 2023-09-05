using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IDepartmentDal
    {
        // Getters
        DepartmentModel? GetById(int DepartmentId);
        List<DepartmentModel> GetAll();

        // Actions
        int CreateDepartment(DepartmentModel Department);
        void UpdateDepartment(DepartmentModel Department);
        void DeleteDepartment(int DepartmentId);
    }
}
