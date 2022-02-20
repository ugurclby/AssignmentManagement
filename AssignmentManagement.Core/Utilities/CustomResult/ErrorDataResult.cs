using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManagement.Core.Utilities.CustomResult
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T Data, bool success, string message) : base(Data, success, message)
        {
        }

        public ErrorDataResult(T Data, bool success) : base(Data, success)
        {
        }
    }
}
