using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int resultado, contador, numero;

            Console.WriteLine("Mallu, digite um numero para criar uma tabuada: ");


            numero = Int32.Parse(Console.ReadLine());

            for (contador = 0; contador <= 10; ++contador)
            {

                resultado = numero * contador;

                Console.WriteLine(numero + " X " + contador + " = " + resultado);
            }
             Console.ReadLine();

        }
    }
}


