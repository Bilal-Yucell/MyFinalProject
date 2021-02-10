using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // default dataya karşılık geliyor.
    // son 2 constructor çok sık kullanılmaz fakat alternatif yöntemlerin kullanılabilmesi için yazdık
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }

        public SuccessDataResult(T data) : base(data, true)
        {

        }

        public SuccessDataResult(string message) : base(default, true, message)
        {

        }

        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
