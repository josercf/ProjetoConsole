using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Cansei{
    class Editar{
        public Editar(string _email, string nome, string email, string senha){
            // Update
            // Olhe o arquivo Cadastrar.
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QPB3I0U;Initial Catalog=TesteForm;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Pessoa set nome = '"+nome+"', email = '"+email+"', senha = '"+senha+"' where email = '"+_email+"'", con);
            if(nome != "" && email != "" && senha != ""){
            cmd.ExecuteReader();

                Console.WriteLine("Alterado com Sucesso");
            }
            else{
                System.Console.WriteLine("Erro");
            }
            con.Close();
        }
    }
}