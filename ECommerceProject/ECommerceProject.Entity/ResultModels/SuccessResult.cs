using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Entities.ResultModels
{
   public class SuccessResult:Result
    {
        public SuccessResult(bool success=true):base(success)
        {

        }

        public SuccessResult(string message):base(true,message)
        {

        }

    }
}
