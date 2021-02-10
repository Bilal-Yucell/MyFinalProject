using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{

    public class Result : IResult
    {
        // getter readonly'dir, readonly'ler constructor'da set edilebilir.
        // this : bulunduğu class demek yani Result.
        public Result(bool success, string message) : this(success) // Result'un tek parametreli constructor'ına 
                                                                    // success'ı yolla demek
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
