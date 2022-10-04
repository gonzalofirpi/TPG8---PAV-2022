using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorG8.Entidades
{
    public class Barrio
    {
        private int codigo;
        private string nombre;
        private int codLocalidad;
        private int codPostal;

        public Barrio() { }

        public int Codigo
        {
            get => this.codigo;
            set => this.codigo = value;
        }

        public string Nombre 
        {
            get => this.nombre;
            set => this.nombre = value;
        }

        public int Localidad
        {
            get => this.codLocalidad;
            set => this.codLocalidad = value;
        }

        public int CodPostal
        {
            get => this.codPostal; 
            set => this.codPostal = value;
        }
    }
}
