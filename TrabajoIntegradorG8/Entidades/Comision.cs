using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorG8
{
    internal class Comision
    {
        private int idClub;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private int idVocal1;
        private int idVocal2;
        private int idVocal3;
        private int idPresidente;
        private int idSecretario;
        private int idTesorero;


        public Comision() { }

        public int IdClub
        {
            get => this.idClub;
            set => this.idClub = value;
        }

        public DateTime FechaDesde
        {
            get => this.fechaDesde;
            set => this.fechaDesde = value;
        }

        public DateTime FechaHasta
        {
            get => this.fechaHasta;
            set => this.fechaHasta = value;
        }

        public int IdVocal1
        {
            get => this.idVocal1;
            set => this.idVocal1 = value;
        }

        public int IdVocal2
        {
            get => this.idVocal2;
            set => this.idVocal2 = value;
        }

        public int IdVocal3
        {
            get => this.idVocal3;
            set => this.idVocal3 = value;
        }

        public int IdPresidente
        {
            get => this.idPresidente;
            set => this.idPresidente = value;
        }

        public int IdSecretario
        {
            get => this.idSecretario;
            set => this.idSecretario = value;
        }

        public int IdTesorero
        {
            get => this.idTesorero;
            set => this.idTesorero = value;
        }
    }
}
