using System;

namespace Cansei
{
    public class Mensagens
    {
        public Mensagens(){

        }

        public void Escolha(){
            System.Console.Write("Digite a sua escolha: ");
        }

        public void Cadastrado(){
            System.Console.WriteLine("Cadastrado com Sucesso");
            System.Console.WriteLine("=========================================");
        }

        public void Verificado(){
            System.Console.WriteLine("A pessoa está cadastrada");
            System.Console.WriteLine("=========================================");
        }
        
        public void Excluido(){
            System.Console.WriteLine("Essa pessoa foi excluida do Banco de Dados");
            System.Console.WriteLine("==============================================");
        }

        public void Editado(){
            System.Console.WriteLine("Seus dados foram Atualizados");
            System.Console.WriteLine("=========================================");
        }
        public void Erro(){
            System.Console.WriteLine("Erro ao tentar conectar");
            System.Console.WriteLine("=========================================");
        }

        public void Encerrar(){
            System.Console.WriteLine("Programa encerrado!!");
        }
    }
}
