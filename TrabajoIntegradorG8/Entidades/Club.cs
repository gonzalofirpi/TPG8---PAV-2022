using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorG8.Entidades
{
    public class Club
    {
        private int id;
        private string nombre;
        private long nroCuit;
        private string calle;
        private int nroCalle;
        private int barrio;
        private DateTime fechaFundacion;

        public Club() { }


        public int Id
        {
            get => this.id;
            set => this.id = value;
        }

        public string Nombre
        {
            get => this.nombre;
            set => this.nombre = value;
        }

        public long NroCuit 
        {
            get => this.nroCuit;
            set => this.nroCuit = value;
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

        public int Barrio
        {
            get => this.barrio;
            set => this.barrio = value;
        }

        public DateTime FechaFundacion
        {
            get => this.fechaFundacion;
            set => this.fechaFundacion = value;
        }

        
        

    }
}
