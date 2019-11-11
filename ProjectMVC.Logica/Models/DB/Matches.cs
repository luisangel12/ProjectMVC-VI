using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMVC.Logica.Models.DB
{
    public class Matches
    {
        public int Id { get; set; }

        public int Posicion { get; set; }

        public string Name { get; set; }

        public int Puntos { get; set; }

        public int partidos_jugados { get; set; }

        public int Goles_a_Favor { get; set; }

        public int Goles_en_Contra { get; set; }

        public int Partidos_Ganados { get; set; }

        public int Partidos_Perdidos { get; set; }

        public int Diferencia_de_Goles { get; set; }
    }
}
