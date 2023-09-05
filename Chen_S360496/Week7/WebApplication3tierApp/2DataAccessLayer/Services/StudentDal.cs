using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context;
using _2DataAccessLayer.Context.Models;
using _2DataAccessLayer.Interfaces;
using _2DataAccessLayer.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Services
{
    public class DepartmentDal : IDepartmentDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public DepartmentDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<DepartmentModel> GetAll()
        {
            var result = _db.Departments.ToList();

            var returnObject = new List<DepartmentModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToDepartmentModel());
            }

            return returnObject;
        }

        public DepartmentModel? GetById(int DepartmentId)
        {
            var result = _db.Departments.SingleOrDefault(x => x.DepartmentId == DepartmentId);
            return result?.ToDepartmentModel();
        }


        public int CreateDepartment(DepartmentModel Department)
        {
            var newDepartment = Department.ToDepartment();
            _db.Departments.Add(newDepartment);
            _db.SaveChanges();
            return newDepartment.DepartmentId;
        }


        public void UpdateDepartment(DepartmentModel Department)
        {
            var existingDepartment = _db.Departments
                .SingleOrDefault(x => x.DepartmentId == Department.DepartmentId);

            if (existingDepartment == null)
            {
                throw new ApplicationException($"Department {Department.DepartmentId} does not exist.");
            }
            Department.ToDepartment(existingDepartment);

            _db.Update(existingDepartment);
            _db.SaveChanges();
        }

        public void DeleteDepartment(int DepartmentId)
        {
            var efModel = _db.Departments.Find(DepartmentId);
            _db.Departments.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
