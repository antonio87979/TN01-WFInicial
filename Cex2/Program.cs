using static System.Net.Mime.MediaTypeNames;

namespace Cex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menu = @"----------------------------
1-domingo
2-segunda-feira
3-terça-feira
4-quarta-feira
5-quinta-feira
6-sexta-feira
7-sábado 
----------------------------
";
            Console.WriteLine(menu);
            byte opção = byte.Parse(Console.ReadLine()!); //byte: trabalhar com valores números pequenos sem sinais.

            switch (opção)
            {
                case 1:
                    Console.WriteLine("domingo");
                    break;
                case 2:
                    Console.WriteLine("segunda-feira");
                    break;
                case 3:
                    Console.WriteLine("terça-feira");
                    break;
                case 4:
                    Console.WriteLine("quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("quinta-feira");
                    break;
                case 6:
                    Console.WriteLine("sexta-feira");
                    break;
                case 7:
                    Console.WriteLine("sábado");
                    break;
                default: //qualquer opção 
                    Console.WriteLine("opção inválida");
                    break;
            }
            }
    }
}
