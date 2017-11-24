using System;
using System.IO;
using System.Text;

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
            Consultar(Email);
        }
        private string Consultar (string Email) {

            string Resultado = "Usuário não cadastrado!";
            StreamReader ler = null;

            try {
                ler = new StreamReader ("cadUsuario.txt", Encoding.Default); // ENCODING serve para dizer os tipos de caracteres que vão ser pesquisados
                string Linha = "";

                while ((Linha = ler.ReadLine ()) != null) // enquanto tiver dado escrito ele continua no while
                {
                    string[] dados = Linha.Split (';'); // indica que cada dado pesquisado é separado por ";" e a cada ';' ele inclui o dado em um ARRAY
                    if (dados[1] == Email) // se ele encontrar o que foi epsquisado na coluna do titulo, ele lê toda a linha
                    {
                        Resultado = Linha;
                        break;
                    }
                }
            } catch (System.Exception ex) {
                Resultado = "Erro ao tentar ler o arquivo " + ex.Message;
            } finally {
                ler.Close ();
            }

            return Resultado;

        }

    }
}