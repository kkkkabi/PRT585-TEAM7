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
    public static class DepartmentMapExtensions
    {
        public static DepartmentModel ToDepartmentModel(this Department src)
        {
            var dst = new DepartmentModel();

            dst.DepartmentId = src.DepartmentId;
            dst.DepartmentName = src.DepartmentName;

            return dst;
        }

        public static Department ToDepartment(this DepartmentModel src, Department dst = null)
        {
            if (dst == null)
            {
                dst = new Department();
            }

            dst.DepartmentId = src.DepartmentId;
            dst.DepartmentName = src.DepartmentName;

            return dst;
        }
    }
}
