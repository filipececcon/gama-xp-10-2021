namespace Aula1.Exercicio1
{
    public class Cavalo : Animal
    {
        public Cavalo(string raça, string cor, string habitat) : base(true, 4, habitat)
        {
            Raça = raça;
            Cor = cor;

            if (habitat == "agua" || habitat == "mar") Patas = 0;
        }

        /// <summary>
        /// Construtor de um Cavalo não mamífero
        /// </summary>
        /// <param name="raça">raça do cavalo</param>
        /// <param name="cor">cor do cavalo</param>
        /// <param name="patas">quantidade de patas que possui</param>
        /// <param name="habitat">onde vive</param>
        public Cavalo(string raça, string cor, int patas, string habitat) : base(false, patas, habitat)
        {
            Raça = raça;
            Cor = cor;
        }

        public string Raça { get; set; }
        public string Cor { get; set; }


        public bool Equals(Cavalo c)
        {
            return c.Raça == Raça && 
                   c.Habitat.Ambiente == Habitat.Ambiente;
        }

        public override string Comer()
        {
            return "Comer capim";
        }

    }
}