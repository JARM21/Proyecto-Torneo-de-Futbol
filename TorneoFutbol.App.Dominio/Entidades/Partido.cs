using System.Collections.Generic;
using System;
namespace TorneoFutbol.App.Dominio
{
     
    public class Partido
    {
        public int Id { get; set; }
        public DateTime FechaYHora { get; set; }
        public Equipo EquipoLocal { get; set; }
        public int MarcadorInicialLocal { get; set; }
        public Equipo EquipoVisitante { get; set; }
        public int MarcadorInicialVisitante { get; set; }
        public Estadio Estadio { get; set; }
        public Arbitro Arbitro { get; set; }
        public int MarcadorFinal { get; set; }
        public List<InformacionPartido> InformacionPartido { get; set; }
    }
}