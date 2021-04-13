using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practicas_LINQ.Models;
using Practicas_LINQ.Repositorio;

namespace Practicas_LINQ.Clases
{
    public class S4C14
    {
        public void MuestraDatos()
        {
            Console.WriteLine("Sección 4 - Clase 14: SELECTMANY() Combina los elementos de dos estructuras como arreglos en una sola estructura.\n");

            Console.WriteLine("Crearemos 2 clases Escuela con 2 Estudiantes cada una y las combinaremos con SelectMany().\n");

            var escuelas = new[]
            { new Escuela()
                { Estudiantes = new []
                    {
                      new Estudiante() { Nombre = "Sebastián Serrisuela" },
                      new Estudiante() { Nombre = "Mariana Coronel" }
                    }
                },
                new Escuela()
                { Estudiantes = new []
                    {
                      new Estudiante() { Nombre = "Camila Serrisuela" },
                      new Estudiante() { Nombre = "Micaela Serrisuela" }
                    }
                }
            };


            var estudiantes = escuelas.SelectMany(x=> x.Estudiantes);

            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine($"{estudiante.Nombre}");
            }
        }

        class Estudiante
        {
            public string Nombre { get; set; }
        };

        class Escuela
        {
            public Estudiante[] Estudiantes { get; set; }
        };
    }
}
