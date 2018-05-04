using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trabajo.COMMON.Entidades;
using Trabajo.COMMON.Interfaces;

namespace Trabajo
{
    public class ManejadorNombreGanador: IManejadorNombreGanador
    {
        IRepositorio<NombreGanador> repositorio;
        public ManejadorNombreGanador(IRepositorio<NombreGanador> repo)
        {
            repositorio = repo;
        }

        public List<NombreGanador> Listar => repositorio.Read;

        public bool Agregar(NombreGanador entidad)
        {
            return repositorio.Create(entidad);
        }

        public NombreGanador BuscarPorId(MongoDB.Bson.ObjectId id)
        {
            return Listar.Where(e => e.Id == id).SingleOrDefault();
        }

        public bool Eliminar(MongoDB.Bson.ObjectId id)
        {
            return repositorio.Delete(id);
        }

        public List<NombreGanador> Deporte(string deporte)
        {

            return Listar.Where(e => e.Deporte == deporte).ToList();
        }

        public bool Modificar(NombreGanador entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}
