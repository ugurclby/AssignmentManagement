using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentManagement.Core.Entities.Abstract;

namespace AssignmentManagement.Entities.Dtos
{
    public class StudentsDto: IDto
    {
        [DisplayName("Öğrenci No")]
        public int Id { get; set; }
        public string Student_Name { get; set; }
        public string Student_SurName { get; set; }
        public int Student_Class_Id { get; set; }
        //public int Status { get; set; }

    } 
} 