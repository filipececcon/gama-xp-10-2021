using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Oficina<TMaterial> where TMaterial : Material
    {
        private readonly ISenai<TMaterial> _funcionario;

        public Oficina(ISenai<TMaterial> funcionario)
        {
            _funcionario = funcionario;
        }

        public void ConsertaFreio()
        {
            _funcionario.ArrumarFreio();
        }

        public TMaterial ConsertaMotor()
        {
            var oleovelho = _funcionario.ArrumarMotor();

            return oleovelho;
        }
    }

    public interface ISenai<TMaterial> where TMaterial : Material
    {
        void ArrumarFreio();
        TMaterial ArrumarMotor();
    }


    public class Mecanico : ISenai<Oleo>
    {
        public void ArrumarFreio()
        {
            throw new NotImplementedException();
        }

        public Oleo ArrumarMotor()
        {
            return new Oleo("Canola");
        }
    }

    public class Torneiro : ISenai<Parafuso>
    {
        public void ArrumarFreio()
        {
            throw new NotImplementedException();
        }

        public Parafuso ArrumarMotor()
        {
            return new Parafuso("MetalMetalico");
        }
    }

    public abstract class Material
    {
        public Material(string marca)
        {
            Marca = marca;
        }

        public string Marca { get; set; }
    }


    public class Oleo : Material
    {
        public Oleo(string marca) : base(marca)
        {

        }
    }


    public class Parafuso : Material
    {
        public Parafuso(string marca) : base(marca)
        {
            
        }

        
    }
}
