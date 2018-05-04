using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trabajo.COMMON.Entidades;
using Trabajo.COMMON.Interfaces;

namespace Trabajo
{
    public class ManejadorMarcadores : IManejadorMarcadores
    {
        IRepositorio<Marcadores> repositorio;
        public ManejadorMarcadores(IRepositorio<Marcadores> repo)
        {
            repositorio = repo;
        }

        public List<Marcadores> Listar => repositorio.Read;

        public bool Agregar(Marcadores entidad)
        {
            return repositorio.Create(entidad);
        }

        public Marcadores BuscarPorId(MongoDB.Bson.ObjectId id)
        {
            return Listar.Where(e => e.Id == id).SingleOrDefault();
        }

        public bool Eliminar(MongoDB.Bson.ObjectId id)
        {
            return repositorio.Delete(id);
        }

        public List<Marcadores> Equipo(string equipo)
        {
            return Listar.Where(e => e.EquipoLocal == equipo).ToList();
        }
        public List<Marcadores> MarcadorF(string equipo)
        {
            return Listar.Where(e => e.EquipoLocal == equipo).ToList();
        }

        public bool Modificar(Marcadores entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
