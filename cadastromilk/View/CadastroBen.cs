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

        }

        // ABA ALTERAR //
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beneficiário Alterado com Sucesso", "Atenção", MessageBoxButtons.OK);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
