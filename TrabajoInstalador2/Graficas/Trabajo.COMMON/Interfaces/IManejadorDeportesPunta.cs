using System;
using System.Collections.Generic;
using System.Text;
using Trabajo.COMMON.Entidades;

namespace Trabajo.COMMON.Interfaces
{
    public interface IManejadorDeportesPunta : IManejadorGenerico<DeportePunta>
    {
       
        List<DeportePunta> Deporte(string Deporte);
    }
}
