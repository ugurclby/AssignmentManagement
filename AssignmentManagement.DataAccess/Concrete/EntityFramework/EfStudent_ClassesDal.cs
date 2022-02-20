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
    public class EfStudent_ClassesDal : EfGenericRepositoryBase<Student_Classes>, IStudent_ClassesDal
    {
        public EfStudent_ClassesDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
