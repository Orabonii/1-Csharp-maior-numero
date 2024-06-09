using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Solicita o primeiro número ao usuário
            Console.WriteLine("Digite o primeiro número inteiro:");
            int numero1;
            if (!int.TryParse(Console.ReadLine(), out numero1))
            {
                Console.WriteLine("Número inválido.");
                return;
            }

            // Solicita o segundo número ao usuário
            Console.WriteLine("Digite o segundo número inteiro:");
            int numero2;
            if (!int.TryParse(Console.ReadLine(), out numero2))
            {
                Console.WriteLine("Número inválido.");
                return;
            }

            // Compara os dois números e informa qual é o maior
            if (numero1 > numero2)
            {
                Console.WriteLine($"O primeiro número ({numero1}) é maior que o segundo número ({numero2}).");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"O segundo número ({numero2}) é maior que o primeiro número ({numero1}).");
            }
            else
            {
                Console.WriteLine($"Ambos os números são iguais ({numero1} e {numero2}).");
            }
        }
    }
