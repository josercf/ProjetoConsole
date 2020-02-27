using System;

namespace Cansei
{
    class Program
    {
        static void Main(string[] args)
        {
            Tela tela = new Tela();

            tela.Opcao();

            System.Console.Write("Digite a sua escolha: ");
            int x = int.Parse(Console.ReadLine());

            Pessoas pessoa = new Pessoas();
            switch(x){
                case 1:
                    tela.Opcao1();
                    break;
                case 2:
                    tela.Opcao2();
                    break;
                case 3:
                    tela.Opcao3();
                    break;
                case 4:
                    tela.Opcao4();
                    break;
                default:
                    System.Console.WriteLine("Tchau");
                    break;
            }
        }
    }
}
