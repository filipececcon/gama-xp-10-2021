using Aula1.AulaObjetos;

namespace Aula1
{
    class PessoaFisica : Pessoa, ICasamento
    {
        public PessoaFisica(string name, string email, Endereco endereco, string cpf) : base(name, email, endereco)
        {
            CPF = cpf;
        }
        public string CPF { get; set; }

        public bool IsCasado { get; set; }

        public void Casar(PessoaFisica pessoa1, PessoaFisica pessoa2)
        {
            throw new System.NotImplementedException();
        }
    }
}
