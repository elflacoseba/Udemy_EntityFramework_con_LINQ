using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practicas_LINQ.Models;
using Practicas_LINQ.Repositorio;

namespace Practicas_LINQ.Clases
{
    public class S4C12
    {
        public void MuestraDatos()
        {
            List<Estudiante> estudiantes = new EstudianteRepositorio().GetEstudiantes();

            Console.WriteLine("SELECT() nos permite seleccionar campos específicos.\n");

            var e = estudiantes.Select(x => new { x.Id, x.Nombre, x.Materia });

            foreach (var item in e)
            {
                Console.WriteLine($"ID: {item.Id}, Nombre: {item.Nombre}, Materia: {item.Materia}");
            }
        }


    }
}
