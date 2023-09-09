using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
    public class LecturerDto
    {
        public int LecturerId { get; set; }
        public string LecturerName { get; set; }
                        
    }

    public static class LecturerDtoMapExtensions
    {
        public static LecturerDto ToLecturerDto(this LecturerModel src)
        {
            var dst = new LecturerDto();
            dst.LecturerId = src.LecturerId;
            dst.LecturerName = src.LecturerName;            
            return dst;
        }

        public static LecturerModel ToLecturerModel(this LecturerDto src)
        {
            var dst = new LecturerModel();
            dst.LecturerId = src.LecturerId;
            dst.LecturerName = src.LecturerName;            
            return dst;
        }
    }
}
