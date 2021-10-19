using Gama.Locadora.Comercial.Entities;
using Gama.Locadora.Shared.Entities;
using Gama.Locadora.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Comercial.Queries
{
    public class Metre
    {
        private readonly IGarcom<Churrasco> _garcom;

        public Metre(IGarcom<Churrasco> garcom)
        {
            _garcom = garcom;
        }

        public Churrasco FazerPedido()
        {
            return _garcom.Entregar();
        }
    }

    public interface IGarcom<TComida> where TComida : Comida
    {
        TComida Entregar();
    }

    public class Churrasqueiro : IGarcom<Churrasco>
    {
        public Churrasco Entregar()
        {
            return new Churrasco();
        }
    }

    public class Ajudante : IGarcom<Churrasco>
    {
        public Churrasco Entregar()
        {
            return new Churrasco();
        }
    }

    public class Cozinheiro : IGarcom<Feijoada>
    {
        public Feijoada Entregar()
        {
            return new Feijoada();
        }
    }

    public class Sucheff : IGarcom<Feijoada>
    {
        public Feijoada Entregar()
        {
            return new Feijoada();
        }
    }

    public abstract class Comida
    {
        public string Ingredientes { get; set; }
    }

    public class Feijoada : Comida
    {
    }

    public class Churrasco : Comida
    {
    }




    //public class CarBrandRepository : IRepository<CarBrand>
    //{
    //    public CarBrand GetById()
    //    {
    //        return new CarBrand { Name = "Jeruza" };
    //    }
    //}


}    