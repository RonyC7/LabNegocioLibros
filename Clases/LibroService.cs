using System.Collections.Generic;

namespace LabNegocioLibros.Clases
{
    public class LibroService
    {
        private List<Libro> libros = new List<Libro>();

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public List<Libro> ObtenerLibros()
        {
            return libros;
        }
    }
}
