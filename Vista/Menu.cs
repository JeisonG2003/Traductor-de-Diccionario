using System;
using TraductorDiccionario.Modelo;

namespace TraductorDiccionario.Vista
{
    public class Menu
    {
        private Traductor traductor;

        // Constructor
        public Menu()
        {
            traductor = new Traductor();
        }

        // Método que muestra el menú interactivo
        public void Mostrar()
        {
            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine("\n==================== MENÚ ====================");
                Console.WriteLine("1. Traducir una frase");
                Console.WriteLine("2. Agregar palabras al diccionario");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                // Validamos que el usuario ingrese un número
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("⚠ Por favor ingrese un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("\nIngrese la frase: ");
                        string frase = Console.ReadLine();

                        string traduccion = traductor.TraducirFrase(frase);

                        Console.WriteLine("\nTraducción parcial:");
                        Console.WriteLine(traduccion);
                        break;

                    case 2:
                        Console.Write("\nPalabra en inglés: ");
                        string ingles = Console.ReadLine();

                        Console.Write("Traducción en español: ");
                        string espanol = Console.ReadLine();

                        traductor.AgregarPalabra(ingles, espanol);
                        break;

                    case 0:
                        Console.WriteLine("\nGracias por usar el traductor 😊");
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida.");
                        break;
                }
            }
        }
    }
}
