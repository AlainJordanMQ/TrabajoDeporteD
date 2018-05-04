using System;
using System.Collections.Generic;
using System.Text;

namespace GeneradoraDeDatos
{
    public class Generadora
    {
        public Generadora()
        {
            Puntos = new List<Punto>();
        }
        /// <summary>
        /// Permite obtener el ultimo conjunto de datos generado
        /// </summary>
        public List<Punto> Puntos { get; set; }
        /// <summary>
        /// Genera un conjunto de datos tipo Punto 
        /// </summary>
        /// <param name="limiteInferior">Limite inferior de X para generar los datos</param>
        /// <param name="limiteSuperior">Limite superior de X para generar los datos</param>
        /// <param name="incremento">Incremento de X para generar los datos</param>
        /// <returns></returns>
        public List<Punto> GenerarDatos(double limiteInferior, double limiteSuperior, double incremento, int [] valor)
        {
            int i = 0;
            Puntos = new List<Punto>();
            for (double x = limiteInferior; x < limiteSuperior; x += incremento)
            {
                Puntos.Add(new Punto(x, Evaluar(valor[i])));
                i = i + 1;
            }
            return Puntos;
        }

        public double Evaluar(int valor )
        {
            //Aqui cambiar la función para evaluar
            return (valor);
        }
    }
   
}
