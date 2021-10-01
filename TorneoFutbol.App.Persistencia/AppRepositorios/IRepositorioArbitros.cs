using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioArbitros
    {   
        IEnumerable<Arbitros> GetAllArbitros();
        Arbitros AddArbitro(Arbitros arbitro);
        Arbitros UpdateArbitro(Arbitros arbitro);
        void DeleteArbitro(int idArbitro);
        Arbitros GetArbitro(int idArbitros);
    }
}