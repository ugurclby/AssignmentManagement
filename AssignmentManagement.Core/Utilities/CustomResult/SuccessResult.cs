using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManagement.Core.Utilities.CustomResult
{
    public class SuccessResult:Result
    {
        public SuccessResult(bool success, string message) : base(success, message)
        {
        }

        public SuccessResult(bool success) : base(success)
        {
        }
    }
}
