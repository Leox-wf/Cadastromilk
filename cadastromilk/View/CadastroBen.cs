using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using cadastromilk.Control;
using cadastromilk.Model;

namespace cadastromilk
{
    public partial class CadastroBen : Form
    {
        public CadastroBen()
        {
            InitializeComponent();
        }

        // ABA CADASTRO //

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            ModelCadastro.Nome = tbxNome.Text;
            ModelCadastro.Fone = tbxTelefone.Text;
            ModelCadastro.Cpf = tbxCPF.Text;
            ModelCadastro.Endereco = tbxEnd.Text;
            ModelCadastro.Ncarterinha = tbxCart.Text;
            ModelCadastro.Data = tbxData.Text;
            ModelCadastro.Responsavel1 = tbxRespo.Text;
            
            BeneficiarioControle beneficiarioControle = new BeneficiarioControle();
            beneficiarioControle.cadastroBeneficiario();

           // MessageBox.Show("Beneficiário Cadastrado com Sucesso", "Atenção", MessageBoxButtons.OK);

            tbxNome.Clear();
        }

        // ABA ENCONTRAR //

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
                if (tbNome.Text == "")
                {
                    MessageBox.Show("Digite um Nome para a busca", "Atenção");
                    return;
                }
                else
                {
                    ModelCadastro.Nome = tbNome.Text.ToString();
                    BeneficiarioControle beneficiario = new BeneficiarioControle();
                    

             //   dataGridView1.DataSource = ModelCadastro.Nome;
                    
                    
                }

              //  if (Aluno.Retorno == "False")
             //   {

             //       limpaTudo();
             //   }


        }

            private void TelaBuscaAluno_Load(object sender, EventArgs e)
            {
               // btnApagar.Enabled = false;
              //  btnAlterar.Enabled = false;
            }

            private void btnApagar_Click(object sender, EventArgs e)
            {

               // Aluno.Codigo = Convert.ToInt32(tbMostraCodigo.Text);

                //AlunoController alunoController = new AlunoController();
               // alunoController.deletarAluno();

                //limpaTudo();
            }

            private void btnAlterar_Click(object sender, EventArgs e)
            {
              //  Aluno.Codigo = Convert.ToInt32(tbMostraCodigo.Text);
                //Aluno.NomeAluno = tbNome.Text;
              //  Aluno.EmailAluno = tbEmail.Text;
               // Aluno.FoneAluno = tbFone.Text;

               // AlunoController alunoController = new AlunoController();
              //  alunoController.alterarAluno();

               // limpaTudo();

            }

            private void limpaTudo()
            {

               // Aluno.Codigo = 0;
               // Aluno.NomeAluno = "";
              //  Aluno.EmailAluno = "";
               // Aluno.FoneAluno = "";
              //  tbNome.Clear();
               // tbEmail.Clear();
               // tbFone.Clear();
               // tbMostraCodigo.Clear();

              //  btnApagar.Enabled = false;
              //  btnAlterar.Enabled = false;

            }
        
    }
}

        // ABA ALTERAR //

