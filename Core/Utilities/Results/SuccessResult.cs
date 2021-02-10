using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // base (Result demek burada
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message)
        {

        }

        public SuccessResult() : base(true)
        {

        }
    }
}
