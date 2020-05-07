using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal_EstDatos.Clases
{
    public class Paciente : IComparable
    {
        #region Varibales
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Edad { get; set; }
        public long DPI { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string Sintomas { get; set; }
        public string Descripcion { get; set; }
        public bool Prueba { get; set; }
        public string Estado { get; set; }
        public int Prioridad { get; set; }
        public string Hospital { get; set; }
        public int Posicion { get; set; }
        #endregion
        #region Metodos
        public bool ExamenCovid19()
        {
            
            int Probablidiad = 5;
            string Descrip = Descripcion.ToLower();
            if (Descrip.Contains("confirmado"))
            {
                Prueba = true;
                return Prueba;
            }
            Random NumRandom = new Random();
            int Parametro = NumRandom.Next(1, 100);
            if (Descrip.Contains("viaje a europa"))
                Probablidiad += 10;
            if (Descrip.Contains("conocido contagiando"))
                Probablidiad += 15;
            if (Descrip.Contains("familiar contagiado"))
                Probablidiad += 30;
            if (Descrip.Contains("reunion social con sospechoso"))
                Probablidiad += 5;
            if (Parametro <= Probablidiad)
                Prueba = true;
            else
                Prueba = false;
            return Prueba;
        }
        public int ObtenerHospital()
        {
            if (Departamento == "Chimaltenango" || Departamento == "Guatemala" || Departamento == "Sacatepéquez")
            {
                Hospital = "Hosp. Guatemala";
                return 1;
            }
            else if (Departamento == "Quetzaltenango" || Departamento == "Totonicapán" || Departamento == "San Marcos" || Departamento == "Huehuetenango")
            {
                Hospital = "Hosp. Quetzaltenango";
                return 2;
            }
            else if (Departamento == "Izabal" || Departamento == "Zacapa" || Departamento == "Chiquimula" || Departamento == "Jalapa" || Departamento == "El Progreso")
            {
                Hospital = "Hosp. Zacapa";
                return 3;
            }
            else if (Departamento == "Escuintla" || Departamento == "Jutiapa" || Departamento == "Santa Rosa" || Departamento == "Suchitepéquez" || Departamento == "Retalhuleu")
            {
                Hospital = "Hosp. Escuintla";
                return 4;
            }
            else
            {
                Hospital = "Hosp. Petén";
                return 5;
            }
        }
        public void CalcularPrioridad()
        {
            if (Prueba && Edad >= 60)
                Prioridad = 8;
            else if (Prueba && Edad <= 1)
                Prioridad = 7;
            else if (Prueba && Edad < 60 && Edad <= 18)
                Prioridad = 6;
            else if (Prueba && Edad <= 17)
                Prioridad = 5;
            else if (Edad >= 60)
                Prioridad = 4;
            else if (Edad <= 1)
                Prioridad = 3;
            else if (Edad < 60 && Edad >= 18)
                Prioridad = 2;
            else if (Edad <= 17)
                Prioridad = 1;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Comparadores
        public Comparison<Paciente> BuscarPrioridad = delegate (Paciente Paciente1, Paciente Paciente2)
        {
            return Paciente1.Prioridad.CompareTo(Paciente2.Prioridad);
        };
        public Comparison<Paciente> BuscarNombre = delegate (Paciente Paciente1, Paciente Paciente2)
        {
            return Paciente1.Nombre.CompareTo(Paciente2.Nombre);
        };
        public Comparison<Paciente> BuscarApellido = delegate (Paciente Paciente1, Paciente Paciente2)
        {
            return Paciente1.Apellido.CompareTo(Paciente2.Apellido);
        };
        public Comparison<Paciente> ConteinsNombre = delegate (Paciente Paciente1, Paciente Paciente2)
        {
            if (Paciente1.Nombre.Contains(Paciente2.Nombre))
                return 0;
            else
                return 1;
        };
        public Comparison<Paciente> ConteinsApellido = delegate (Paciente Paciente1, Paciente Paciente2)
        {
            if (Paciente1.Apellido.Contains(Paciente2.Apellido))
                return 0;
            else
                return 1;
        };
        public Comparison<Paciente> BuscarDPI = delegate (Paciente Paciente1, Paciente Paciente2)
        {
            return Paciente1.DPI.CompareTo(Paciente2.DPI);
        };
        #endregion
    }

}
