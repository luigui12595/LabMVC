using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LaboratorioMVC.Models;

namespace LaboratorioMVC.Models
{
    public class ModeloIntermedio
    {
        public persona modeloPersona { get; set; }
        public telefono modeloTel1 { get; set; }
        public telefono modeloTel2 { get; set; }
        public cuenta modeloCuenta1 { get; set; }
        public cuenta modeloCuenta2 { get; set; }
        public cuenta modeloCuenta3 { get; set; }
        public List<persona> listaPersonas = new List<persona>();
        public List<telefono> listaTelefonos = new List<telefono>();
        public List<cuenta> listaCuenta = new List<cuenta>();
    }
}