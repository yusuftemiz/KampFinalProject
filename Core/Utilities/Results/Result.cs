using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success) //bu classın(result) tek success alan constructor ını da çalıştır.
        {
            Message = message;
            //set olmasa da constructor içinde set yapabiliyoruz.
        }
        public Result(bool success)
        {
            Success = success;
            //set olmasa da constructor içinde set yapabiliyoruz.
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
