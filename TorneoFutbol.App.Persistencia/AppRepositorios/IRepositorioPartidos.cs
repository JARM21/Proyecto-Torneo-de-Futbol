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
    }
}