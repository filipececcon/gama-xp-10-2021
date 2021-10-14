using System.Linq;

namespace Aula1.Exercicio1
{
    public class Habitat
    {
        public Habitat(string ambiente)
        {
            var ambientes = new string[] { "floresta", "planicie", "agua salgada", "agua doce" };

            Ambiente = ambientes.Contains(ambiente) ? ambiente : null;
        }

        public string Ambiente { get; set; }
    }
}