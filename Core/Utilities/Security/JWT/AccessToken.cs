using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken // AccessToken: Anlamsız karakterlerden oluşan anahtar değeridir
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; } // Verilen Token/Jeton'un biteceği tarih. Expiration: süre sonu
    }
}
