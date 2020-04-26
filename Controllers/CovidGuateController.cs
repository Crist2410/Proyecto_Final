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
            };
            AuxPaciente.CalcularPrioridad();
            //Asignacion a Hospital Y Mostar Cola Sospechosos
            Hospital HospitalAux = Covid19.AsignarHospital(AuxPaciente);
            ViewBag.NombreHospital = HospitalAux.Nombre;
            ViewBag.Sospechosos = HospitalAux.Sospechosos.Mostrar();
            return View("PacientesSospechosos");
        }
        #endregion

        #region Hospitales
        public ActionResult Hospitales()
        {
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
            return View();
        }
        public ActionResult ColaConfirmados()
        {
            ViewBag.NombreHospital = HospitalActual.Nombre;
            ViewBag.Sospechosos = HospitalActual.Sospechosos.Mostrar();
            return View();
        }


        #endregion
        // GET: CovidGuate
        public ActionResult Index()
        {
            return View();
        }

        // GET: CovidGuate/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CovidGuate/Create
        public ActionResult Create()
        {
            return View();
        }

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