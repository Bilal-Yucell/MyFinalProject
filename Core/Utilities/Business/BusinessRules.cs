using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    //params verdiğimiz için Run içine istediğimiz kadar IResult parametresi verebiliyoruz.
    // C# arkaplanda gönderilen parametreleri array haline getirip IResult[]'a atıyor.
    // 17. satırda: parametre ile gönderdiğimiz iş kurallarından başarısız olanı yani kurala uymayanı döndürüyoruz, 
    // business'a haber veriyoruz.
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) //Run: Çalıştır anlamında. logics: iş kuralları anlamında
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
