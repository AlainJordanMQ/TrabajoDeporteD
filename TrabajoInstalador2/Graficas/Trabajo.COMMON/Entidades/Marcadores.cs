using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo.COMMON.Entidades
{
    public class Marcadores: Base
    {
        public string DeporteM { get; set; }
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public string PuntajeLocal { get; set; }
        public string PuntajeVisistante { get; set; }
        public string PuntajeFinal { get; set; }

        public override string ToString()
        {
            return PuntajeFinal;
        }
    }
}
