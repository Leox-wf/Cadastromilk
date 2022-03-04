using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cadastromilk.Model;

namespace cadastromilk.Control
{
    class BeneficiarioControle
    {
        // Cadastro //
        public void cadastroBeneficiario()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pInserirBen", conexao);
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                MessageBox.Show(ModelCadastro.Nome + ModelCadastro.Fone + ModelCadastro.Cpf + ModelCadastro.Endereco + ModelCadastro.Ncarterinha + ModelCadastro.Data + ModelCadastro.Responsavel1);
                comando.Parameters.AddWithValue("@nome", ModelCadastro.Nome);
                comando.Parameters.AddWithValue("@fone", ModelCadastro.Fone);
                comando.Parameters.AddWithValue("@cpf", ModelCadastro.Cpf);
                comando.Parameters.AddWithValue("@endereco", ModelCadastro.Endereco);
                comando.Parameters.AddWithValue("@ncarterinha", ModelCadastro.Ncarterinha);
                comando.Parameters.AddWithValue("@data_naci", ModelCadastro.Data);
                comando.Parameters.AddWithValue("@responsavel", ModelCadastro.Responsavel1);
               
                SqlParameter codigo = comando.Parameters.Add("@Id_ben", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Beneficiario cadastrado com sucesso! \n" +
                    "Deseja cadastrar outro Beneficiario ?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    ModelCadastro.Retorno = "False";
                    return;
                }
                else
                {
                    ModelCadastro.Retorno = "True";
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Beneficiario não cadastrado", "Atenção");
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

        }

        // Visualizar //
        public void visualizarBen()
        {

            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscarCodigosBen", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {

                comandos.Parameters.AddWithValue("@codigo", ModelCadastro.Id);
                conexao.Open();

                var tabelaDados = comandos.ExecuteReader();

                if (tabelaDados.Read())
                {
                    ModelCadastro.Nome = tabelaDados["Nome"].ToString();
                    ModelCadastro.Fone = tabelaDados["Telefone"].ToString();
                    ModelCadastro.Cpf = tabelaDados["CPF"].ToString();
                    ModelCadastro.Endereco = tabelaDados["Endereço"].ToString();
                    ModelCadastro.Ncarterinha = tabelaDados["N°Carterinha"].ToString();
                    ModelCadastro.Data = tabelaDados["DatadNacimento"].ToString();
                    ModelCadastro.Responsavel1 = tabelaDados["Responsavel"].ToString();
                    ModelCadastro.Retorno = "True";

                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    //BeneficiarioControle.Retorno = "False";
                }

            }
            catch
            {
                MessageBox.Show("Não conseguimos localizar os dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        public static BindingSource VisuNomeBen()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pBuscarNomeBen", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            comandos.Parameters.AddWithValue("@nome", "%" + ModelCadastro.Nome + "%");
            conexao.Open();
            comandos.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(comandos);
            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;

        }

        // Alterar //
        public void alterarAluno()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pAlterarBen", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", ModelCadastro.Id);
                comandos.Parameters.AddWithValue("@nome", ModelCadastro.Nome);
                comandos.Parameters.AddWithValue("@fone", ModelCadastro.Fone);
                comandos.Parameters.AddWithValue("@cpf", ModelCadastro.Cpf);
                comandos.Parameters.AddWithValue("@endereco", ModelCadastro.Endereco);
                comandos.Parameters.AddWithValue("@ncarterinha", ModelCadastro.Ncarterinha);
                comandos.Parameters.AddWithValue("@datadnaci", ModelCadastro.Data);
                comandos.Parameters.AddWithValue("@responsavel", ModelCadastro.Responsavel1);

                conexao.Open();
                comandos.ExecuteNonQuery();
                MessageBox.Show("Beneficiario Alterado com sucesso!");
                //BeneficiarioControle.Retorno = "True";
            }
            catch
            {
                MessageBox.Show("Beneficiario não alterado.");
                //BeneficiarioControle.Retorno = "False";
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

        // Deletar //
        public void deletarAluno()
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comandos = new SqlCommand("pDeletarBen", conexao);
            comandos.CommandType = CommandType.StoredProcedure;

            try
            {
                comandos.Parameters.AddWithValue("@codigo", ModelCadastro.Id);
                conexao.Open();
                comandos.ExecuteNonQuery();
               // BeneficiarioControle.Retorno = "True";
                MessageBox.Show("Beneficiario Excluido com sucesso!");

            }
            catch
            {
                MessageBox.Show("Beneficiario não Excluido.");
              //  BeneficiarioControle.Retorno = "False";
            }
            finally
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    conexao.Close();
                }
            }
        }

    }
}

    


