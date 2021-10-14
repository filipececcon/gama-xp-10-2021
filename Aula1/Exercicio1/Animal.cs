using System;

namespace Aula1.Exercicio1
{
    public abstract class Animal
    {
        protected Animal(bool mamifero, int patas, string habitat)
        {
            Mamifero = mamifero;
            Patas = patas;
            Habitat = new Habitat(habitat);
        }

        protected Animal(bool mamifero, int patas, Habitat habitat)
        {
            Mamifero = mamifero;
            Patas = patas;
            Habitat = habitat;
        }

        public Boolean Mamifero { get; set; }
        public Habitat Habitat { get; set; }
        public int Patas { get; protected set; }

        public string Teste { get; set; }

        public virtual string Comer()
        {
            //Console.WriteLine(Mamifero ? "Beber leite" : "comer comida");

            return Mamifero ? "Beber leite" : "comer comida";
        }
    }
}