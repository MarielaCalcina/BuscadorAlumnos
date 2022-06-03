using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscadorDeAlumnos
{
    class Alumnos 
    {
        //Atributos 
        public string nombre;
        public int numeroIdentificacion;
        public bool activo;
        public string notas; 

        //constructor
        public Alumnos(string nombre, int numeroIdentificacion, bool activo, string notas)//antes era int[]
        {
            this.nombre = nombre;
            this.numeroIdentificacion = numeroIdentificacion;
            this.activo = activo;
            this.notas = notas;
        }

        //Metodos 

        //metodo para calcular el promedio de cada alumno e intento de encontrar el mayor.
        public int Promedio()
        {
            string[] separarNotas = notas.Split(',');
            string nota1String = separarNotas[0];
            string nota2String = separarNotas[1];
            string nota3String = separarNotas[2];

            int nota1 = Int32.Parse(nota1String);
            int nota2 = Int32.Parse(nota2String);
            int nota3 = Int32.Parse(nota3String);

            int Promedio = (nota1+ nota2 + nota3)/3;

            var max = 0;

            List<int> notasDeAlumnos = new List<int>
            { Promedio
            };

            max = notasDeAlumnos.Max();
            return max;
        }

        //metodo para mostrar cada una de las notas del alumno solicitado
        public string Notas()
        {
            string[] separarNotas = notas.Split(",");
            string nota1String = separarNotas[0];
            string nota2String = separarNotas[1];
            string nota3String = separarNotas[2];

            int nota1 = Int32.Parse(nota1String);
            int nota2 = Int32.Parse(nota2String);
            int nota3 = Int32.Parse(nota3String);

            string notasTodas = "Las notas del alumno son " + nota1 + " " + nota2 + " " + nota3;
            return notasTodas;
        }

        //metodo que nos devuelve el numero de identificacion de cada alumno
        public int NumeroDeIdentificacion()
        {
            return this.numeroIdentificacion;
        }

        //metodo que nos devuelve el nombre del alumno solicitado
        public string decirNombre()
        {
            return this.nombre;
        }

        //metodo que nos dice si el alumno esta activo o no
        public string AlumnoActivoNoActivo()
        {
            if (activo == true)
            {
                string alumnoActivo= "El alumno " + nombre + " esta activo";
                return alumnoActivo;
            }
            else
            {
                string noActivo = "El alumno " + nombre + " no esta activo";
                return noActivo;
            }
        }
    }
}
