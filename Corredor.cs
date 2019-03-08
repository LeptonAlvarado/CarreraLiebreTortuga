using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraLiebreTortuga
{
    class Corredor
    {
        private int _num;
        protected int _pos; //protected te permite usar la funcion _pos en clases que le heredan
        private static Random numAle = new Random();

        /// <summary>
        /// Asigna el numero y la posicion a los corredores
        /// </summary>
        /// <param name="num">La variable que le dara valor _num, pero no se podra cambiar</param>
        public Corredor(int num)
        {
            _num = num;
            _pos = 0;
        }

        public int Numero
        {
            get { return _num; }
        }

        public int Posicion
        {
            get { return _pos; }
        }

        /// <summary>
        /// Genera numeros aleatorios del 1 al 20
        /// </summary>
        /// <returns>Devuelve el nummero aleatorio</returns>
        public int Correr()
        {
            int x = numAle.Next(1, 20);
            return x;
        }

        /// <summary>
        /// Generera un texto que se mostrara durante la carrera
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Numero " + Numero.ToString() + " Se encuentra en la posicion " + Posicion.ToString() ;
        }

    }
}
