using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaMajo.Services
{
    public class Funciones
    {
        public void Numeros()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());
            int Resultado = num1 + num2 + num3 + num4 + num5;
            if (Resultado > 500) 
            {
                Console.WriteLine("El total de su compra es "+(Resultado*0.10));
            }
            e
            {
                Console.WriteLine("El total de su compra es "+Resultado);
            }
        }
    }
}
