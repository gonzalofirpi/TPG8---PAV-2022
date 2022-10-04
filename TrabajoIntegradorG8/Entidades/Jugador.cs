using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorG8.Entidades
{
    public class Jugador
    {
        private int idJugador;
        private int idSocio;
        private int idClub;

        public Jugador() { }

        public int IdJugador
        {
            get => this.idJugador;
            set => this.idJugador = value;
        }

        public int IdSocio 
        {
            get => this.idSocio;
            set => this.idSocio = value;
        }

        public int IdClub
        {
            get => this.idClub;
            set => this.idClub = value;
        }

    }
}