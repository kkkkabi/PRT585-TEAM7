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
    public class LecturerDal : ILecturerDal
    {
        //private readonly TestDBEntities context;
        private DBEntitiesContext _db;
        public LecturerDal(DBEntitiesContext dbctx)
        {
            this._db = dbctx; // new TestDBEntities();
        }


        public List<LecturerModel> GetAll()
        {
            var result = _db.Lecturers.ToList();

            var returnObject = new List<LecturerModel>();
            foreach (var item in result)
            {
                returnObject.Add(item.ToLecturerModel());
            }

            return returnObject;
        }

        public LecturerModel? GetById(int LecturerId)
        {
            var result = _db.Lecturers.SingleOrDefault(x => x.LecturerId == LecturerId);
            return result?.ToLecturerModel();
        }


        public int CreateLecturer(LecturerModel Lecturer)
        {
            var newLecturer = Lecturer.ToLecturer();
            _db.Lecturers.Add(newLecturer);
            _db.SaveChanges();
            return newLecturer.LecturerId;
        }


        public void UpdateLecturer(LecturerModel Lecturer)
        {
            var existingLecturer = _db.Lecturers
                .SingleOrDefault(x => x.LecturerId == Lecturer.LecturerId);

            if (existingLecturer == null)
            {
                throw new ApplicationException($"Lecturer {Lecturer.LecturerId} does not exist.");
            }
            Lecturer.ToLecturer(existingLecturer);

            _db.Update(existingLecturer);
            _db.SaveChanges();
        }

        public void DeleteLecturer(int LecturerId)
        {
            var efModel = _db.Lecturers.Find(LecturerId);
            _db.Lecturers.Remove(efModel);
            _db.SaveChanges();


        }

    }

}
