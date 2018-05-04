using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo.COMMON.Entidades
{
    public class Equipo: Base
    {
        public string Nombre { get; set; }
        public string CantidadDeIntegrantes { get; set; }
        public string Deporte { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
