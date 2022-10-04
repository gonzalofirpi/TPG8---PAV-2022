using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorG8
{
    internal class Localidad
    {
        private int codigo;
        private string nombre;


        public Localidad() { }

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
