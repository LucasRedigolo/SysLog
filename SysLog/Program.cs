using System;
using System.Security.Cryptography;
using System.Text;

namespace SysLog {
    class Program {
        static void Main (string[] args) {
            string opcao = "";

            //Menu principal 
            do {
                Console.WriteLine ("Digite a opção");
                Console.WriteLine ("1 - Cadastrar Usuario");
                Console.WriteLine ("2 - Login");
                Console.WriteLine ("3 - Logout");
                Console.WriteLine ("9 - Sair");

                opcao = Console.ReadLine ();

                switch (opcao) {
                    case "1":
                        {
                            Usuario us = new Usuario ();
                            us.CadastrarUsuario ();
                            break;
                        }
                    case "2":
                        {

                        }
                }

            } while (opcao != "9");
        }
    }
}