using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        //ATRIBUTO
        private decimal precio;

        //PROPIEDADES CON SUS ANNOTATIONS
        public int Id { get; set; }
        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        [DisplayName("Categoría")]
        public Categoria Categoria { get; set; }
        public Marca Marca { get; set; }

        //PROPIEDAD para que el precio aparezca con la forma que escribimos en Argentina
        [DisplayName("Precio sin formatear")]
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        [DisplayName("Precio")]
        public string PrecioFormateado
        {
            get { return precio.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")); }
        }



    }
}
