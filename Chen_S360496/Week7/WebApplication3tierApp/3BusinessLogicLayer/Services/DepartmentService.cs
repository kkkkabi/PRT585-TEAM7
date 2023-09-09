

using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;

namespace _3BusinessLogicLayer.Services
{
    public class DepartmentService :  IDepartmentService
    {
        private readonly IDepartmentDal _DepartmentDal;
        //private readonly IDepartmentBalService _DepartmentBalService;
        public DepartmentService(IDepartmentDal DepartmentDal
        //ILoggingService loggingService,
        //IDepartmentDal DepartmentDal,
        //IAuditDal auditDal
       // IDepartmentBalanceService balsvc
        ) 
        {
            _DepartmentDal = DepartmentDal;
            // _DepartmentBalService = balsvc;
        }

        public async Task<DepartmentModel?> GetById(int DepartmentId)
        {           
            return _DepartmentDal.GetById(DepartmentId);
        }

        public async Task<List<DepartmentModel>> GetAll()
        {            
            return _DepartmentDal.GetAll();
        }

        public async Task<int> CreateDepartment(DepartmentModel Department)
        {
            //write validations here
            var newDepartmentId = _DepartmentDal.CreateDepartment(Department);
            return newDepartmentId;
        }

        public async Task UpdateDepartment(DepartmentModel Department)
        {
            //write validations here 
            _DepartmentDal.UpdateDepartment(Department);
        }

        public async Task DeleteDepartment(int DepartmentId)
        {            
            try
            {
                //if(balservice.getBal(DepartmentId) = 0)
                _DepartmentDal.DeleteDepartment(DepartmentId);
            }
            catch (Exception e)
            {
                //_loggingService.WriteLog(LoggingLevel.Error, "Layer", $"Error delete Department Id:{DepartmentId}. {e.Message}", e.StackTrace);
            }
        }
    }
}
