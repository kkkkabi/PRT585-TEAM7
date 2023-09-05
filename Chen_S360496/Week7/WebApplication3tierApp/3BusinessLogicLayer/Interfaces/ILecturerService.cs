using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BusinessLogicLayer.Interfaces
{
    public interface ILecturerService
    {
        Task<LecturerModel?> GetById(int LecturerId);
        Task<List<LecturerModel>> GetAll();

        Task<int> CreateLecturer(LecturerModel Lecturer);
        Task UpdateLecturer(LecturerModel Lecturer);
        Task DeleteLecturer(int LecturerId);
    }
}
