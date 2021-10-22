using Gama.Locadora.Comercial.Queries;
using Gama.Locadora.Comercial.Requests;
using Gama.Locadora.Shared.Requests;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //pegar a entidade CarBrand onde o nome eh igual ao que eu passar

            //var handler = new GetCarBrandByNameHandler();

            //var request = new GetCarBrandByNameRequest() { Name = "Ford" };

            //var response = handler.Handle(request);

            var s1 = new Withdraw(5);

            var s2 = new Withdraw(0);

           // var saques = new List<Saque> { s1, s2, s1, s1, s2 };

            var terminal = new TerminalATM();

            var regraA = new NasdaqWithdrawStrategy();

            var regraB = new XpWithdrawStrategy();

            var realizador = new WithdrawService(regraA);

            realizador.Sacar(terminal, s1);

            
            //saques.ForEach(x =>
            //{
            //    if (regra.SaqueValido(x.Valor)) terminal.AddSaque(x);
            //});
        }
    }



    // Domain.Bank.Entities
    public class TerminalATM
    {
        private List<Withdraw> Itens = new List<Withdraw>();
        public void AddSaque(Withdraw item)
        {
            Itens.Add(item);

            Itens.ForEach(x => Console.WriteLine(x.Valor));

            Console.WriteLine("----- FIM  DA LISTA ------ ");
        }
    }

    // Domain.Bank.Entities
    public class Withdraw
    {
        public Withdraw(int valor)
        {
            Valor = valor;
            OccuredDate = DateTime.Now;
        }

        public int Valor { get; set; }

        public DateTime OccuredDate { get; set; }
    }

    // Domain.Bank.Strategies

    public interface IWithdrawStrategy
    {
        bool IsValidWithdraw(int value);
    }

    public class NasdaqWithdrawStrategy : IWithdrawStrategy
    {
        public bool IsValidWithdraw(int value)
        {
            return value > 10;
        }
    }

    public class XpWithdrawStrategy : IWithdrawStrategy
    {
        public bool IsValidWithdraw(int valor)
        {
            return valor >= 5;
        }
    }

    // Domain.Bank.Services
    public class WithdrawService//<T> where T : IWithdrawStrategy
    {
        private readonly IWithdrawStrategy _strategy;

        public WithdrawService(IWithdrawStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Sacar(TerminalATM atm, Withdraw withdraw)
        {
            if (_strategy.IsValidWithdraw(withdraw.Valor)) atm.AddSaque(withdraw);
        }
    }

}
