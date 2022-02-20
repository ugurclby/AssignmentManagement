using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentManagement.Core.DataAccess.UnitOfWorks;
using AssignmentManagement.DataAccess.Concrete.EntityFramework.Context;

namespace AssignmentManagement.DataAccess.Concrete.UnitOfWorks
{
    public class UnitOfWork:IUnitOfWork
    {
        protected  readonly  AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task CommitAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }

        public void Commit()
        {
            _appDbContext.SaveChanges();
        }
    }
}
