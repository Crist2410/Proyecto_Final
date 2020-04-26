using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibreriaGenerica.Estruturas;
using ProyectoFinal_EstDatos.Clases;

namespace ProyectoFinal_EstDatos.Models
{
    public class CovidGuate
    {
        public Hospital HGuatemla = new Hospital() { Nombre = "Hospital de Guatemala"};
        public Hospital HQuetzaltenango = new Hospital() { Nombre = "Hospital de Quetzaltenango" };
        public Hospital HPeten = new Hospital() { Nombre = "Hospital de Petén" };
        public Hospital HEscuintla = new Hospital() { Nombre = "Hospital de Escuintla" };
        public Hospital HZacapa = new Hospital() { Nombre = "Hospital de Zacapa" };
        public Estadisticas EstadisticasGeneral = new Estadisticas();
        #region Metodos
       public Hospital AsignarHospital(Paciente AuxPaciente)
       {
            Hospital HAux;
            int NumeroH = AuxPaciente.ObtenerHospital();
            if (NumeroH == 1)
            {
                HGuatemla.Sospechosos.Add(AuxPaciente, AuxPaciente.BuscarPrioridad);
                HAux = HGuatemla;
            }
            else if (NumeroH  == 2)
            {
                HQuetzaltenango.Sospechosos.Add(AuxPaciente, AuxPaciente.BuscarPrioridad);
                HAux = HQuetzaltenango;
            }
            else if (NumeroH == 3)
            {
                HZacapa.Sospechosos.Add(AuxPaciente, AuxPaciente.BuscarPrioridad);
                HAux = HZacapa;
            }
            else if (NumeroH == 4)
            {
                HEscuintla.Sospechosos.Add(AuxPaciente, AuxPaciente.BuscarPrioridad);
                HAux = HEscuintla;
            }
            else 
            {
                HPeten.Sospechosos.Add(AuxPaciente, AuxPaciente.BuscarPrioridad);
                HAux = HPeten;
            }
            return HAux;
       }

        #endregion
    }
}
