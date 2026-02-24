using System;
using System.Collections.Generic;

namespace TraductorDiccionario.Modelo
{
    public class Traductor
    {
        // Diccionario principal donde guardamos las palabras
        // La clave será la palabra en inglés
        // El valor será su traducción al español
        private Dictionary<string, string> diccionario;

        // Constructor: aquí inicializamos el diccionario
        public Traductor()
        {
            diccionario = new Dictionary<string, string>();

            // Palabras iniciales obligatorias (mínimo 10)
            diccionario.Add("time", "tiempo");
            diccionario.Add("person", "persona");
            diccionario.Add("year", "año");
            diccionario.Add("day", "día");
            diccionario.Add("thing", "cosa");
            diccionario.Add("man", "hombre");
            diccionario.Add("world", "mundo");
            diccionario.Add("life", "vida");
            diccionario.Add("hand", "mano");
            diccionario.Add("eye", "ojo");
        }

        // Método que traduce una frase completa
        public string TraducirFrase(string frase)
        {
            // Separamos la frase en palabras usando espacios
            string[] palabras = frase.Split(' ');

            string resultado = "";

            foreach (string palabra in palabras)
            {
                // Convertimos a minúscula para evitar errores
                string palabraProcesada = palabra.ToLower();

                // Verificamos si la palabra existe en el diccionario
                if (diccionario.ContainsKey(palabraProcesada))
                {
                    // Si existe, agregamos su traducción
                    resultado += diccionario[palabraProcesada] + " ";
                }
                else
                {
                    // Si no existe, dejamos la palabra original
                    resultado += palabra + " ";
                }
            }

            // Eliminamos el espacio extra final
            return resultado.Trim();
        }

        // Método para agregar nuevas palabras
        public void AgregarPalabra(string ingles, string espanol)
        {
            ingles = ingles.ToLower();

            // Verificamos que no exista ya la palabra
            if (!diccionario.ContainsKey(ingles))
            {
                diccionario.Add(ingles, espanol);
                Console.WriteLine("✅ Palabra agregada correctamente.");
            }
            else
            {
                Console.WriteLine("⚠ La palabra ya existe en el diccionario.");
            }
        }
    }
}