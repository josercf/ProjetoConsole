using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Cansei
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.Write("Digite a sua escolha: ");
            int x = int.Parse(Console.ReadLine());
            string opcao;

            switch(x){
                case 1:
                    opcao = "Cadastrar";
                    //System.Console.Write("Email: ");
                    //string _email = Console.ReadLine();
                    System.Console.WriteLine("Opção escolhida " + opcao);
                    System.Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    System.Console.Write("Email: ");
                    string email = Console.ReadLine();
                    System.Console.Write("Senha: ");
                    string senha = Console.ReadLine();

                    Cadastro cadastro = new Cadastro(nome, email, senha);
                    break;
                case 2:
                    opcao = "Mostrar";
                    System.Console.WriteLine("Opção escolhida " + opcao);
                    System.Console.Write("Email: ");
                    string mostrarEmail = Console.ReadLine();

                    Mostrar mostrar = new Mostrar(mostrarEmail);
                    break;
                case 3:
                    opcao = "Deletar";
                    System.Console.WriteLine("Opção escolhida " + opcao);

                    System.Console.Write("Email: ");
                    string deletarEmail = Console.ReadLine();
                    System.Console.Write("Senha: ");
                    string deletarSenha = Console.ReadLine();

                    Deletar deletar = new Deletar(deletarEmail, deletarSenha);
                    break;
                case 4:
                    opcao = "Editar";
                    System.Console.WriteLine("Opção escolhida " + opcao);

                    System.Console.Write("Digite email atual: ");
                    string atualEmail = Console.ReadLine();
                    System.Console.Write("Nome: ");
                    string editarNome = Console.ReadLine();
                    System.Console.Write("Novo Email: ");
                    string editarEmail = Console.ReadLine();
                    System.Console.Write("Senha: ");
                    string editarSenha = Console.ReadLine();

                    Editar editar = new Editar(atualEmail, editarNome, editarEmail, editarSenha);
                    break;
                default:
                    opcao = "Invalida";
                    break;
            }
        }
    }
}
