using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentManagement.Core.Entities.Abstract;

namespace AssignmentManagement.Entities.Dtos
{ 
    public class Student_AssignmentsDto : IDto
    {
        public int Id { get; set; }
        public int Student_Id { get; set; }
        public int Assignment_Id { get; set; }
        public int Mark { get; set; }
        public int Status { get; set; } 
        public string Teacher_FeedBack { get; set; }
        public string Student_FeedBack { get; set; }  
    }

}  