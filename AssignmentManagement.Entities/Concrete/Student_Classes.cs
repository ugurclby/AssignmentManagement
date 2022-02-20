using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentManagement.Core.Entities.Abstract;

namespace AssignmentManagement.Entities.Concrete
{
    public class Student_Classes: IDbTable
    {
        public int Id { get; set; }
        public string Class_Name { get; set; }
        public int Status { get; set; }

    } 
}  