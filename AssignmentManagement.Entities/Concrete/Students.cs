using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentManagement.Core.Entities.Abstract;

namespace AssignmentManagement.Entities.Concrete
{
    public class Students: IDbTable
    {
        public int Id { get; set; }
        public string Student_Name { get; set; }
        public string Student_SurName { get; set; }
        public int Student_Class_Id { get; set; }
        public int Status { get; set; }

    } 
} 