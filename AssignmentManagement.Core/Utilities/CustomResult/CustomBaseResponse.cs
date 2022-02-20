using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentManagement.Core.Utilities.CustomResult
{
    public class CustomBaseResponse:ICustomBaseResponse
    { 

        public CustomBaseResponse(string message,bool success)
        {
            Success = success;
            Message = message;
        }
        //public CustomBaseResponse(bool success,string message,T data)
        //{
        //    Success = success;
        //    Message = message;
        //    Data = data;
        //} 
        
        public bool Success { get; set; }
        public string Message { get; set; }
    }
    public class CustomBaseDataResponse<T> : ICustomBaseResponse
    {

        public CustomBaseDataResponse(IDataResult<T> result)
        {
            Success = result.Success;
            Message = result.Message;
            Data = result.Data;
        }
        //public CustomBaseResponse(bool success,string message,T data)
        //{
        //    Success = success;
        //    Message = message;
        //    Data = data;
        //} 
        public T Data;
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
