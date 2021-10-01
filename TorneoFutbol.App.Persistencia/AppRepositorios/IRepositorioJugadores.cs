using System.Collections.Generic;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public interface IRepositorioJugadores
    {   
        IEnumerable<Jugadores> GetAllJugadores();
        Jugadores AddJugador(Jugadores jugador);
        Jugadores UpdateJugador(Jugadores jugador);
        void DeleteJugador(int idJugador);
        Jugadores GetJugador(int idJugador);
    }
}