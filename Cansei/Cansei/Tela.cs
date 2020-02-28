using System;

namespace Cansei{
    class Tela{
        Pessoas pessoa = new Pessoas();

        Mensagens mensagens = new Mensagens();
        public Tela(){
            
        }

        public void Screen(){
            int n = 0;
            string opcao;
            System.Console.WriteLine("=========================================");
            System.Console.WriteLine("[ 1 ] incluir uma Pessoa");
            System.Console.WriteLine("[ 2 ] Verificar uma Pessoa");
            System.Console.WriteLine("[ 3 ] Excluir uma Pessoa");
            System.Console.WriteLine("[ 4 ] Editar uma Pessoa");
            System.Console.WriteLine("[ 5 ] Sair do Programa");
            System.Console.WriteLine("=========================================");
                while(n != 6){
                mensagens.Escolha();
                opcao = Console.ReadLine();
                    while ((opcao == "1") || (opcao == "2") || (opcao == "3") || (opcao == "4") || (opcao == "5"))
                    {
                        if(opcao == "1"){
                            System.Console.WriteLine("Insere as seguintes informações!!");
                            System.Console.WriteLine("");
                            System.Console.Write("Nome: ");
                            string nome = Console.ReadLine();
                            System.Console.Write("Email: ");
                            string email = Console.ReadLine();
                            System.Console.Write("Senha: ");
                            string senha = Console.ReadLine();

                            pessoa.Cadastrar(nome, email, senha);
                        }
                        else if(opcao == "2"){
                            System.Console.WriteLine("Informe nos campos abaixo as seguintes informações!!");
                            System.Console.WriteLine("");
                            System.Console.Write("Email: ");
                            string mostrarEmail = Console.ReadLine();
                            System.Console.Write("Senha: ");
                            string mostrarSenha = Console.ReadLine();
                            pessoa.Mostrar(mostrarEmail, mostrarSenha);
                        }
                        else if(opcao == "3"){
                            System.Console.WriteLine("Informe qual deseja excluir!!");
                            System.Console.WriteLine("");
                            System.Console.Write("Email: ");
                            string deletarEmail = Console.ReadLine();
                            System.Console.Write("Senha: ");
                            string deletarSenha = Console.ReadLine();
                            pessoa.Deletar(deletarEmail, deletarSenha);  
                        }
                        else if(opcao == "4"){
                            System.Console.WriteLine("Informe qual deseja editar!!");
                            System.Console.WriteLine("");
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
                        else if(opcao == "5"){
                            System.Console.WriteLine("=========================================");
                            System.Console.WriteLine("Todos as pessoas Cadastradas :)");
                            System.Console.WriteLine("");
                            pessoa.Admin();
                            System.Console.WriteLine("=========================================");
                        }
                        break;
                    }
                    if(opcao == "6"){
                        mensagens.Encerrar();
                        break;
                }
            }
        }
    }
}