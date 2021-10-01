using System.Collections.Generic;
using System;
namespace TorneoFutbol.App.Dominio
{
     
    public class Partidos
    {
        public int Id { get; set; }
        public DateTime FechaYHora { get; set; }
        public Equipos EquipoLocal { get; set; }
        public int MarcadorInicialLocal { get; set; }
        public Equipos EquipoVisitante { get; set; }
        public int MarcadorInicialVisitante { get; set; }
        public Estadios Estadio { get; set; }
        public Arbitros Arbitro { get; set; }
        public int MarcadorFinal { get; set; }
        public List<InformacionPartido> InformacionPartido { get; set; }
    }
}