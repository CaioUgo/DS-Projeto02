using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DS_Projeto02
{
    class Funcionarios
    {
        private int id;
        private string nome;
        private string email;
        private string setor;
        private string cargo;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (!verificarEmail(value))
                    throw new Exception("Email inválido.");
                email = value;
            }
        }
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public string Setor
        {
            get { return setor; }
            set { setor = value; }
        }

        public bool CadastrarFuncionario()
        {
            try
            {
                using (MySqlConnection conexaobanco = new ConexaoBD().Conectar())
                {
                    string inserir = "INSERT INTO funcionarios (nome, email, setor, cargo) values (@nome, @email, @setor, @cargo)";

                    MySqlCommand comando = new MySqlCommand(inserir, conexaobanco);

                    comando.Parameters.AddWithValue("@nome", Nome);
                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@setor", Setor);
                    comando.Parameters.AddWithValue("@cargo", Cargo);

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    { 
                        return true; 
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcionário - Método -> " + ex.Message, "Erro - Cadastrar funcionário    ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------//
        public bool ExcluirFuncionario()
        {
            try
            {
                using(MySqlConnection conexaobanco = new ConexaoBD().Conectar())
                {
                    string excluir = "Delete from funcionarios WHERE nome = @nome and email = @email and setor = @setor  and cargo = @cargo ";

                    MySqlCommand comando = new MySqlCommand(excluir, conexaobanco);

                    comando.Parameters.AddWithValue("@nome", Nome);
                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@setor", Setor);
                    comando.Parameters.AddWithValue("@cargo", Cargo);

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir funcionário - Método -> " + ex.Message, "Erro - Excluir funcionário    ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------//
        public bool EditarFuncionario()
        {
            try
            {
                using(MySqlConnection conexaoBanco = new ConexaoBD().Conectar() )
                {
                    string editar = "Update funcionarios set nome = @nome, email = @email, setor = @setor, cargo = @cargo";
                    MySqlCommand comando = new MySqlCommand(editar, conexaoBanco);
                    comando.Parameters.AddWithValue("@id", ID);
                    comando.Parameters.AddWithValue("@nome", Nome);
                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@setor", Setor);
                    comando.Parameters.AddWithValue("@cargo", Cargo);

                    int resultado = comando.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar funcionário - Método -> " + ex.Message, "Erro - Editar funcionário    ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------//
        public void ListarFuncionarios(DataGridView grid)
        {
            using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
            {
                string select = "select * from funcionarios;";

                MySqlCommand comando = new MySqlCommand(select, conexaoBanco);
                MySqlDataReader readerSelect = comando.ExecuteReader();

                grid.Rows.Clear();

                while (readerSelect.Read())
                {
                    string id = readerSelect["id"].ToString();
                    string nome = readerSelect["nome"].ToString();
                    string email = readerSelect["email"].ToString();
                    string setor = readerSelect["setor"].ToString();
                    string cargo = readerSelect["cargo"].ToString();

                    grid.Rows.Add(id, nome, email, setor, cargo);
                }

                readerSelect.Close();

            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------//
        public static bool verificarEmail(string email)
        {
            string emailValido = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailValido);
            return regex.IsMatch(email);
        }
        //---------
    }
}
