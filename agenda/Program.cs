using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";

            string[] nombre = new string[5];

            string[] dirección = new string[5];

            string[] correo = new string[5];

            int[] cel = new int[5];

            for (int i = 0; i < 5; i++)

            {

                Console.Write("Ingrese nombre: ");

                nombre[i] = Console.ReadLine();

                Console.Write("Ingrese la dirección: ");

                dirección[i] = Console.ReadLine();

                Console.Write("Ingrese correo: ");

                correo[i] = Console.ReadLine();

                Console.Write("Ingrese teléfono: ");

                line = Console.ReadLine();

                cel[i] = int.Parse(line);

            }

            for (int x = 0; x < 5; x++)

            {

                Console.WriteLine("nombre: " + nombre[x] + "dirección: " + dirección[x] + "correo: " + correo[x] + "teléfono: " + cel[x]);

            }

            Console.Write("ingrese el nombre del usuario a buscar: ");

            line = Console.ReadLine();

            string consulta = "usuario no encontrado";

            for (int i = 0; i < 5; i++)

            {

                if (nombre[i] == line)

                {

                    consulta = "nombre: " + nombre[i] + "dirección: " + dirección[i] + "correo: " + correo[i] + "teléfono: " + cel[i];

                    nombre[i] = " ";

                    cel[i] = 0;

                    dirección[i] = " ";

                    correo[i] = " ";

                    nombre[i] = "nuevo nombre ";

                    cel[i] = 00000;

                    dirección[i] = "nueva dirección ";

                    correo[i] = "nuevo correo ";

                }

            }

            Console.Write("ingrese nombre a borrar: ");

            line = Console.ReadLine();

            for (int x = 0; x < 5; x++)

            {

                if (nombre[x] == line)

                {

                    nombre[x] = "";

                }

            }

            Console.WriteLine(consulta);

            Console.ReadKey();

        }
    }
}
