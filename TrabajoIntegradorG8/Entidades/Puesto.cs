using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorG8.Entidad
{
    class Puesto
    {
        private int codigo;
        private string nombre;

        public Puesto() { } 

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
    }
}
