// ============================================================
// ARCHIVO:      VerificadorParImpar.cs
// DESCRIPCION:  Verifica si un numero entero es par o impar.
// ESTANDAR:     Microsoft C# Coding Conventions
// ============================================================
using System;

namespace prueba_codificación
{
    /// <summary>
    /// Clase para verificar si un numero es par o impar.
    /// </summary>
    public class VerificadorParImpar
    {
        /// <summary>
        /// Indica si un numero entero es par o impar.
        /// </summary>
        /// <param name="numero">Numero entero a verificar.</param>
        /// <returns>Texto indicando si el numero es par o impar.</returns>
        public static string VerificarParImpar(int numero)
        {
            // Si el residuo de dividir entre 2 es 0, el numero es par
            if (numero % 2 == 0)
                return $"{numero} es par.";

            return $"{numero} es impar.";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(VerificarParImpar(4));   // 4 es par.
            Console.WriteLine(VerificarParImpar(7));   // 7 es impar.
            Console.WriteLine(VerificarParImpar(0));   // 0 es par.
        }
    }


}