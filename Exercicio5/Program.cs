using System;

namespace Exercicio5
{
    class Program
    {
        public static void CalcularMedia() 
        {
            Console.WriteLine("Digite a primeira nota");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            decimal media = (nota1 +  nota2) / 2;
            Console.WriteLine($"A média é {media}");

            if (media >= 7)
                Console.WriteLine("Aprovado");
            else if (media < 7 && media >= 4)
                Console.WriteLine("Recuperação");
            else
                Console.WriteLine("Reprovado");
        }
    }
}
