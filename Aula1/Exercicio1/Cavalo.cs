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

        public string Raça { get; set; }
        public string Cor { get; set; }

        public static string Galopar() 
        {
            return "Pocotó ";
        }

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