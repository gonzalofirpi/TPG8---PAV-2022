using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorG8.Entidades
{
    internal class Arbitro
    {
        private int codigo;
        private string nombre;
        private string apellido;
        

        public Arbitro() { }

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

        public string Apellido
        {
            get => this.apellido;
            set => this.apellido = value;
        }

    }
}

