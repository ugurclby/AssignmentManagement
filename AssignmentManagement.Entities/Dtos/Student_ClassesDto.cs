using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentManagement.Core.Entities.Abstract;

namespace AssignmentManagement.Entities.Dtos
{
    public class Student_ClassesDto: IDto
    {
        public int Id { get; set; }
        public string Class_Name { get; set; }
        public int Status { get; set; }

    } 
}  