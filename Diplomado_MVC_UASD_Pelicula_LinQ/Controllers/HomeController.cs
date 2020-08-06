using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diplomado_MVC_UASD_Pelicula_LinQ.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var peliculas = new List<Models.Pelicula>
            {
                new Models.Pelicula { Titulo ="The Godfather", Director="Francis Ford Coppola", AutorPrincipal = "Al Pacino", numAutores=30,Duracion=2,Estreno=1994 },
                new Models.Pelicula { Titulo ="The Shawshank", Director="Frank Darabont", AutorPrincipal = "Morgan Freeman", numAutores=15,Duracion=3,Estreno=1972 },
                new Models.Pelicula { Titulo ="The Matrix", Director="Lana Wachowski", AutorPrincipal = "Keanu Reeves", numAutores=15,Duracion=2.30,Estreno=1999 },
                new Models.Pelicula { Titulo ="City of God", Director="Fernando Meirelles", AutorPrincipal = "Alexandre Rodrigues", numAutores=10,Duracion=3,Estreno=2002 },
                new Models.Pelicula { Titulo ="Star Wars: Episode IV", Director="George Lucas", AutorPrincipal = "Harrison Ford", numAutores=20,Duracion=2.40,Estreno=2007 },
            };
            var resultPeliculas = from Pelicula in peliculas
                                  where Pelicula.Titulo.Contains("The")
                                  select Pelicula;
            return View(resultPeliculas);
        }
    }
}