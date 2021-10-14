using System;

namespace Aula1
{
    abstract class Pessoa
    {
        public Pessoa(string nome, string email, Endereco endereco)
        {
            Console.WriteLine("rodei o construtor");
            Nome = nome;
            Email = email;
            Endereco = endereco;
        }

        #region Propriedades
        public string Nome { get; set; }
        public string Email { get; set; } 
        public Endereco Endereco { get; set; } 
        #endregion

        #region Comportamentos

        public string EnviarEmail()
        {
            return "Email enviado para " + Email;
        }

        public string BemVindo()
        {
            return "Bem vindo a Gama " + Nome;
        } 

        #endregion
    }
}
