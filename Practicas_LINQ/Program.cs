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

            //foreach (Estudiante e in estudiantes )
            //{
            //    Console.WriteLine($"ID: {e.Id.ToString().PadLeft(2,' ')},\t Nombre: {(e.Nombre + ",").PadRight(20,' ')} Materia: {e.Materia}");
            //}

            //select() nos permite seleccionar campos específicos

            //var e = estudiantes.Select( x => new { x.Id, x.Nombre, x.Materia });

            //foreach (var item in e)
            //{
            //    Console.WriteLine($"ID: {item.Id}, Nombre: {item.Nombre}, Materia: {item.Materia}");
            //}

            //where nos permite filtrar resultados de la consulta en base a evaluaciones que nosotros proporcionemos
            //Seleccionar unicamente materia programación

            //var resultado = estudiantes.Where(x => x.Materia.Contains("Programación")).ToList();

            //foreach (var item in resultado)
            //{
            //    Console.WriteLine($"ID: {item.Id}, Nombre: {item.Nombre}, Materia: {item.Materia}");
            //}

            //Mostrar Estudiantes con Nota 1 mayor o igual a 7

            var resultado = estudiantes.Where(x => x.Nota1 >= 7).ToList();

            foreach (var item in resultado)
            {
                Console.WriteLine($"ID: {item.Id}, Nombre: {item.Nombre}, Materia: {item.Materia}, Nota 1: {item.Nota1}");
            }

            Console.ReadKey();
        }
    }
}
