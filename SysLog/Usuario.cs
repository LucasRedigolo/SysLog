using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SysLog {
    public class Usuario {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario () {

        }

        public Usuario (string Nome, string Email, string Senha) {
            this.Nome = Nome;
            this.Email = Email;
            this.Senha = Senha;
        }
        public void CadastrarUsuario () {

            System.Console.WriteLine ("Bem vindo ao cadastro de usuário!!\n");
            System.Console.WriteLine ("Insira o nome do novo usuário:");
            Nome = Console.ReadLine ();

            Console.WriteLine ("Qual o seu email?");
            Email = Console.ReadLine ();

            System.Console.WriteLine ("Qual a sua senha?");
            Senha = encripSenha(Console.ReadLine ());

            StreamWriter arquivo = new StreamWriter ("cadUsuario.txt", true);
            arquivo.WriteLine (Nome + "; " + Email + "; " + Senha);
            arquivo.Close ();
        }
        public static string encripSenha (string senha) {

            byte[] senhaOriginal; // um array de bytes da senha original
            byte[] senhaModificada;
            SHA512 sHA512; // classe de criptografia usando o Security.Criptography

            senhaOriginal = Encoding.Default.GetBytes (senha); // pega os bytes da senha e grana no array senhaOriginal
            sHA512 = SHA512.Create ();
            senhaModificada = sHA512.ComputeHash (senhaOriginal); // transforma a senha original na criptografia e joga dentro da senhaModificada

            return Convert.ToBase64String (senhaModificada); // return a senhaModificada convertida pra string (to base pq é uma array e pra manter a array inteira na mesma string)
        }
    }
}