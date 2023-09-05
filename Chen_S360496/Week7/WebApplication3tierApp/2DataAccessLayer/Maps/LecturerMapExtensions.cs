using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Maps
{
    public static class LecturerMapExtensions
    {
        public static LecturerModel ToLecturerModel(this Lecturer src)
        {
            var dst = new LecturerModel();

            dst.LecturerId = src.LecturerId;
            dst.LecturerName = src.LecturerName;

            return dst;
        }

        public static Lecturer ToLecturer(this LecturerModel src, Lecturer dst = null)
        {
            if (dst == null)
            {
                dst = new Lecturer();
            }

            dst.LecturerId = src.LecturerId;
            dst.LecturerName = src.LecturerName;

            return dst;
        }
    }
}
