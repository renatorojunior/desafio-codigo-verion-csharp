using System;

namespace Questao_02
{
    class Program
    {
        static void Main()
        {
            // Definindo Sequência de cores desordenada.

            var sequencia = new string[] {
                "Vermelho",
                "Azul",
                "Vermelho",
                "Vermelho",
                "Azul",
                "Vermelho",
                "Vermelho",
                "Azul",
                "Azul",
                "Azul"
            };

            // Imprime sequência de cores desordenada.
            Console.WriteLine("Sequência S de cores desordenada.");
            Console.WriteLine(String.Join(", ", sequencia));

            // Ordenação In-place utilizando o método Bubble Sort.
            for (int i = sequencia.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (sequencia[j] != "Azul")
                    {
                        string copia_i = sequencia[i];
                        sequencia[i] = sequencia[j];
                        sequencia[j] = copia_i;
                    }
                } 
             }

            // Imprime sequência de cores ordenada.
            Console.WriteLine("Sequência S de cores ordenada.");
            Console.WriteLine(String.Join(", ", sequencia));
            Console.ReadLine();
         }  
    }

}

