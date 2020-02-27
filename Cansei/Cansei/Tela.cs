using System;

namespace Cansei{
    class Tela{
        Pessoas pessoa = new Pessoas();
        public Tela(){

        }

        public void Opcao(){
            System.Console.WriteLine("===========================");
            System.Console.WriteLine("[ 1 ] incluir uma Pessoa");
            System.Console.WriteLine("[ 2 ] Verificar uma Pessoa");
            System.Console.WriteLine("[ 3 ] Excluir uma Pessoa");
            System.Console.WriteLine("[ 4 ] Editar uma Pessoa");
            System.Console.WriteLine("[ 5 ] Sair do Programa");
            System.Console.WriteLine("===========================");
        }
        public void Opcao1(){
            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();
            System.Console.Write("Senha: ");
            string senha = Console.ReadLine();

            pessoa.Cadastrar(nome, email, senha);
        }

        public void Opcao2(){
            System.Console.Write("Email: ");
            string mostrarEmail = Console.ReadLine();
            System.Console.Write("Senha: ");
            string mostrarSenha = Console.ReadLine();
            pessoa.Mostrar(mostrarEmail, mostrarSenha);
        }

        public void Opcao3(){
            System.Console.Write("Email: ");
            string deletarEmail = Console.ReadLine();
            System.Console.Write("Senha: ");
            string deletarSenha = Console.ReadLine();
            pessoa.Deletar(deletarEmail, deletarSenha);  
        }

        public void Opcao4(){
            System.Console.Write("Digite email atual: ");
            string atualEmail = Console.ReadLine();
            System.Console.Write("Nome: ");
            string editarNome = Console.ReadLine();
            System.Console.Write("Novo Email: ");
            string editarEmail = Console.ReadLine();
            System.Console.Write("Senha: ");
            string editarSenha = Console.ReadLine();

            pessoa.Editar(atualEmail, editarNome, editarEmail, editarSenha);        
        }
    }
}