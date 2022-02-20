using AssignmentManagement.Core.Utilities.CustomResult;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc; 

namespace AssignmentManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        [NonAction]
        //public IActionResult CreateActionResult<T>(CustomBaseResponse<T> result)
        //{ 
        //    return new ObjectResult(result);
        //}
        public IActionResult CreateActionResult(ICustomBaseResponse result)
        {
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
             
        }
    }
}
