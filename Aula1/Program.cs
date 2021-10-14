using Aula1.AulaObjetos;
using Aula1.Carros;
using Aula1.Exercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Aula1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var c1 = new Corsa();

            var t1 = new TestaPerformance<Corsa>();

            t1.AumentarCombustivel(c1);


            var mensagem = await t1.ZerarTanque(c1);

            var nomes = new string[] { "joao", "maria", "jose" };

            Console.WriteLine(mensagem);

            nomes.AsParallel().ForAll(Console.WriteLine);
            
            Console.ReadKey();
        }

        static void Casamento(PessoaFisica pessoa1, PessoaFisica pessoa2, ICasamento cartorio)
        {
            cartorio.Casar(pessoa1, pessoa2);
        }

        static void GalopaAi(IGalope galopador)
        {
            Console.WriteLine(galopador.Galopar());
        }


        #region Aula passada

        static void ModoPro()
        {
            var animais = new List<Animal>();

            AdicionarSapos(animais);
            AdicionarPassaros(animais);
            AdicionarCavalos(animais);
            AdicionarBaleias(animais);

            animais.ForEach(animal => Console.WriteLine(animal.AlimentarRecemNascido()));

            var mamiferos = animais.Count(x => x.Mamifero);

            var baleias = animais.OfType<Baleia>();

            var peso = baleias.Sum(x => x.Kilos) / baleias.Count();

            //var peso = baleias.Average(x => x.Kilos);

            var tamanho = baleias.Sum(x => x.tamanho);

            var patas = animais.Sum(x => x.Patas);

            var texto = @$"
            * RESULTADOS *
            Mamiferos = {mamiferos}
            Peso médio das baleias: {peso}
            Tamanho de todas as baleias juntas: {tamanho}
            Total de patas: {patas}
            ";



            Console.Write(texto);
        }

        static void ModoBasico()
        {
            var animais = new List<Animal>();

            AdicionarSapos(animais);
            AdicionarPassaros(animais);
            AdicionarCavalos(animais);
            AdicionarBaleias(animais);

            int patas = 0;
            int peso = 0;
            int tamanho = 0;
            int baleianum = 0;
            int mamiferos = 0;

            foreach (var animal in animais)
            {
                Console.WriteLine(animal.AlimentarRecemNascido());

                mamiferos += animal.Mamifero ? 1 : 0;

                if (animal.GetType() == typeof(Baleia))
                {
                    baleianum++;

                    peso += ((Baleia)animal).Kilos;

                    tamanho += ((Baleia)animal).tamanho;

                }

                patas += animal.Patas;

            }

            double media = peso / baleianum;

            var texto = @$"
            * RESULTADOS *
            Mamiferos = {mamiferos}
            Peso médio das baleias: {media}
            Tamanho de todas as baleias juntas: {tamanho}
            Total de patas: {patas}
            ";

            Console.Write(texto);
        }

        static void AdicionarSapos(List<Animal> animais)
        {
            for (int i = 1; i <= 6; i++)
            {
                bool venenoso;
                string ambiente = "";

                if (i > 3)
                {
                    ambiente = "agua doce";
                    venenoso = true;
                }
                else
                {
                    ambiente = "agua salgada";
                    venenoso = false;
                }

                animais.Add(new Sapo(venenoso, ambiente));
            }
        }

        static void AdicionarPassaros(List<Animal> animais)
        {
            for (int i = 1; i <= 9; i++)
            {
                bool carnivoro;
                string porte = "";

                if (i <= 3)
                {
                    porte = "pequeno";
                    carnivoro = false;

                }
                else if (i >= 4 && i <= 6)
                {
                    porte = "medio";
                    carnivoro = i == 6;
                }
                else
                {
                    porte = "grande";
                    carnivoro = true;
                }

                animais.Add(new Passaro(carnivoro, porte, "floresta"));
            }
        }

        static void AdicionarCavalos(List<Animal> animais)
        {
            for (int i = 1; i <= 8; i++)
            {
                string ambiente = "";
                string cor = "";

                if (i <= 2)
                {
                    cor = "branco";
                    ambiente = "planicie";

                }
                else if (i >= 3 && i <= 4)
                {
                    cor = "preto";
                    ambiente = "planicie";
                }
                else if (i >= 5 && i <= 6)
                {
                    cor = "marrom";
                    ambiente = "floresta";
                }
                else
                {
                    cor = "cinza";
                    ambiente = "floresta";
                }

                animais.Add(new Cavalo($"Raça {i}", cor, ambiente));
            }
        }

        static void AdicionarBaleias(List<Animal> animais)
        {
            for (int i = 1; i <= 8; i++)
            {

                var ambiente = i <= 4 ? "agua salgada" : "agua doce";

                var metros = i * 10;

                var kilos = 400 + (i * 100);

                animais.Add(new Baleia(kilos, metros, ambiente));
            }
        }
        #endregion

    }
}
