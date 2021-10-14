using System;
using System.Threading;
using System.Threading.Tasks;

namespace Aula1.Carros
{
    public class TestaPerformance<T> where T : Carro
    {
        public void TestaAcelerador(T carro)
        {
            carro.Acelerar();
        }

        public Task AumentarCombustivel(T carro)
        {
            carro.Combustivel += 10;

            Console.WriteLine("Aumentado " + carro.Combustivel);

            return Task.CompletedTask;
        }

        public async Task<string> ZerarTanque(T carro)
        {
            carro.Combustivel = 0;

            Thread.Sleep(5 * 1000);

            return await Task.FromResult("Tanque zerado");
        }

        
    }
}