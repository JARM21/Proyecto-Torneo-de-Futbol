using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioMunicipios
    {   
        IEnumerable<Municipios> GetAllMunicipios();
        Municipios AddMunicipio(Municipios municipio);
        Municipios UpdateMunicipio(Municipios municipio);
        void DeleteMunicipio(int idMunicipio);
        Municipios GetMunicipio(int idMunicipio);
    }
}