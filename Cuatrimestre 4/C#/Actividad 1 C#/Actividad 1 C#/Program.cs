using System;
namespace Actividad1
{
    class Programa
    {

        static void Main(string[] args)
        {
            //definirr variables
            string nombre;
            DateTime fecnac;
            string carrera;
            int edad;



            Console.WriteLine("Bienvenidos a UMI/Universidad Coppel.");

            Console.WriteLine("\n\nIngresa tu nombre completo:");
            nombre = Console.ReadLine();

            Console.WriteLine("\nIngresa tu edad:");
            edad = int.Parse(Console.ReadLine());



            Console.WriteLine("\nIngresa tu fecha de nacimiento (YYYY-MM-DD):");
            fecnac = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);

            Console.WriteLine("\n¿A qué carrera deseas ingresar?");
            carrera = Console.ReadLine();

            Console.WriteLine("\n\nGracias " + nombre + " " + "por formar parte de UMI/Universidad Coppel. Bienvenido a la carrera " + carrera + ".");

            Console.WriteLine("\nDatos capturardos");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Fecha de nacimiento: " + fecnac.ToString("yyyy-MM-dd"));
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Carrera: " + carrera);
        }
    }
}