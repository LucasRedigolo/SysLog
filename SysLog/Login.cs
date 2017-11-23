using System;

namespace SysLog {
    public class Login {
        public string Email { get; set; }
        public string Senha { get; set; }
        public Login () {

        }
        public Login (string Email, string Senha) {
            this.Email = Email;
            this.Senha = Senha;
        }
        public void Logar () {
            System.Console.WriteLine ("Insira seu email:");
            Email = Console.ReadLine ();
            System.Console.WriteLine ("Insira sua senha:");
            Senha = Console.ReadLine ();
        }
    }
}