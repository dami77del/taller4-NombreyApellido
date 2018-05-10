using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreyApellido
{
    class Program
    {
        static void Main(string[] args)
        {

            String nombre;
            String apellido;

            Console.WriteLine("Escriba su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Escriba su apellido");
            apellido = Console.ReadLine();
            Console.WriteLine("Nombre"+ nombre + " Apellido" + apellido);
        }
    }
}
