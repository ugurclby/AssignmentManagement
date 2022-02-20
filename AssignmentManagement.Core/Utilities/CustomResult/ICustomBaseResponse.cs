using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManagement.Core.Utilities.CustomResult
{
    public interface ICustomBaseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; } 
    }
}
