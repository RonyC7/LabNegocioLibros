using System;

namespace LabNegocioLibros.Clases
{
    public class Libro
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public string Editorial { get; set; }
        public string Categoria { get; set; }
        public string Autor { get; set; }
    }
}
