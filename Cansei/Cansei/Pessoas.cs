using System;
using System.Data.SqlClient;

namespace Cansei{
    class Pessoas{

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        Mensagens mensagens = new Mensagens();

        public Pessoas(){

        }

        // CADASTRO
        public void Cadastrar(string nome, string email, string senha){
            // Baixo conectar com o SQL Serve passando o endereço da sua maquina
            cmd.Connection = conexao.Conectar();
            cmd.CommandText = "insert into Pessoa values('" + nome + "', '" + email + "', '" + senha + "')";
            cmd.ExecuteNonQuery(); // Esse comando manda a informação para o SQL Serve
            if (nome != "" && email != "" && senha != "")
            {
                mensagens.Cadastrado();
            }
            else{
                mensagens.Erro();
            }
            conexao.Desconctar();
        }
        // SELECT
        public void Mostrar(string email, string senha){
            SqlDataReader reader = null;

            try
            {
                cmd.Connection = conexao.Conectar();

                // Criando o SqlCommand com parâmetro
                cmd.CommandText = "select * from Pessoa where email = '"+email+"' and senha = '"+senha+"'";

                // Executando o commando e obtendo o resultado
                if(email != "" && senha != ""){
                    reader = cmd.ExecuteReader();
                }
                else
                {
                    mensagens.Erro();
                }

                // Exibindo os registros
                while (reader.Read())
                {
                    Console.WriteLine("{0}, {1}, {2}",
                        reader["Nome"],
                        reader["Email"],
                        reader["Senha"]);
                }
            }
            finally
            {
                // Fecha o datareader
                if (reader != null)
                {
                    reader.Close();
                }

                // Fecha a conexão
                if (conexao != null)
                {
                    mensagens.Erro();
                    conexao.Desconctar();
                }
            }
        }

        public void Deletar(string email, string senha){
            cmd.Connection = conexao.Conectar();
            // Olhe o arquivo Cadastrar.
            cmd.CommandText = "delete from Pessoa where email = '"+email+"' and senha = '"+senha+"'";
            if(email != "" && senha != ""){
                cmd.ExecuteReader();

                mensagens.Excluido();
            }
            else{
                mensagens.Erro();
            }
            conexao.Desconctar();
        }

        public void Editar(string _email, string nome, string email, string senha){
            cmd.Connection = conexao.Conectar();
            cmd.CommandText = "update Pessoa set nome = '"+nome+"', email = '"+email+"', senha = '"+senha+"' where email = '"+_email+"'";
            if(nome != "" && email != "" && senha != ""){
                cmd.ExecuteReader();

                mensagens.Editado();
            }
            else{
                mensagens.Erro();
            }
            conexao.Desconctar();
        }
    }
}