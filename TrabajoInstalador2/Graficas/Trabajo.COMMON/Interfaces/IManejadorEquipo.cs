using System;
using System.Collections.Generic;
using System.Text;
using Trabajo.COMMON.Entidades;

namespace Trabajo.COMMON.Interfaces
{
   public  interface IManejadorEquipo : IManejadorGenerico<Equipo>
    {
        List<Equipo> Deporte(string Deporte);
    }
}
