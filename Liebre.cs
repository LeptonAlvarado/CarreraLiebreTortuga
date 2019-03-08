using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraLiebreTortuga
{
    class Liebre : Corredor
    {
        /// <summary>
        /// Asigna un numero a la Liebre
        /// </summary>
        /// <param name="numero">Le devuelve el numero a la clase que hereda</param>
        public Liebre(int numero) : base(numero)
        {

        }

        /// <summary>
        /// Hace las condiciones para saber cuanto avanzara la Liebre
        /// </summary>
        new public void Correr()
        {
            int avance = base.Correr();

            if (avance <= 4) // Se podria poner ; porque la libre no hace nada
                _pos += 0;
            else if (avance <= 9)
                _pos += 12;
            else if (avance <= 13)
                _pos += 5;
            else if (avance <= 16)
                _pos -= 4;
            else
                _pos -= 8;
        }

        /// <summary>
        /// Genera un texto que se mostrara durante la carrera
        /// </summary>
        /// <returns>Devuelve el texto escrito mas el texto que se encuentra en la clase que hereda</returns>
        public override string ToString()
        {
            return "La liebre " + base.ToString();
        }
    }
}
