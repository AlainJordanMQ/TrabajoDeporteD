using System;
using System.Collections.Generic;
using System.Text;
using Trabajo.COMMON.Entidades;

namespace Trabajo.COMMON.Interfaces
{
    public interface IManejadorMarcadores : IManejadorGenerico<Marcadores>
    {
        List<Marcadores> Equipo(string Equipo);
        List<Marcadores> MarcadorF(string Equipo);
    }
}
