using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LaboratorioMVC.Models;

namespace LaboratorioMVC.Controllers
{
    public class personasIntermedioController : Controller
    {
        Entities baseDatos = new Entities();
        // GET: personasIntermedio
        public ActionResult Index()
        {
            ModeloIntermedio modelo = new ModeloIntermedio();
            modelo.listaPersonas = baseDatos.persona.ToList();
            modelo.listaTelefonos = baseDatos.telefono.ToList();
            modelo.listaCuenta = baseDatos.cuenta.ToList();
            return View(modelo);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModeloIntermedio modelo)
        {
            if (ModelState.IsValid)
            {
                baseDatos.persona.Add(modelo.modeloPersona);
                baseDatos.SaveChanges();
                if (modelo.modeloTel1.telefono1 != null)
                {
                    modelo.modeloTel1.cedula = modelo.modeloPersona.cedula;
                    baseDatos.telefono.Add(modelo.modeloTel1);
                }
                if (modelo.modeloTel2.telefono1 != null)
                {
                    modelo.modeloTel2.cedula = modelo.modeloPersona.cedula;
                    baseDatos.telefono.Add(modelo.modeloTel2);
                }
                if (modelo.modeloCuenta1.numero != null)
                {
                    modelo.modeloCuenta1.cedula = modelo.modeloPersona.cedula;
                    baseDatos.cuenta.Add(modelo.modeloCuenta1);
                }
                if (modelo.modeloCuenta2.numero != null)
                {
                    modelo.modeloCuenta2.cedula = modelo.modeloPersona.cedula;
                    baseDatos.cuenta.Add(modelo.modeloCuenta2);
                }
                if (modelo.modeloCuenta3.numero != null)
                {
                    modelo.modeloCuenta3.cedula = modelo.modeloPersona.cedula;
                    baseDatos.cuenta.Add(modelo.modeloCuenta3);
                }
                baseDatos.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Debe completar toda la información necesaria.");
                return View(modelo);
            }
        }
    }
}