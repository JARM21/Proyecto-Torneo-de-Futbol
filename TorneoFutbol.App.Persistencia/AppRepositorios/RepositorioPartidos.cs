using System.Collections.Generic;
using System.Linq;
using TorneoFutbol.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioPartidos : IRepositorioPartidos
    {
        private readonly AppContext _appContext = new AppContext();
        

        Partido IRepositorioPartidos.AddPartidos(Partido partidos)
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

        IEnumerable<Partido> IRepositorioPartidos.GetAllPartidos()
        {
            return _appContext.Partidos;
        }

        Partido IRepositorioPartidos.GetPartido(int idPartido)
        {
            var partido = _appContext.Partidos
                .Where(p => p.Id == idPartido)
                .Include(p => p.EquipoLocal)
                .Include(p => p.EquipoVisitante)
                .Include(p => p.Estadio)
                .Include(p => p.Arbitro)
                .FirstOrDefault();
            return partido;
            //return _appContext.Partidos.FirstOrDefault(p=>p.Id==idPartido);
            
        }

        Partido IRepositorioPartidos.UpdatePartido(Partido partido)
        {
            var partidoEncontrado=_appContext.Partidos.FirstOrDefault(p=>p.Id==partido.Id);
            if(partidoEncontrado!=null)
            {
                partidoEncontrado.FechaYHora = partidoEncontrado.FechaYHora;
                partidoEncontrado.Estadio = partidoEncontrado.Estadio;
                partidoEncontrado.Arbitro = partidoEncontrado.Arbitro;
                partidoEncontrado.MarcadorFinalLocal = partidoEncontrado.MarcadorFinalLocal;
                //partidoEncontrado.MarcadorFinalVisitante = partidoEncontrado.MarcadorFinalVisitante;
                
                _appContext.SaveChanges();
            }
            return partidoEncontrado;
        }

        Equipo IRepositorioPartidos.AsignarEquipoLocal(int idPartido, int idEquipoLocal)
        {
            var partidoEncontrado = _appContext.Partidos.Find(idPartido);
            if (partidoEncontrado != null)
            { var equipoEncontrado = _appContext.Equipos.Find(idEquipoLocal);
            if (equipoEncontrado != null)
            { partidoEncontrado.EquipoLocal = equipoEncontrado;
            _appContext.SaveChanges();
            }
            return equipoEncontrado;
            }
            return null; 
        }
        Equipo IRepositorioPartidos.AsignarEquipoVisitante(int idPartido, int idEquipoVisitante)
        {
            var partidoEncontrado = _appContext.Partidos.Find(idPartido);
            if (partidoEncontrado != null)
            { var equipoEncontrado = _appContext.Equipos.Find(idEquipoVisitante);
            if (equipoEncontrado != null)
            { partidoEncontrado.EquipoVisitante = equipoEncontrado;
            _appContext.SaveChanges();
            }
            return equipoEncontrado;
            }
            return null; 
        }
        Estadio IRepositorioPartidos.AsignarEstadio(int idPartido, int idEstadio)
        {
            var partidoEncontrado = _appContext.Partidos.Find(idPartido);
            if (partidoEncontrado != null)
            { var estadioEncontrado = _appContext.Estadios.Find(idEstadio);
            if (estadioEncontrado != null)
            { partidoEncontrado.Estadio = estadioEncontrado;
            _appContext.SaveChanges();
            }
            return estadioEncontrado;
            }
            return null; 
        }
        Arbitro IRepositorioPartidos.AsignarArbitro(int idPartido, int idArbitro)
        {
            var partidoEncontrado = _appContext.Partidos.Find(idPartido);
            if (partidoEncontrado != null)
            { var arbitroEncontrado = _appContext.Arbitros.Find(idArbitro);
            if (arbitroEncontrado != null)
            { partidoEncontrado.Arbitro = arbitroEncontrado;
            _appContext.SaveChanges();
            }
            return arbitroEncontrado;
            }
            return null; 
        }
    }
}