using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trabajo.COMMON.Entidades;
using Trabajo.COMMON.Interfaces;

namespace Trabajo
{
    public class ManejadorEquipo : IManejadorEquipo
    {
        IRepositorio<Equipo> repositorio;
        public ManejadorEquipo(IRepositorio<Equipo> repo)
        {
            repositorio = repo;
        }

        public List<Equipo> Listar => repositorio.Read;

        public bool Agregar(Equipo entidad)
        {
            return repositorio.Create(entidad);
        }

        public Equipo BuscarPorId(MongoDB.Bson.ObjectId id)
        {
            return Listar.Where(e => e.Id == id).SingleOrDefault();
        }

        public bool Eliminar(MongoDB.Bson.ObjectId id)
        {
            return repositorio.Delete(id);
        }

        public List<Equipo> Deporte(string deporte)
        {
            return Listar.Where(e => e.Deporte == deporte).ToList();
        }

        public bool Modificar(Equipo entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
