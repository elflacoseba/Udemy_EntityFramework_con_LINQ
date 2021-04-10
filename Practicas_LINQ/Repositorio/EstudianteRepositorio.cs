using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practicas_LINQ.Models;

namespace Practicas_LINQ.Repositorio
{
    class EstudianteRepositorio
    {
        public List<Estudiante> GetEstudiantes()
        {
            List<Estudiante> Estudiantes = new List<Estudiante>()
            {
                new Estudiante { Id = 1, Nombre = "Juan Perez", Materia = "Programación", Nota1 = 10, Nota2 = 6.5, Nota3 = 5.7 },
                new Estudiante { Id = 2, Nombre = "Carlos Velez", Materia = "Matemáticas", Nota1 = 5, Nota2 = 7.8, Nota3 = 9 },
                new Estudiante { Id = 3, Nombre = "Jhoana Jimenez", Materia = "Programación", Nota1 = 3.5, Nota2 = 4.9, Nota3 = 8.5 },
                new Estudiante { Id = 4, Nombre = "Roberta Sanchez", Materia = "Matemáticas", Nota1 = 4.8, Nota2 = 9.8, Nota3 = 8.2 },
                new Estudiante { Id = 5, Nombre = "Bryan Armas", Materia = "Física", Nota1 = 9.8, Nota2 = 6.2, Nota3 = 1.6 },
                new Estudiante { Id = 6, Nombre = "Alejandra Gaybor", Materia = "Matemáticas", Nota1 = 4.9, Nota2 = 7.9, Nota3 = 7.9 },
                new Estudiante { Id = 7, Nombre = "Adriana Paz", Materia = "Química", Nota1 = 7.8, Nota2 = 4.6, Nota3 = 7.5 },
                new Estudiante { Id = 8, Nombre = "Carlos Fuentes", Materia = "Física", Nota1 = 9, Nota2 = 9.7, Nota3 = 3.2 },
                new Estudiante { Id = 9, Nombre = "David Correa", Materia = "Programación", Nota1 = 8.9, Nota2 = 10, Nota3 = 8.8 },
                new Estudiante { Id = 10, Nombre = "Juana Quiñonez", Materia = "Programación", Nota1 = 4.2, Nota2 = 8.8, Nota3 = 3.4 },
                new Estudiante { Id = 11, Nombre = "Edgar Morales", Materia = "Matemáticas", Nota1 = 6.7, Nota2 = 8.2, Nota3 = 4.9 },
                new Estudiante { Id = 12, Nombre = "Ramon Mejia", Materia = "Química", Nota1 = 5.5, Nota2 = 7.9, Nota3 = 9.9 },
                new Estudiante { Id = 13, Nombre = "Belquior Borja", Materia = "Física", Nota1 = 7.4, Nota2 = 6.6, Nota3 = 5.1 },
                new Estudiante { Id = 14, Nombre = "Alexander Molina", Materia = "Matemáticas", Nota1 = 2.6, Nota2 = 4.5, Nota3 = 4.5 },
                new Estudiante { Id = 15, Nombre = "Johnny Vargas", Materia = "Física", Nota1 = 7, Nota2 = 5.9, Nota3 = 5.2 }
            };

            return Estudiantes;
        }

    }
}
