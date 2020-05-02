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
        public int Departamento { get; set; }
        public string Nombre { get; set; }
        public string Sintomas { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public int IdLista { get; set; }
    }
}
