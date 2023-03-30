using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Entities.ResultModels
{
    public class Result : IResult
    {
        //diğer versiyonlar 
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public Result(bool success)
        {
            IsSuccess = success;
        }

        // Extension metod
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }


    }
}
