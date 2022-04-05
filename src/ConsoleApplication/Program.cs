//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            /*for (int i = 0; i < 100; i++)
            {
                Train train = new Train("trainId");
            }*/

            /// Se reinicia cuando llega a un número muy grande porque se sobrecarga, entonces libera memoria reiniciando 
            /// la cuenta, pero eso crea un bucle porque debido a esto nunca llega al resultado final
            /*for (int i = 0; i < 10000000; i++)
            {
                Train train = new Train("trainId");
            }*/

            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("Runaway Train");


            ///Se imprime false porque hace una comparación entre los objetos, que no es verdadera, ya que ocupan diferentes 
            /// espacios en la memoria.
            
            Console.WriteLine(t1 == t2);
            Console.WriteLine(t2 == t3);
        }
    }
}