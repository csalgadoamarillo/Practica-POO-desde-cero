using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica_POO_desde_cero.Models; 

namespace Practica_POO_desde_cero.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            Persona carlos = new Persona();
            carlos.Nombres = "Carlos Guillermo";

            string saludo1 = carlos.Saludar();
            string saludo2 = carlos.SaludarA("Ana");
            string NivelAcademico = carlos.GradoAcademicoCarrera();
            string Saludo3 = carlos.NombresCompletos(); 

            ViewBag.Saludo1 = saludo1;
            ViewBag.Saludo2 = saludo2;
            ViewBag.NivelAcademico = NivelAcademico;
            ViewBag.Saludo3 = Saludo3;

            return View();
        }
    }
}