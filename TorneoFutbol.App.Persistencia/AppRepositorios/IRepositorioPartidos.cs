using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioPartidos
    {   
        IEnumerable<Partidos> GetAllPartidos();
        Partidos AddPartidos(Partidos partidos);
        Partidos UpdatePartidos(Partidos partidos);
        void DeletePartidos(int partidos);
        Partidos GetPartido(int partido);
    }
}