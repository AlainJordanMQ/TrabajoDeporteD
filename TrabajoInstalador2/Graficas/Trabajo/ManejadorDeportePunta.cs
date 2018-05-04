using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trabajo.COMMON.Entidades;
using Trabajo.COMMON.Interfaces;

namespace Trabajo
{
    public class ManejadorDeportePunta : IManejadorDeportesPunta
    {
        IRepositorio<DeportePunta> repositorio;
        public ManejadorDeportePunta(IRepositorio<DeportePunta> repo)
        {
            repositorio = repo;
        }

        public List<DeportePunta> Listar => repositorio.Read;

        public bool Agregar(DeportePunta entidad)
        {
            return repositorio.Create(entidad);
        }

        public DeportePunta BuscarPorId(MongoDB.Bson.ObjectId id)
        {
            return Listar.Where(e => e.Id == id).SingleOrDefault();
        }

        public bool Eliminar(MongoDB.Bson.ObjectId id)
        {
            return repositorio.Delete(id);
        }

        public List<DeportePunta> Deporte(string deporte)
        {

            return Listar.Where(e => e.Deporte == deporte).ToList();
        }

        public bool Modificar(DeportePunta entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
