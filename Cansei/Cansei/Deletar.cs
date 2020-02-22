using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Cansei{
    class Deletar{
        public Deletar(string email, string senha){
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QPB3I0U;Initial Catalog=TesteForm;Integrated Security=True");
            con.Open();
            // Delete
            // Olhe o arquivo Cadastrar.
            SqlCommand cmd = new SqlCommand("delete from Pessoa where email = '"+email+"' and senha = '"+senha+"'", con);
            if(email != "" && senha != ""){
            cmd.ExecuteReader();

                Console.WriteLine("Excluido(a) com Sucesso");
            }
            else{
                System.Console.WriteLine("Erro");
            }
            con.Close();
        }
    }
}