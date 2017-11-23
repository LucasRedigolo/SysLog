using System;
using System.Security.Cryptography;
using System.Text;

namespace SysLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static string encripSenha(string senha)
        {
            byte[] senhaOriginal; // um array de bytes da senha original
            byte[] senhaModificada;
            MD5 mD5; // metodo de criptografia usando o Security.Criptography

            senhaOriginal = Encoding.Default.GetBytes(senha); // pega os bytes da senha e grana no array senhaOriginal
            mD5 = MD5.Create(); 
            senhaModificada= mD5.ComputeHash(senhaOriginal); // transforma a senha original na criptografia e joga dentro da senhaModificada

            return Convert.ToBase64String(senhaModificada); // return a senhaModificada convertida pra string (to base pq é uma array e pra manter a array inteira na mesma string)
        }
    }
}
