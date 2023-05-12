using Microsoft.AspNetCore.Mvc;

namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.EquiposIndumentaria = Equipos.EquiposIndumentaria;
        return View();
    }
    public IActionResult SeleccionarIndumentaria()
    {
        ViewBag.ListaEquipos = Equipos.ListaEquipos;
        ViewBag.ListaRemeras = Equipos.ListaRemeras;
        ViewBag.ListaPantalones = Equipos.ListaPantalones;
        ViewBag.ListaMedias = Equipos.ListaMedias;
        return View();
    }
    public IActionResult GuardarIndumentaria(int Equipo, int Remera, int Pantalon, int Medias)
    {
    indumentaria nuevoEquipoConjunto = new indumentaria(Equipos.ListaMedias[Medias-1], Equipos.ListaRemeras[Remera-1], Equipos.ListaPantalones[Pantalon-1]);
       if(Equipos.IngresarIndumentaria(Equipos.ListaEquipos[Equipo-1], nuevoEquipoConjunto) == false) ViewBag.MensajeError("Hubo un error");
    ViewBag.EquiposIndumentaria = Equipos.EquiposIndumentaria;
       return View("Index");
    }
    
}
