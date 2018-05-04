using System;
using System.Collections.Generic;
using System.Text;
using Trabajo.COMMON.Entidades;

namespace Trabajo.COMMON.Interfaces
{
    public interface IManejadorNombreGanador : IManejadorGenerico<NombreGanador>
    {
        List<NombreGanador> Deporte(string Deporte);
    }
}
