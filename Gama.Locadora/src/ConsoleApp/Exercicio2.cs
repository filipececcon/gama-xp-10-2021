using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{


    #region Comidas
    public abstract class Comida
    {
        public Comida(params string[] ingredientes)
        {
            Ingredientes = ingredientes;
        }

        public string[] Ingredientes { get; set; }

    }

    public class Hamburguer : Comida
    {
        public Hamburguer(string proteina) : base(proteina , "alface", "pao", "tomate")
        {

        }
    }

    public class Fritas : Comida
    {
        public Fritas() : base("batata", "sal")
        {
                
        }

    }
    public class Nuggets : Comida
    {
        public Nuggets() : base("frango", "molho")
        {

        }

    } 
    #endregion

    public interface IFuncionario<TComida> where TComida : Comida
    {
        TComida FazerComida();
    }

    public class FastFood<TComida> where TComida : Comida
    {
        private readonly IFuncionario<TComida> _funcionario;

        public FastFood(IFuncionario<TComida> funcionario)
        {
            _funcionario = funcionario;
        }

        public TComida ServirComida()
        {
            return _funcionario.FazerComida();
        }
    }


    #region Funcionarios


    public class Funcionario<TComida> : IFuncionario<TComida> where TComida : Comida, new()
    {
        public TComida FazerComida()
        {
            return new TComida();

            //return Activator.CreateInstance<TComida>();
        }
    }

    #endregion






}
