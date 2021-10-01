using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioEstadios
    {   
        IEnumerable<Estadios> GetAllEstadios();
        Estadios AddEstadio(Estadios estadio);
        Estadios UpdateEstadio(Estadios estadio);
        void DeleteEstadio(int idEstadio);
        Estadios GetEstadio(int idEstadio);
    }
}