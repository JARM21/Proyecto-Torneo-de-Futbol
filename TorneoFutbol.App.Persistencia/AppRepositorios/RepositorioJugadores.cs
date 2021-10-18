using System;
using System.Collections.Generic;
using System.Linq;
using TorneoFutbol.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace TorneoFutbol.App.Persistencia
{
    public class RepositorioJugadores : IRepositorioJugadores
    {
        private readonly AppContext _appContext = new AppContext();
    
        Jugador IRepositorioJugadores.AddJugador(Jugador jugador)
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

        IEnumerable<Jugador> IRepositorioJugadores.GetAllJugador()
        {
            return _appContext.Jugadores;
        }

        Jugador IRepositorioJugadores.GetJugador(int idJugador)
        {
            var jugador = _appContext.Jugadores
                .Where(j => j.Id == idJugador)
                .Include(j => j.Equipo)
                .FirstOrDefault();
            return jugador;
            //return _appContext.Jugadores.FirstOrDefault(e=>e.Id==idJugador);
            
        }

        Jugador IRepositorioJugadores.UpdateJugador(Jugador jugador)
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

        Equipo IRepositorioJugadores.AsignarEquipo(int idJugador, int idEquipo)
        {
            var jugadorEncontrado = _appContext.Jugadores.Find(idJugador);
            if (jugadorEncontrado != null)
            { var equipoEncontrado = _appContext.Equipos.Find(idEquipo);
            if (equipoEncontrado != null)
            { jugadorEncontrado.Equipo = equipoEncontrado;
            _appContext.SaveChanges();
            }
            return equipoEncontrado;
            }
            return null; 
        }
    }
}