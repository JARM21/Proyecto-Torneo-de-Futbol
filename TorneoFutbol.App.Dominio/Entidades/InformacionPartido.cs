using System.Collections.Generic;

namespace TorneoFutbol.App.Dominio
{
     
    public class InformacionPartido
    {
        public int Id { get; set; }
        public Eventos Evento { get; set; }
        public int Minuto { get; set; }
<<<<<<< HEAD
        public Jugador JugadorInvolucrado { get; set; }
=======
        public Jugadores JugadorInvolucrado { get; set; }
        public Partidos Partido { get; set; }
>>>>>>> 14f503baa826c5b36d55961af0553170b41d8714
    }
}