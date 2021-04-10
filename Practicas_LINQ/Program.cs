using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practicas_LINQ.Models;
using Practicas_LINQ.Repositorio;

namespace Practicas_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new EstudianteRepositorio().GetEstudiantes();

            foreach (Estudiante e in estudiantes )
            {
                Console.WriteLine($"ID: {e.Id.ToString().PadLeft(2,' ')},\t Nombre: {(e.Nombre + ",").PadRight(20,' ')} Materia: {e.Materia}");
            }

            Console.ReadKey();
        }
    }
}
