using System;

namespace Herencias
{
    class Empleado : Datos
    {
        public string puesto;
        
        public void Imprimir()
        {
            Console.WriteLine("Informacion Personal:    \nNombre: " + this.Nombre);
            Console.WriteLine("Edad: " + this.Edad);
            Console.WriteLine("Telefono: " + this.Telefono);
            Console.WriteLine("Salario: " + this.Salario);
            Console.WriteLine("Puesto: " + this.puesto);
            Console.WriteLine();
        }
    }
}
