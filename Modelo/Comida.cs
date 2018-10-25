using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Comida
    {
        string nombre;
        string proteinas;
        string grasas;
        string carbohidratos;
        int calorias;

        public Comida(string n, string e, string g, string c)
        {
            nombre = n;
            proteinas = e;
            grasas = g;
            carbohidratos = c;
        }
        public void CaluclarCalorias()
        {
            calorias = 4 * Convert.ToInt32(carbohidratos) + 4 * Convert.ToInt32(proteinas) + 9 * Convert.ToInt32(grasas);
        }

        public override string ToString()
        {
            return $"{nombre} (carbohidratos: {carbohidratos}, proteinas: {proteinas}, grasas: {grasas}, calorias: {calorias})";
        }
    }
}
