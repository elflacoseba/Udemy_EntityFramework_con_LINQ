using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practicas_LINQ.Models;
using Practicas_LINQ.Repositorio;

namespace Practicas_LINQ.Clases
{
    public class S4C13
    {
        public void MuestraDatos()
        {
            List<Estudiante> estudiantes = new EstudianteRepositorio().GetEstudiantes();

            Console.WriteLine("Sección 4 - Clase 13: WHERE() nos permite filtrar resultados de la consulta en base a evaluaciones que nosotros proporcionemos.\n");

            //Console.WriteLine("Seleccionar unicamente materia programación.\n");

            //var resultado = estudiantes.Where(x => x.Materia.Contains("Programación")).ToList();

            //foreach (var item in resultado)
            //{
            //    Console.WriteLine($"ID: {item.Id}, Nombre: {item.Nombre}, Materia: {item.Materia}");
            //}

            //Console.WriteLine("Mostrar estudiantes con Nota 1 mayor o igual a 7.\n");

            //var resultado = estudiantes.Where(x => x.Nota1 >= 7).ToList();

            //foreach (var item in resultado)
            //{
            //    Console.WriteLine($"ID: {item.Id}, Nombre: {item.Nombre}, Materia: {item.Materia}, Nota 1: {item.Nota1}");
            //}

            //Console.WriteLine("Mostrar estudiantes cuya nota 1 sea mayor que 6 y cuya nota 2 sea mayor a 7.\n");

            //var resultado = estudiantes.Where( x=> x.Nota1 > 6 && x.Nota2 > 7).ToList();

            //foreach (var item in resultado)
            //{
            //    Console.WriteLine($"ID: {item.Id}, Nombre: {item.Nombre}, Materia: {item.Materia}, Nota 1: {item.Nota1}, Nota 2: {item.Nota2}");
            //}

            Console.WriteLine("Mostrar estudiantes cuya materia sea Programación o Matemáticas.\n");

            var resultado = estudiantes.Where(x => x.Materia.Contains("Programación") || x.Materia.Contains("Matemáticas")).ToList();

            foreach (var item in resultado)
            {
                Console.WriteLine($"ID: {item.Id}, Nombre: {item.Nombre}, Materia: {item.Materia}");
            }

        }
    }
}
