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
        public ColaPrioridad<Paciente> EsperaConfrimados = new ColaPrioridad<Paciente>();
        public ColaPrioridad<Paciente> Sospechosos = new ColaPrioridad<Paciente>();
        public Cama[] Camas = new Cama[10];
        public bool ChequeoIngresar()
        {
            foreach (var item in Camas)
            if (item == null || item.PacienteCama ==null)
                return true;
            return false;
        }
        public Cama Añadir( Paciente AuxPaciente)
        {
            Cama AuxCama = new Cama();
            int Posicion = AuxPaciente.ObtenerHospital();
            Posicion = (Posicion * 10) - 10;
            for (int i = 0; i < 10; i++)
            {
                if (Camas[i] == null || Camas[i].PacienteCama == null)
                {
                    AuxCama.PacienteCama = AuxPaciente;
                    AuxCama.Id = Posicion + i;
                    AuxCama.Estado = "Ocupada";
                    AuxCama.Nombre = AuxPaciente.Nombre + " " + AuxPaciente.Apellido;
                    AuxCama.DPI = Convert.ToString(AuxPaciente.DPI);
                    Camas[i] = AuxCama ;
                    i = 10;
                }
            }
            return AuxCama;
        }
    }
}
