using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        
        //this: this bu class demektir. bu classtaki tek parametreli ctor`u da iki
        //iki parametreli ctor ile birlikte calistirdik
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
                Success = success;
        }

        public bool Success { get; }
        //get = readonlydir. Constructorda set edilebilirler.
        public string Message { get; }
    }
}
