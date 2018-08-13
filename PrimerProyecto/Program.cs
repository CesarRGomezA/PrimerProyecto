using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona(25, "Jose");

            Console.WriteLine(persona1.nombre + " Tiene " + persona1.edad + " años ");

            Console.ReadLine();
        }
    }
}
