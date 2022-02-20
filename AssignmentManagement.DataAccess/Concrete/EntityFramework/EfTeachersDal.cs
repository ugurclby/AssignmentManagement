using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentManagement.Core.DataAccess.EntityFramework;
using AssignmentManagement.DataAccess.Abstract;
using AssignmentManagement.DataAccess.Concrete.EntityFramework.Context;
using AssignmentManagement.Entities.Concrete;

namespace AssignmentManagement.DataAccess.Concrete.EntityFramework
{
    public class EfTeachersDal : EfGenericRepositoryBase<Teachers>, ITeachersDal
    {
        public EfTeachersDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
