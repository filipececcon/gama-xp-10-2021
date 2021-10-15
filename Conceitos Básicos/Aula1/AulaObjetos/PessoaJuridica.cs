namespace Aula1
{
    class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(string nome, string email, Endereco endereco, string cNPJ, string razaoSocial) : base(nome, email, endereco)
        {
            CNPJ = cNPJ;
            RazaoSocial = razaoSocial;
        }

        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
    }
}
