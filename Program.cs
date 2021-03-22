using System;

namespace pract_6_eje_1
{
    class Program
    {
        static void Main(string[] args)
        {
            persona persona1 = new persona();
            persona1.nombre = "Rosmar";
            persona1.apellido = "Rijo";
            persona1.edad = 18;
            persona1.cedula = 00100001015;

            profesor profesor1 = new profesor();
            profesor1.nombre = "Juan";
            profesor1.apellido = "Guerrero";
            profesor1.edad = 35;
            profesor1.cedula = 00102001024;
            profesor1.sueldo = 25000;



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
