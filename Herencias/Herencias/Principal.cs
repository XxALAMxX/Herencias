using System;

namespace Herencias
{
    class Class1
    {
        static void Main(string[] args)
        {
            Jefe jefe = new Jefe();

            jefe.puesto = "Jefe";
            jefe.Nombre = "Dante";
            jefe.Edad = 20;
            jefe.Telefono = "33-35-97-67-61";
            jefe.Salario = 8700.50;
            jefe.Imprimir();

            Empleado empleado = new Empleado();
            empleado.puesto = "Sub Gerente";
            empleado.Nombre = "Pepe";
            empleado.Edad = 23;
            empleado.Telefono = "33-56-44-56-70";
            empleado.Salario = 5000.50;
            empleado.Imprimir();
            Console.ReadKey(true);
        }
    }
}
