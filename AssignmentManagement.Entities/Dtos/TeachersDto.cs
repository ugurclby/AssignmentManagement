using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentManagement.Core.Entities.Abstract;

namespace AssignmentManagement.Entities.Dtos
{
    public class TeachersDto : IDto
    {
        public int Id { get; set; }
        public string Teacher_Name { get; set; }
        public string Teacher_SurName { get; set; }
        public int Status { get; set; }

    } 
} 