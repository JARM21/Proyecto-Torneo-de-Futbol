using System.Collections.Generic;
using System.Linq;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioEquipos : IRepositorioEquipos
    {
        private readonly AppContext _appContext = new AppContext();
        

        Equipo IRepositorioEquipos.AddEquipos(Equipo Equipos)
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

        IEnumerable<Equipo> IRepositorioEquipos.GetAllEquipos()
        {
            return _appContext.Equipos;
        }

        Equipo IRepositorioEquipos.GetEquipos(int IdEquipos)
        {
            return _appContext.Equipos.FirstOrDefault(m=>m.Id==IdEquipos);
            
        }

        Equipo IRepositorioEquipos.UpdateEquipos(Equipo Equipo)
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
