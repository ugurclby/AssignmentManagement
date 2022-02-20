using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentManagement.Core.Entities.Abstract;

namespace AssignmentManagement.Entities.Concrete
{
    public class Teachers : IDbTable
    {
        public int Id { get; set; }
        public string Teacher_Name { get; set; }
        public string Teacher_SurName { get; set; }
        public int Status { get; set; }

    } 
} 