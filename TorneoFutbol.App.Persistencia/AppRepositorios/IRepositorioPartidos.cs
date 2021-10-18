using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioPartidos
    {   
        IEnumerable<Partido> GetAllPartidos();
        Partido AddPartidos(Partido partidos);
        Partido UpdatePartido(Partido partidos);
        void DeletePartidos(int partidos);
        Partido GetPartido(int partido);
        Equipo AsignarEquipoLocal(int idPartido, int idEquipoLocal);
        Equipo AsignarEquipoVisitante(int idPartido, int idEquipoVisitante);
        Estadio AsignarEstadio(int idPartido, int idEstadio);
        Arbitro AsignarArbitro(int idPartido, int idArbitro);
    }
}