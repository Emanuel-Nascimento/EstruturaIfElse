using System;

namespace EstruturaIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Nota do Aluno");
            var notaDigitada = Console.ReadLine();

            var nota = int.Parse(notaDigitada);

            if (nota >= 70)
            {
                Console.WriteLine("Aprovado! Parabéns!");
            }
            else if (nota >= 40)
            {
                Console.WriteLine("Recuperação  Nota precisa ser maior que 70.");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }
        }
    }
}
