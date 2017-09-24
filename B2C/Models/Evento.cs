using System;

namespace B2C.Models
{
    public class Evento
    {
 

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public string Ciudad { get; set; }
        public string Imagen { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }


        public Evento()
        {
        }
        public Evento(string codigo, string nombre, string descripcion, float precio, string ciudad, string imagen, string tipo, DateTime fecha)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Ciudad = ciudad;
            this.Imagen = imagen;
            this.Tipo = tipo;
            this.Fecha = fecha;
        }

    }
}