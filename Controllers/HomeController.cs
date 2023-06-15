using Microsoft.AspNetCore.Mvc;

namespace TP5.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Creditos()
    {
        return View("Creditos");
    }
   public IActionResult Tutorial()
    {
        return View("Tutorial");
    }
    public IActionResult Comenzar()
    {
        int salaProxima = Escape.GetEstadoJuego();  
        salaProxima = 1;
        switch(salaProxima)
        {
            case 1: return View("sala1");
            case 2: return View("sala2");
            case 3: return View("sala3");
            case 4: return View("sala4");
        }
        return View();
    }
    [HttpPost]
    public IActionResult Habitacion(int sala, string clave)
    {
        if(sala != Escape.GetEstadoJuego()){ 
            switch(Escape.GetEstadoJuego())
            {
                case 1: return View("sala1");
                case 2: return View("sala2");
                case 3: return View("sala3");
                case 4: return View("sala4");
            }
            return View("sala1");
        }
        else{  
            if(Escape.ResolverSala(sala,clave)){
                if(Escape.GetEstadoJuego() > 4) return View("Victoria");
                else return View("sala" + Escape.GetEstadoJuego());
            }
            else{
                ViewBag.Error = "La respuesta es incorrecta";
                return View("sala" + Escape.GetEstadoJuego());
            }
        }
    }
}
