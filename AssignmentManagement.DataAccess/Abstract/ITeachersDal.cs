using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentManagement.Core.DataAccess;
using AssignmentManagement.Entities.Concrete;

namespace AssignmentManagement.DataAccess.Abstract
{
    public interface ITeachersDal : IGenericRepositoryBase<Teachers>
    {
    }
}
