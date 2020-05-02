using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoFinal_EstDatos.Clases;
using GenericosLibreria.Estruturas;

namespace ProyectoFinal_EstDatos.Clases
{
    public class Cama
    {
        public int Id { get; set; }

        public Paciente PacienteCama = new Paciente();
        public string Estado { get; set; }
        public string Nombre { get; set; }
        public string DPI { get; set; }

    }
}
