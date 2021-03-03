using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        // verdiğimiz password'un hash'ini oluşturan operasyon
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512()) //hmac: kriptografi sınıfında kullandığımız class'tır
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)); // string'in byte karşılığını almak için böyle yazdık
            }
        }

        // password hash'i doğrulama operasyonu
        // sonradan sisteme girmek isteyen kişinin password'un bizim verikaynağımızdaki hash ile ilgili
        //salt'a göre eşleşip eşleşmediğini verdiğimiz yer
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)); //computedHash: hesaplanan hash
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
