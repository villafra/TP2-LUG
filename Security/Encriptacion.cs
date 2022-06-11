using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Security
{
    public static class Encriptacion
    {
        public static string EncriptarPass(string pass)
        {
            try
            {
                string key = "restó";
                byte[] keyArray;
                byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(pass);

                SHA1CryptoServiceProvider SHA = new SHA1CryptoServiceProvider();
                keyArray = SHA.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                SHA.Clear();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tdes.CreateEncryptor();
                byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);
                tdes.Clear();

                pass = Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);
            }
            catch (Exception)
            {

            }
                return pass;
		}

        public static string DesencriptarPass(string pass)
        {
            try
            {
                string key = "restó";
                byte[] keyArray;
                byte[] Array_a_Descifrar = Convert.FromBase64String(pass);

                SHA1CryptoServiceProvider SHA = new SHA1CryptoServiceProvider();
                keyArray = SHA.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                SHA.Clear();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);
                tdes.Clear();
                pass = UTF8Encoding.UTF8.GetString(resultArray);

            }
            catch (Exception)
            {

            }
            return pass;
        }
    }
}
