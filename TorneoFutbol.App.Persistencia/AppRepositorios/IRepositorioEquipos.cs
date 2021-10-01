using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioEquipos
    {
        IEnumerable<Equipos> GetAllEquipos();

        Equipos AddEquipos(Equipos Equipos);

        Equipos UpdateEquipos(Equipos Equipos);

        void DeleteEquipos(int IdEquipos);

        Equipos GetEquipos(int IdEquipos);
    }
}