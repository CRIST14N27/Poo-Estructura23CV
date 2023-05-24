using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaMajo.Entities
{
    public class Cliente
    {
        public string Nombre { get; set; }  
        public string Apellido { get; set;}
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public void Datos()
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Ingrese su nombre " + cliente.Nombre);
            Console.WriteLine("Ingrese su apellido " + cliente.Apellido);
            Console.WriteLine("Ingrese su edad " + cliente.Edad);
            Console.WriteLine("Ingrese su telefono " + cliente.Telefono);
            Console.WriteLine("Ingrese su correo " + cliente.Correo);
        }
    }


}
