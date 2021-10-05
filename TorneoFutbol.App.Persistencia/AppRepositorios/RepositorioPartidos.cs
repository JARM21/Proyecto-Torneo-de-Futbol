using System.Collections.Generic;
using System.Linq;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioPartidos : IRepositorioPartidos
    {
        private readonly AppContext _appContext;
        public RepositorioPartidos(AppContext appContext)
        {
            _appContext=appContext;
        }

        Partidos IRepositorioPartidos.AddPartidos(Partidos partidos)
        {
            var partidoAdicionado = _appContext.Partidos.Add(partidos);
            _appContext.SaveChanges();
            return partidoAdicionado.Entity;
        }

        void IRepositorioPartidos.DeletePartidos(int idPartidos)
        {
            var partidoEncontrado=_appContext.Partidos.FirstOrDefault(p=>p.Id==idPartidos);
            if(partidoEncontrado==null)
                return;
            _appContext.Partidos.Remove(partidoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Partidos> IRepositorioPartidos.GetAllPartidos()
        {
            return _appContext.Partidos;
        }

        Partidos IRepositorioPartidos.GetPartido(int idPartido)
        {
            return _appContext.Partidos.FirstOrDefault(p=>p.Id==idPartido);
            
        }

        Partidos IRepositorioPartidos.UpdatePartido(Partidos partido)
        {
            var partidoEncontrado=_appContext.Partidos.FirstOrDefault(p=>p.Id==partido.Id);
            if(partidoEncontrado!=null)
            {
                partidoEncontrado.FechaYHora = partidoEncontrado.FechaYHora;
                partidoEncontrado.EquipoLocal = partidoEncontrado.EquipoLocal;
                partidoEncontrado.MarcadorInicialLocal = partidoEncontrado.MarcadorInicialLocal;
                partidoEncontrado.EquipoVisitante = partidoEncontrado.EquipoVisitante;
                partidoEncontrado.MarcadorInicialVisitante = partidoEncontrado.MarcadorInicialVisitante;
                partidoEncontrado.Estadio = partidoEncontrado.Estadio;
                partidoEncontrado.Arbitro = partidoEncontrado.Arbitro;
                partidoEncontrado.MarcadorFinal = partidoEncontrado.MarcadorFinal;
                
                _appContext.SaveChanges();
            }
            return partidoEncontrado;
        }
    }
}