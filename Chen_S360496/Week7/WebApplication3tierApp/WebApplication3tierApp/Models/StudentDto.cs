using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class DepartmentDto
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
                        
    }

    public static class DepartmentDtoMapExtensions
    {
        public static DepartmentDto ToDepartmentDto(this DepartmentModel src)
        {
            var dst = new DepartmentDto();
            dst.DepartmentId = src.DepartmentId;
            dst.DepartmentName = src.DepartmentName;            
            return dst;
        }

        public static DepartmentModel ToDepartmentModel(this DepartmentDto src)
        {
            var dst = new DepartmentModel();
            dst.DepartmentId = src.DepartmentId;
            dst.DepartmentName = src.DepartmentName;            
            return dst;
        }
    }
}
