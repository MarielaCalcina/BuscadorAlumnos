using System;
using System.Collections.Generic;

namespace BuscadorDeAlumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumnos Adrien = new Alumnos("Adrien", 1, true, "6,6,6");
            Alumnos Jeremy = new Alumnos("Jeremy", 2, true, "8,7,6");
            Alumnos Rachel = new Alumnos("Rachel", 3, false, "4,7,8");
            Alumnos Bam = new Alumnos("Bam", 4, true, "10,8,9");

            List<Alumnos> listaDeAlumnos = new List<Alumnos>();
            listaDeAlumnos.Add(Adrien);
            listaDeAlumnos.Add(Jeremy);
            listaDeAlumnos.Add(Rachel);
            listaDeAlumnos.Add(Bam);
            
            
            //En este caso se presenta una funcion en donde se le solicita al usuario un nombre para poder buscarlo en los datos
            //que se tienen almacenados
            Console.WriteLine("Ingrese el nombre del alumno a buscar");
            string nombreIngresado = Console.ReadLine();
            string nombresEnCadaVuelta;

            foreach (Alumnos listaAlumnos in listaDeAlumnos)
            {
                nombresEnCadaVuelta = listaAlumnos.decirNombre();
                if (nombreIngresado.ToUpper() == nombresEnCadaVuelta.ToUpper())
                {
                    Console.WriteLine("El alumno si se encuentra registrado");
                }
                else
                    Console.WriteLine("No pudo hallarse el alumno solicitado");
                {
                }
            } 



            //Funcion buscadora por numero de identificacion que ingrese el usuario
            Console.WriteLine("Ingrese el numero de identificación del alumno");
            int numeroDeIdentificaciónIngresado = int.Parse(Console.ReadLine());

            int numeroIDEnCadaVuelta;

            foreach (Alumnos numeroDeIdentificacion in listaDeAlumnos)
            {
                numeroIDEnCadaVuelta = numeroDeIdentificacion.NumeroDeIdentificacion();
                if (numeroDeIdentificaciónIngresado == numeroIDEnCadaVuelta)
                {
                    Console.WriteLine("El alumno solicitado es " + numeroDeIdentificacion.decirNombre());
                }
                else
                {
                    Console.WriteLine("No pudo hallarse el alumno solicitado");
                }
            }

            //Funcion que muestra a los alumnos y su estado (activos o no activos)
            foreach (Alumnos estado in listaDeAlumnos)
            {
                Console.WriteLine(estado.AlumnoActivoNoActivo());
            }

        }
    }
}
