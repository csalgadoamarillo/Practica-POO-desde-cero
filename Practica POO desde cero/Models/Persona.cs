using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica_POO_desde_cero.Models
{
    public interface IAlumno
    {
        string NombresCompletos();
        string GradoAcademicoCarrera();
    }

    public class Persona : IAlumno
        {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string GradoAcademico { get; set; }
        public string Carrera { get; set; }
        public string GradoAcademicoCarrera()
        {
            return GradoAcademico + "en" + Carrera;
        }
        public string Saludar()
        {
            return "Hola, soy" + Nombres;
        }
        public string SaludarA(string nombrePersona)
        {
            return "Hola" + nombrePersona + ", soy " + Nombres;
        }
        public string NombresCompletos()
        { 
           return "Y mi nombre completo es: " + Nombres + Apellidos;
        } 
             
        
    }
}