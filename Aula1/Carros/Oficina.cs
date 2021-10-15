using System;
using System.Threading;
using System.Threading.Tasks;

namespace Aula1.Carros
{
    public class Oficina<T> where T : Carro
    {
        public async Task TrocarOleo(T carro)
        {
            var seg = 3;

            Console.WriteLine($"{carro.Nome}: ({seg}s) Trocando óleo....");

            await Task.Delay(seg * 1000);

            Console.WriteLine($"{carro.Nome}: Óleo trocado!");
        }

        public async Task Abastecer(T carro)
        {
            var seg = 2;

            Console.WriteLine($"{carro.Nome}: ({seg}s) Abastecendo...");

            carro.Combustivel = 100;

            await Task.Delay(seg * 1000);

            Console.WriteLine($"{carro.Nome}: Abastecido!");
        }

        public async Task TrocarFreios(T carro)
        {
            var seg = 5;

            Console.WriteLine($"{carro.Nome}: ({seg}s) Trocando freios....");

            await Task.Delay(seg * 1000);

            Console.WriteLine($"{carro.Nome}: Freios trocados");
        }

        
    }
}