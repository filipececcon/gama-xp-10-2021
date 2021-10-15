namespace Aula1.Exercicio1
{
    public class Sapo : Animal
    {
        public Sapo(bool venenoso, string habitat) : base(false,4, habitat)
        {
            Venenoso = venenoso;
        }

        public bool Venenoso { get; set; }
    }
}