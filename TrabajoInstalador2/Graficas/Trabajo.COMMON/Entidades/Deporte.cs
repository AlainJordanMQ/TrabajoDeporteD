using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo.COMMON.Entidades
{
    public class Deporte: Base
    {
        public string Nombre { get; set; }
        public string CantidadDeEquipos { get; set; }
        public List<Equipo> Equipos { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
