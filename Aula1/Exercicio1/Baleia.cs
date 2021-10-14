namespace Aula1.Exercicio1
{
    public class Baleia : Animal
    {
        public Baleia(int kilos, int tamanho, string habitat) : base(true, 0, habitat)
        {
            Kilos = kilos;
            this.tamanho = tamanho;
        }

        public int Kilos { get; set; }
        public int tamanho { get; set; }
    }
}