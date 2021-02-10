using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Data: ürün, ürünler, kategori vs. olabilir.
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
