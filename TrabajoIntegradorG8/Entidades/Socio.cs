using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorG8.Entidades
{
    public class Socio
    {
        private int id;
        private string nombre;
        private string apellido;
        private string calle;
        private int nroCalle;
        private int barrio;
        private DateTime fechaNacimiento;

        public Socio() { }


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

        public string Apellido 
        {
            get => this.apellido;
            set => this.apellido = value;
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

        public DateTime FechaNacimiento
        {
            get => this.fechaNacimiento;
            set => this.fechaNacimiento = value;
        }

        
        

    }
}