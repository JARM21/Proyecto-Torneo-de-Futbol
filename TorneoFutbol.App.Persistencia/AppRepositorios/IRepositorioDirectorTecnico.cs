using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioDirectorTecnico
    {
        IEnumerable<DirectoresTecnicos> GetAllDirectoresTecnicos();

        DirectoresTecnicos AddDirectoresTecnicos(DirectoresTecnicos DirectoresTecnicos);

        DirectoresTecnicos UpdateDirectoresTecnicos(DirectoresTecnicos DirectoresTecnicos);

        void DeleteDirectoresTecnicos(int IdDirectoresTecnicos);

        DirectoresTecnicos GetDirectoresTecnicos(int IdDirectoresTecnicos);
    }
}