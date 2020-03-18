using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1_SanchezNatalia
{
    public class Persona
    {
        private string Nombre;
        private string Apellido;

        public Persona(string Nom, string Ape)
        {
            Nombre = Nom;
            Apellido = Ape;

        }

        public void Lanzar()
        {
            Random random = new Random();
            Console.WriteLine(random.Next(0, 3));

        }
        public void Name()
        {
            Console.WriteLine($"{Nombre} {Apellido}");
        }
         
    }
}
