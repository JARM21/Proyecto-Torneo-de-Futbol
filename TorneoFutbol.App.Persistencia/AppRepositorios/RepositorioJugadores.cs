using System.Collections.Generic;
using System.Linq;
using TorneoFutbol.App.Dominio;

namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioJugadores : IRepositorioJugadores
    {
        private readonly AppContext _appContext;
        public RepositorioJugadores(AppContext appContext)
        {
            _appContext=appContext;
        }

        Jugadores IRepositorioJugadores.AddJugador(Jugadores jugador)
        {
            var jugadorAdicionado = _appContext.Jugadores.Add(jugador);
            _appContext.SaveChanges();
            return jugadorAdicionado.Entity;
        }

        void IRepositorioJugadores.DeleteJugador(int idJugador)
        {
            var jugadorEncontrado=_appContext.Jugadores.FirstOrDefault(e=>e.Id==idJugador);
            if(jugadorEncontrado==null)
                return;
            _appContext.Jugadores.Remove(jugadorEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Jugadores> IRepositorioJugadores.GetAllJugadores()
        {
            return _appContext.Jugadores;
        }

        Jugadores IRepositorioJugadores.GetJugador(int idJugador)
        {
            return _appContext.Jugadores.FirstOrDefault(e=>e.Id==idJugador);
            
        }

        Jugadores IRepositorioJugadores.UpdateJugador(Jugadores jugador)
        {
            var jugadorEncontrado=_appContext.Jugadores.FirstOrDefault(e=>e.Id==jugador.Id);
            if(jugadorEncontrado!=null)
            {
                jugadorEncontrado.Nombre = jugador.Nombre;
                jugadorEncontrado.Numero = jugador.Numero;
                jugadorEncontrado.Posicion = jugador.Posicion;
                
                _appContext.SaveChanges();
            }
            return jugadorEncontrado;
        }
    }
}