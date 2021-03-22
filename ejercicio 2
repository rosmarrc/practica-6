using System;

namespace pract_6_eje_2
{
    public class ProbarContacto
    {
        static void Main(string[] args)
        {
           Contacto contacto1 = new Contacto();
            contacto1.nombre = "Rosmar";
            contacto1.apellido = "Rijo Castro";
            contacto1.telefono = 8493584644;
            contacto1.direccion = "Juan Pablo Duarte, Higuey";

            Console.WriteLine(contacto1.saludar());

            Contacto contacto2 = new Contacto();
            contacto2.nombre = "Julian";
            contacto2.apellido = "Guerrero Martinez";
            contacto2.telefono = 80945742491;
            contacto2.direccion = "La Malena, Higuey";
            Console.WriteLine();
            Console.WriteLine(contacto2.saludar());

            Console.ReadKey();
        }
    }

    public class Contacto
    {
        public string nombre;
        public string apellido;
        public  Int64 telefono;
        public string direccion;

        public void SetContacto(string nombre, string apellido, Int64 telefono, string direccion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public string saludar()
        {
           string nombrecompleto = $"{nombre} {apellido}";
           string saludo = $"Hola, soy {nombrecompleto}. Mi numero de telefono es {telefono} y vivo en {direccion}.";

            return saludo;
        }

    }


}
