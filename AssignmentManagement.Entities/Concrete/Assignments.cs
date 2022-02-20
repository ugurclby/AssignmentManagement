using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentManagement.Core.Entities.Abstract;

namespace AssignmentManagement.Entities.Concrete
{
    public class Assignments: IDbTable
    {
        public int Id { get; set; }
        public string Assignment_Name { get; set; }
        public string Assignment_Explanation { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Expired_Date { get; set; }
        public int Created_Teacher { get; set; }
        public int Status { get; set; }

    } 
}  