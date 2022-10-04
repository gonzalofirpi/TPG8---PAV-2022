using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorG8.Entidades
{
    internal class Canchas
    {
        private int nroCancha;
        private int idClub;
        private string calle;
        private int nroCalle;
        private int codBarrio;
        private int codPiso;
        private int codEstado;
        private DateTime fechaUltMant;

        public Canchas() { }


        public int NroCancha
        {
            get => this.nroCancha;
            set => this.nroCancha = value;
        }

        public int Idclub
        {
            get => this.idClub;
            set => this.idClub = value;
        }

        public int CodBarrio
        {
            get => this.codBarrio;
            set => this.codBarrio = value;
        }

        public string Calle
        {
            get => this.calle;
            set => this.calle = value;
        }

        public int NroCalle
        {
            get => this.nroCalle;
            set => this.nroCalle = value;
        }

        public int CodPiso
        {
            get => this.codPiso;
            set => this.codPiso = value;
        }

        public DateTime FechaUltMant
        {
            get => this.fechaUltMant;
            set => this.fechaUltMant = value;
        }
        public int CodEstado
        {
            get => this.codEstado;
            set => this.codEstado = value;
        }
    }
      
}
