using B2C.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace B2C.Controllers
{
    public class EventosController : Controller
    {
        // GET: Eventos

        public ActionResult Index()
        {

            return View();
        }

        //Listar todos los eventos existentes
        public ActionResult ListEvento()
        {
            return View(ObtenerEventosPrueba().AsEnumerable<Evento>());
        }

        //
        public ActionResult BusquedaEvento(String inCodigo,String inNombre, String inDescripcion, String inCiudad)
        {
        
            List<Evento> eventosExistentes = ObtenerEventosPrueba();
            List<Evento> eventos = new List<Evento>();

            foreach (var e in eventosExistentes)
            {
                Boolean flag = true;
                if (flag && !String.IsNullOrEmpty(inCodigo))
                {
                    if (!e.Codigo.Equals(inCodigo))
                    {
                        flag = false;
                    }
                }

                if (flag && !String.IsNullOrEmpty(inDescripcion))
                {
                    if (!e.Descripcion.ToLower().Contains(inDescripcion.ToLower()))
                    {
                        flag = false;
                    }
                }

                if (flag && !String.IsNullOrEmpty(inCiudad))
                {
                    if (!e.Ciudad.ToLower().Contains(inCiudad.ToLower()))
                    {
                        flag = false;
                    }
                }

                if (flag && !String.IsNullOrEmpty(inNombre))
                {
                    if (!e.Nombre.ToLower().Contains(inNombre.ToLower()))
                    {
                        flag = false;
                    }
                }

                if (flag)
                {
                    eventos.Add(e);
                }
            }
            return View(eventos.AsEnumerable<Evento>());
        }

        //Listar el top 5 de eventos
        public ActionResult ListTop5()
        {
            List<Evento> Dates = new List<Evento>();
            for (int i = 0; i < 5; i++)
            {
                Evento evento = new Evento
                {
                    Nombre = "Top_nombre" + i.ToString(),
                    Descripcion = "Top_Descripcion" + i.ToString(),
                    Precio = i,
                    Ciudad = "Top_Ciudad" + i.ToString(),
                    Imagen = "Top_Imagen" + i.ToString(),
                    Tipo = "Top_Tipo" + i.ToString()
                };
                Dates.Add(evento);
            }
            return View(Dates.AsEnumerable<Evento>());
        }

        //Consulta el detalle del evento
        public ActionResult VerDetalleEvento(String inCodigo)
        {
            Evento evento = new Evento
            {
                Nombre = "Top_nombre:" + inCodigo,
                Descripcion = "Top_Descripcion:" + inCodigo,
                Precio = 100000000,
                Ciudad = "Top_Ciudad:" + inCodigo,
                Imagen = "Top_Imagen:" + inCodigo,
                Tipo = "Top_Tipo: " + inCodigo
            };

            return View(evento);
        }

        private List<Evento> ObtenerEventosPrueba()
        {
            List<Evento> listaEventoPrueba = new List<Evento>();

            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                Evento evento = new Evento()
                {
                    Nombre = "Lorem ipsum dolor sit amet, consectetuer adipiscin",
                    Descripcion = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean m",
                    Precio = rnd.Next(100000, 100000000),
                    Ciudad = "Manizales",
                    Imagen = "Null",
                    Tipo = "Futbol",
                    Codigo = i.ToString()
                };
                listaEventoPrueba.Add(evento);
            }
            return listaEventoPrueba;
        }


    }
}