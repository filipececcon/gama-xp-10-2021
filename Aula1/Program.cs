using Aula1.AulaObjetos;
using Aula1.Exercicio1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula1
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    ////colecoes
        //    //foreach(var n in Colecoes.MinhaPilha())
        //    //{
        //    //    Console.Write(n);
        //    //}

        //    //tipo anonimo
        //    //var pessoa = new { nome = "Filipe", sobrenome="Ceccon" };


        //    //var p1 = new Pessoa { Nome = "Filipe", Email = "filipececcon@gmail.com" };
        //    //var p2 = new Pessoa { Nome = "Rodolfo", Email = "rodolfo@gmail.com" };

        //    //var p3 = new Pessoa("Filipe", "filipececcon@gmail.com");
        //    //p3.Email = "azdrubal@gmail.com";

        //    //var p4 = new PessoaFisica { Nome = "Filipe", Email = "filipececcon@gmail.com", CPF = "123.123.123-12" };

        //    var end = new Endereco { 
        //        Rua = "Rua teste", 
        //        Bairro = "TESTADO", 
        //        Cidade = "TESTOPOLIS", 
        //        Estado = "TESTOLANDIA", 
        //        Numero = "32T" 
        //    };


        //    var p4 = new PessoaFisica("Filipe", "filipececcon@gmail.com", end, "123.123.123-12");
        //    var p5 = new PessoaJuridica("Filipe", "filipececcon@gmail.com", end, "12.123.123/0001-12", "Ceccon SA" );



        //    //var p6 = new Pessoa("teste", "cpf");

        //    Console.WriteLine(p4.Endereco.Rua);

        //}

        static void Main(string[] args)
        {

            //var endereco = new Endereco
            //{
            //    Bairro ="Centro",
            //    Cidade = "Centrista",
            //    Estado = "Centrado",
            //    Numero = "10A",
            //    Rua = "Rua Central"
            //};

            //var p1 = new PessoaFisica("Azdrubal", "az@gmail.com", endereco, "999.999.99-99");
            //var p2 = new PessoaFisica("ASD", "asd@gmail.com", endereco, "888.888.888-88");


            //var social = new CartorioSocial();
            //var daQuebrada = new CartorioDaQuebrada();


            //Casamento(p1, p2, p1);


            var animais = new List<Animal>();


            AdicionarCavalos(animais);


            var ct1 = new CavaloTerrestre("pangaré", "preto");
            var ct2 = new CavaloTerrestre("pangaré", "branco");

            var cm1 = new CavaloMarinho("com guelrras", "vermelho");
            var cm2 = new CavaloMarinho("sem guelrras", "amarelo");

            animais.Add(ct1);
            animais.Add(ct2);
            animais.Add(cm1);
            animais.Add(cm2);



            //foreach(var a in animais)
            //{
            //    //galopadores
            //    if(a.GetType() == typeof(IGalope))
            //    {
            //        GalopaAi(a as IGalope);
            //    }
            //}


            animais.OfType<IGalope>().ToList().ForEach(GalopaAi);

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

            animais.ForEach(animal => Console.WriteLine(animal.Comer()));

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
                Console.WriteLine(animal.Comer());

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
