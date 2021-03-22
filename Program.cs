using System;

namespace pract_6_eje_1
{
    class Program
    {
        static void Main(string[] args)
        {
            persona persona1 = new persona();
            persona1.nombre = "Rosmar";
            persona1.apellido = "Rijo Castro";
            persona1.edad = 18;
            persona1.cedula = 00100001015;
            Console.WriteLine("Objeto de la clase persona");

            Console.WriteLine($"Nombre: {persona1.nombre} \nApellido: {persona1.apellido}\nEdad: {persona1.edad}\nCédula: {persona1.cedula}\n");

            profesor profesor1 = new profesor();
            profesor1.nombre = "Juan";
            profesor1.apellido = "Guerrero";
            profesor1.edad = 35;
            profesor1.cedula = 00102001024;
            profesor1.sueldo = 25000;
            Console.WriteLine("Objeto de la clase profesor");
            Console.WriteLine($"Nombre: {profesor1.nombre} \nApellido: {profesor1.apellido}\nEdad: {profesor1.edad}" +
                $"\nCédula: {profesor1.cedula}\nSueldo: ${profesor1.sueldo}");



            Console.ReadKey();
        }
    }

     public class persona
    {
        public string nombre;
        public string apellido;
        public int edad;
        public int cedula;

        
    }

    class profesor:persona
    {
        public int sueldo;
    }
}
