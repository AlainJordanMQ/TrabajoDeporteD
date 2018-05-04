using System;
using System.Collections.Generic;
using System.Text;
using Trabajo.COMMON.Entidades;

namespace Trabajo.COMMON.Interfaces
{
    public interface IManejadorDeporte : IManejadorGenerico<Deporte>
    {
        List<Deporte> ValesPorLiquidar();
        List<Deporte> ValesEnIntervalo(DateTime inicio, DateTime fin);
    }
}
