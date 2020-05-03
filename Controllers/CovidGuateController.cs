using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal_EstDatos.Clases;
using ProyectoFinal_EstDatos.Models;

namespace ProyectoFinal_EstDatos.Controllers
{
    public class CovidGuateController : Controller
    {
        public static CovidGuate Covid19 = new CovidGuate();
        public static Hospital HospitalActual = new Hospital();
        //public static Estadisticas CalcularEstadisticas = new Estadisticas();

        #region Ingrear Pacientes
        // Vista Ingresar Paciente
        public ActionResult IngresarPaciente()
        {
            return View();
        }
        // Guardar Paciente
        [HttpPost]
        public ActionResult GuardarPaciente(IFormCollection collection)
        {
            Paciente AuxPaciente = new Paciente()
            {
                Nombre = collection["Nombre"],
                Apellido = collection["Apellido"],
                Edad = Convert.ToInt32(collection["Edad"]),
                DPI = Convert.ToInt64(collection["DPI"]),
                Departamento = collection["Departamento"],
                Municipio = collection["Municipio"],
                Sintomas = collection["Sintomas"],
                Descripcion = collection["Descripcion"],
                Estado = "Sin Realizar Puebra"
            };
            AuxPaciente.CalcularPrioridad();
            //Asignacion a Hospital Y Mostar Cola Sospechosos
            if (!Covid19.AVLPacientes.ExiteValor(AuxPaciente, AuxPaciente.BuscarDPI))
            {
                HospitalActual = Covid19.AsignarHospital(AuxPaciente);
                Covid19.AVLPacientes.Add(AuxPaciente, AuxPaciente.BuscarDPI);
                Covid19.AVLNombre.Add(AuxPaciente, AuxPaciente.BuscarNombre);
                Covid19.AVLApellido.Add(AuxPaciente, AuxPaciente.BuscarApellido);
                ViewBag.NombreHospital = HospitalActual.Nombre;
                ViewBag.Sospechosos = HospitalActual.Sospechosos.Mostrar();
                ViewBag.Regresar = true;
                Covid19.EstadisticasGeneral.Sospechosos++;
                return View("PacientesSospechosos");
            }
            else
            {
                ViewBag.Error = "¡Paciente Repetido!";
                return View("IngresarPaciente", AuxPaciente);
            }

        }
        public ActionResult RealizarPrueba()
        {
            //try
            //{
                Paciente AuxPaciente = new Paciente();
                AuxPaciente = HospitalActual.Sospechosos.Delete(AuxPaciente.BuscarPrioridad);
                if (AuxPaciente.ExamenCovid19())
                {
                    AuxPaciente.Estado = "Confirmado de Covid-19";
                    Covid19.AVLPacientes.Edit(AuxPaciente, AuxPaciente.BuscarDPI);
                    Covid19.AVLNombre.Editar(AuxPaciente, AuxPaciente.BuscarNombre, AuxPaciente.BuscarDPI); ;
                    Covid19.AVLApellido.Editar(AuxPaciente, AuxPaciente.BuscarApellido, AuxPaciente.BuscarDPI);
                    if (HospitalActual.ChequeoIngresar())
                    {
                        Cama AuxCama = HospitalActual.Añadir(AuxPaciente);
                        Covid19.CamasPacientes.Añadir(AuxCama, AuxCama.Id);
                        ViewBag.Descripcion = "PACIENTE POSITIVO PARA COVID-19,";
                        ViewBag.Descripcion2 = "Fue Trasladado a Una Cama del " + HospitalActual.Nombre;
                    }
                    else
                    {
                        HospitalActual.EsperaConfrimados.Add(AuxPaciente, AuxPaciente.BuscarPrioridad);
                        ViewBag.Descripcion = "PACIENTE POSITIVO PARA COVID-19";
                        ViewBag.Descripcion2 = "Fue Trasladado a Lista de Espera Mienstras se Habilita una Cama";
                    }
                    Covid19.EstadisticasGeneral.Contagiados++;
                }
                else
                {
                    //Libre 
                    ViewBag.Descripcion = "EL PACIENTE NO TIENE EL VIRUS COVID-19";
                    AuxPaciente.Estado = "Libre de Covid-19";
                    Covid19.AVLPacientes.Edit(AuxPaciente, AuxPaciente.BuscarDPI);
                    Covid19.AVLNombre.Editar(AuxPaciente, AuxPaciente.BuscarNombre, AuxPaciente.BuscarDPI);
                    Covid19.AVLApellido.Editar(AuxPaciente, AuxPaciente.BuscarApellido, AuxPaciente.BuscarDPI);
                }
                Covid19.EstadisticasGeneral.PruebasRealizadas++;
                return View(AuxPaciente);
            //}
            //catch (Exception)
            //{
            //    return View("Index");
            //}
           
        }
        public ActionResult BuscarPaciente()
        {
            ViewBag.Pacientes = Covid19.AVLPacientes.Mostrar();
            return View();
        }
        public ActionResult MostrarEstadisticas()
        {
            try
            {
                double Porcentaje = ((Covid19.EstadisticasGeneral.Contagiados / Covid19.EstadisticasGeneral.PruebasRealizadas) * 100);
                Covid19.EstadisticasGeneral.PorcentajePositivos = Convert.ToString(Porcentaje) + "%";
            }
            catch (Exception)
            {
                Covid19.EstadisticasGeneral.PorcentajePositivos ="0.00%";
            }
            return View(Covid19.EstadisticasGeneral);
        }

