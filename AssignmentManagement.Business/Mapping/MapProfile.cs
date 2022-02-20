using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentManagement.Entities.Concrete;
using AssignmentManagement.Entities.Dtos;
using AutoMapper;

namespace AssignmentManagement.Business.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<AssignmentsDto, Assignments>().ReverseMap();
            CreateMap<Student_AssignmentsDto, Student_Assignments>().ReverseMap();
            CreateMap<Student_ClassesDto, Student_Classes>().ReverseMap();
            CreateMap<StudentsDto, Students>().ReverseMap();
            CreateMap<TeachersDto, Teachers>().ReverseMap();
        }
    }
}
