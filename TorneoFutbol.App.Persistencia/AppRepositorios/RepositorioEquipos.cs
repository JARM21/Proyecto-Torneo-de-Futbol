using System.Collections.Generic;
using System.Linq;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioEquipos : IRepositorioEquipos
    {
        private readonly AppContext _appContext;
        public RepositorioEquipos(AppContext appContext)
        {
            _appContext=appContext;
        }

        Equipos IRepositorioEquipos.AddEquipos(Equipos Equipos)
        {
            var EquipoAdicionado = _appContext.Equipos.Add(Equipos);
            _appContext.SaveChanges();
            return EquipoAdicionado.Entity;
        }

        void IRepositorioEquipos.DeleteEquipos(int IdEquipos)
        {
            var EquipoEncontrado=_appContext.Equipos.FirstOrDefault(m=>m.Id==IdEquipos);
            if(EquipoEncontrado==null)
                return;
            _appContext.Equipos.Remove(EquipoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Equipos> IRepositorioEquipos.GetAllEquipos()
        {
            return _appContext.Equipos;
        }

        Equipos IRepositorioEquipos.GetEquipos(int IdEquipos)
        {
            return _appContext.Equipos.FirstOrDefault(m=>m.Id==IdEquipos);
            
        }

        Equipos IRepositorioEquipos.UpdateEquipos(Equipos Equipo)
        {
            var EquipoEncontrado=_appContext.Equipos.FirstOrDefault(m=>m.Id==Equipo.Id);
            if(EquipoEncontrado!=null)
            {
                EquipoEncontrado.Nombre = Equipo.Nombre;
                EquipoEncontrado.CantidadPartidosJugados = Equipo.CantidadPartidosJugados;
                EquipoEncontrado.CantidadPartidosEmpatados = Equipo.CantidadPartidosEmpatados;
                EquipoEncontrado.GolesAFavor = Equipo.GolesAFavor;
                EquipoEncontrado.GolesEnContra = Equipo.GolesEnContra;
                EquipoEncontrado.Puntos = Equipo.Puntos;
                
                
                _appContext.SaveChanges();
            }
            return EquipoEncontrado;
        }
    }
}
