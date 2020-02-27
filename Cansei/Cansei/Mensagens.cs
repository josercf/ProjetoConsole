using System;

namespace Cansei
{
    public class Mensagens
    {
        public Mensagens(){

        }
        public void Cadastrado(){
            System.Console.WriteLine("Cadastrado com Sucesso");
        }

        public void Verificado(){
            System.Console.WriteLine("A pessoa está cadastrada");
        }
        
        public void Excluido(){
            System.Console.WriteLine("Essa pessoa foi excluida do Banco de Dados");
        }

        public void Editado(){
            System.Console.WriteLine("Seus dados foram Atualizados");
        }
        public void Erro(){
            System.Console.WriteLine("Erro ao tentar conectar");
        }
    }
}