        public ActionResult CurarPaciente(int Posicion)
        {
            Cama AuxCama = HospitalActual.Camas[Posicion];
            HospitalActual.Camas[Posicion] = null;
            Covid19.CamasPacientes.Borrar(AuxCama.Id);
            Paciente AuxPaciente = AuxCama.PacienteCama;
            AuxPaciente.Estado = "Recuperado de Covid-19";
            Covid19.AVLPacientes.Edit(AuxPaciente, AuxPaciente.BuscarDPI);
            Covid19.AVLNombre.Editar(AuxPaciente, AuxPaciente.BuscarNombre, AuxPaciente.BuscarDPI);
            Covid19.AVLApellido.Editar(AuxPaciente, AuxPaciente.BuscarApellido, AuxPaciente.BuscarDPI);
            Covid19.EstadisticasGeneral.Recuperados++;
            return View( AuxPaciente);
        }

        public ActionResult RealizarBusqueda(string Buscar, string Texto)
        {
            Paciente AuxPaciente = new Paciente();
            if (Buscar == "N")
            {
                AuxPaciente.Nombre = Texto;
                ViewBag.Pacientes = Covid19.AVLNombre.Filtrar(AuxPaciente.BuscarNombre, AuxPaciente);
            }
            else if (Buscar == "A")
            {
                AuxPaciente.Apellido = Texto;
                ViewBag.Pacientes = Covid19.AVLApellido.Filtrar(AuxPaciente.BuscarApellido, AuxPaciente);
            }
            else
            {
                try
                {
                    AuxPaciente.DPI = Convert.ToInt64(Texto);
                    ViewBag.Pacientes = Covid19.AVLPacientes.Get(AuxPaciente, AuxPaciente.BuscarDPI);
                }
                catch (Exception)
                {
                    List<Paciente> ListaError = new List<Paciente>();
                    ViewBag.Pacientes = ListaError;
                    return View("BuscarPaciente");
                }
            }
            return View("BuscarPaciente");
        }
        #endregion

        #region Hospitales
        public ActionResult Hospitales()
        {
            HospitalActual = new Hospital();
            return View();
        }
        public ActionResult MostrarTablaHash()
        {
           Cama[] ListaCamas = Covid19.CamasPacientes.Mostrar();
            for (int i = 0; i < 50; i++)
                if (ListaCamas[i]== null || ListaCamas[i].PacienteCama == null)
                {
                    ListaCamas[i] = new Cama() { Id = (i + 1), Nombre = "Cama", DPI = "Vacia", Estado ="Disponible"};
                }
            ViewBag.Tabla = ListaCamas;
            return View();
        }
        public ActionResult MostrarHospital()
        {
            ViewBag.NombreHospital = HospitalActual.Nombre;
            return View();
        }
        public ActionResult SeleccionarHospital(int id)
        {
            if (id == 1)
                HospitalActual = Covid19.HGuatemla;
           else if (id == 2)
                HospitalActual = Covid19.HQuetzaltenango;
            else if (id == 3)
                HospitalActual = Covid19.HPeten;
           else if (id == 4)
                HospitalActual = Covid19.HEscuintla;
            else 
                HospitalActual = Covid19.HZacapa;
            ViewBag.NombreHospital = HospitalActual.Nombre;
            return View("MostrarHospital");
        }
        public ActionResult PacientesSospechosos()
        {
            ViewBag.NombreHospital = HospitalActual.Nombre;
            ViewBag.Sospechosos = HospitalActual.Sospechosos.Mostrar();
            ViewBag.Regresar = false;
            return View();
        }
        public ActionResult ColaConfirmados()
        {
            ViewBag.NombreHospital = HospitalActual.Nombre;
            ViewBag.ColaConfirmados = HospitalActual.EsperaConfrimados.Mostrar();
            return View();
        }
        public ActionResult CamasHospital()
        {
            ViewBag.NombreHospital = HospitalActual.Nombre;
            Cama[] ListaCamas = HospitalActual.Camas;
            Paciente[] ListaPacientes = new Paciente[10];
            for (int i = 0; i < 10; i++)
                if (ListaCamas[i] == null || ListaCamas[i].PacienteCama == null )
                {
                    ListaPacientes[i] = new Paciente() { Posicion = (i + 1), Nombre = "Cama", Apellido = "Vacia" };
                }
                else
                {
                    ListaPacientes[i] = ListaCamas[i].PacienteCama;
                    ListaPacientes[i].Posicion = (i + 1);
                }
            ViewBag.Confirmados = ListaPacientes;
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        #endregion


        // POST: CovidGuate/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CovidGuate/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CovidGuate/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CovidGuate/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CovidGuate/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}