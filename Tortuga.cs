using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraLiebreTortuga
{
    class Tortuga : Corredor
    {
        /// <summary>
        /// Asigna un numero a la Tortuga
        /// </summary>
        /// <param name="numero">Le devuelve el numero a la clase que hereda</param>
        public Tortuga(int numero) : base(numero)
        {

        }

        /// <summary>
        /// Hace las condiciones para ver cuanto avanzara la tortuga
        /// </summary>
        new public void Correr()
        {
            int avance = base.Correr();

            if (avance <= 4)
                _pos += 3;
            else if (avance <= 8) //Se agregaro otra linea mas de concidion para que no perdiera siempre
                _pos += 6;
            else if (avance <= 12)
                _pos += 8;
            else if (avance <= 16)
                _pos -= 5;
            else
                _pos -= 3;
        }

        /// <summary>
        /// Genera un texto que se mostrara durante la carrera
        /// </summary>
        /// <returns>Devuelve el texto escrito mas el que esta en la clase que hereda</returns>
        public override string ToString()
        {
            return "La tortuga " + base.ToString();
        }
    }
}
