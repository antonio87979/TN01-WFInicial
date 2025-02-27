using System.Net.Mail;

namespace C_RevisãoPrimeiraAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FAça um algoritimo para a leiturs de duas notas parciais de um aluno. O algoritimo deve calular a média alcançada por aluno e apresentar
            //a msgn: aprovado

            Console.WriteLine("digite primeira nota");
            double nota = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a segunda nota");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a terceira nota");
            double nota3 = double.Parse(Console.ReadLine()); 
            
            double media = (nota + nota2 + nota3) / 3; //Alt movimenta a linha de coigo

            if (media >= 7)
            {
                Console.WriteLine("Aprovado"); //cw + tab gera essa linha de código
            }
            else if (media < 5)
            {
                Console.WriteLine("reprovado");
            }
            else
            {
                Console.WriteLine("recuperação");
            }
        }
    }
}
