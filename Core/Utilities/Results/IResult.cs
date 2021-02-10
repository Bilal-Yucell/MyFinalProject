using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Temel void'ler için başlangıç. Void yerine IResult yazıyoruz artık
    // sadece get yazdık (get okumak için kullanılır, set de yazmak için kullanılır), 
    // set etmeyi constructor'da yapabiliriz
    public interface IResult
    {
        bool Success { get; } // yapmaya çalışılan işlem başarılı mı başarısız mı kontrol eder
        string Message { get; } // yapmaya çalışılan işlem başarılı mı başarısız mı onu gösterir (ekrana)
    }
}
