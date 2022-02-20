using System.Collections;
using AssignmentManagement.Business.Abstract;
using AssignmentManagement.Core.Utilities.CustomResult;
using AssignmentManagement.Entities.Concrete;
using AssignmentManagement.Entities.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentManagement.Api.Controllers
{
    public class StudentController : CustomBaseController
    {
        private readonly IService<Students, StudentsDto> _service;
        private readonly IMapper _mapper;


        public StudentController(IService<Students, StudentsDto> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var studentsResult = await _service.GetAllAsync(null);

            if (studentsResult.Success)
            {
                return Ok(studentsResult);
            }
            else
            {
                return BadRequest(studentsResult);
            }

            //return CreateActionResult(
            //    new CustomBaseDataResponse<List<StudentsDto>>(studentsSonuc.Message, studentsSonuc.Success, studentsdto));


            //return CreateActionResult(new CustomBaseResponse<List<StudentsDto>>(true,"Başarılı",studentsdto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var studentsResult = await _service.GetAsync(x => x.Id == id);
            if (studentsResult.Success)
            {
                return Ok(studentsResult);
            }
            else
            {
                return BadRequest(studentsResult);
            }
        }
        /// <summary>
        /// Tek Kayıt Insert
        /// </summary>
        /// <param name="studentsDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add(StudentsDto studentsDto)
        {
            var result = await _service.AddAsync(studentsDto);
            if (result.Success)
            {
                return Created("", result);

            }
            else
            {
                return BadRequest(result);
            }
        }
        /// <summary>
        /// Liste Kayıt Insert
        /// </summary>
        /// <param name="studentsDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddRange")]
        public async Task<IActionResult> Add(List<StudentsDto>  studentsDto)
        {
            var result = await _service.AddRangeAsync(studentsDto);
            if (result.Success)
            {
                return Created("", result);

            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPut]
        public IActionResult Update(Students studentsDto)
        {
            var updateKontrol = UpdateControl(studentsDto); 

            var result = _service.Update(updateKontrol);
            if (result.Success)
            {
                return Ok(result);

            }
            else
            {
                return BadRequest(result);
            }

        }
        [NonAction]
        /// <summary>
        /// Ürünlerin update edilmeden önceki kontrolü
        /// </summary>
        /// <returns></returns>
        public Students UpdateControl(Students studentsDto)
        {
            var resultStudent = _service.Get(x => x.Id == studentsDto.Id);
            if (resultStudent.Data != null)
            {
                List<string> formcollist = new List<string>();
                foreach (var key in studentsDto.GetType().GetProperties())
                {
                    var sonuc = key.GetValue(studentsDto, null).ToString();
                    if (!String.IsNullOrEmpty(sonuc) && sonuc != "0")
                    {
                        formcollist.Add(key.Name);
                    }
                }
                foreach (var prop in resultStudent.Data.GetType().GetProperties())
                {
                    if (formcollist.Contains(prop.Name))
                    {
                        prop.SetValue(resultStudent.Data, studentsDto.GetType().GetProperty(prop.Name).GetValue(studentsDto, null));
                    }
                }
            }

            return resultStudent.Data;

        }

    }
}
