using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcionUsuario;
            bool hayResultados;
            string textoBuscar;
            Dictionary<string,Componente> componentes = new Dictionary<string,Componente>();

            componentes.Add("1111A",
                new Componente("1111A", "Monitor", "LG", "2415KLS", 105.99f));
            componentes.Add("22222B",
               new Componente("22222B", "Tarjeta Grafica", "NVidia", "3080", 720.99f));
            componentes.Add("33333C",
              new Componente("33333C", "Monitor", "Benq", "32ah5", 249.99F));
            componentes.Add("44444D",
              new Componente("44444D", "Disco Duro", "Samsung", "SSD 1 TB", 105.99f));
            componentes.Add("55555E",
              new Componente("55555E", "Disco Duro", "Kingston", "SSD 2 TB", 149.99f));

            do
            {
                Console.WriteLine();

                Console.WriteLine("Escoja una de las siguientes opciones: ");
                Console.WriteLine("1. Buscar por codigo");
                Console.WriteLine("2. Buscar por categoria");
                Console.WriteLine("0. Salir");
                Console.WriteLine();
                opcionUsuario = Convert.ToInt32(Console.ReadLine());

                switch (opcionUsuario)
                {
                    case 1:
                        Console.WriteLine("Escribe el codigo del componente:");
                        textoBuscar = Console.ReadLine();
                        if (componentes.ContainsKey(textoBuscar))
                        {
                            Console.WriteLine(componentes[textoBuscar]);

                        }
                        else
                        {
                            Console.WriteLine("Componente no encontrado.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Escribe el nombre de la categoria:");
                        textoBuscar = Console.ReadLine();
                        hayResultados = false;

                        foreach (KeyValuePair<string, Componente> componente in componentes)
                        {
                            if (componente.Value.Categoria == textoBuscar)
                            {
                                Console.WriteLine(componente.Value);
                                hayResultados = true;
                            }
                        }
                        if (!hayResultados)
                        {
                            Console.WriteLine("No se han encontrado resultados. ");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Fin del programa");
                        break;

                    default:
                        Console.WriteLine("Opcion no reconocida");
                            break;
                }

                

            } while (opcionUsuario != 0);


        }
    }
}
