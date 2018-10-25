using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ListaComidas
    {
        List<Comida> comidas;

        public ListaComidas()
        {
            comidas = new List<Comida>();
        }

        public void Agregar(Comida comida)
        {
            comidas.Add(comida);
        }
    }
}
