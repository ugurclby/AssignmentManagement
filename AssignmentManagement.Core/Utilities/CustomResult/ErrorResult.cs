using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManagement.Core.Utilities.CustomResult
{
    public class ErrorResult:Result
    {
        public ErrorResult(bool success, string message) : base(success, message)
        {
        }

        public ErrorResult(bool success) : base(success)
        {
        }
    }
}
