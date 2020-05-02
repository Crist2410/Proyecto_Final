using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoFinal_EstDatos.Clases;
using GenericosLibreria.Estruturas;

namespace ProyectoFinal_EstDatos.Clases
{
    public class Hospital
    {
        public string Nombre { get; set; }
        public TablaHash<Paciente> Camas = new TablaHash<Paciente>();
        public ColaPrioridad<Paciente> EsperaConfrimados = new ColaPrioridad<Paciente>();
        public ColaPrioridad<Paciente> Sospechosos = new ColaPrioridad<Paciente>();

    }
}
