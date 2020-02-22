using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Cansei{
    class Cadastro{
        public Cadastro(string nome, string email, string senha){
            // Cadastrar

            // Baixo conectar com o SQL Serve passando o endereço da sua maquina
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QPB3I0U;Initial Catalog=TesteForm;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Pessoa values('" + nome + "', '" + email + "', '" + senha + "')", con);
            cmd.ExecuteNonQuery(); // Esse comando manda a informação para o SQL Serve
            if (nome != "" && email != "" && senha != "")
            {
                Console.WriteLine("Cadastrado(a) com Sucesso");
            }
            else{
                System.Console.WriteLine("Erro");
            }
            con.Close();
        }
    }
}