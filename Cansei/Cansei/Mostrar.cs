using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Cansei{
    class Mostrar{
        public Mostrar(string email){
            // Select
            // Olhe o arquivo Cadastrar.
            SqlConnection con = null;
            SqlDataReader reader = null;

            try
            {
                con = new SqlConnection("Data Source=DESKTOP-QPB3I0U;Initial Catalog=TesteForm;Integrated Security=True");
                con.Open();

                // Criando o SqlCommand com parâmetro
                SqlCommand cmd = new SqlCommand(
                    "select * from Pessoa where email = @email", con);

                // Define as informações do parâmetro criado
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@email";
                param.Value = email;

                // Inserindo o parâmetro no comando
                cmd.Parameters.Add(param);

                // Executando o commando e obtendo o resultado
                reader = cmd.ExecuteReader();

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
                if (con != null)
                {
                    con.Close();
                }
            }

        }
    }
}