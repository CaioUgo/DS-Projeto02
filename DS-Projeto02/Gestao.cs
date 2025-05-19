using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_Projeto02
{
    public partial class Gestao : Form
    {
        public Gestao()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin();
            login.Show();

            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //----------------------------------------------------------------------------------------------------------------------------------//
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtNome.Text) || !string.IsNullOrWhiteSpace(txtEmail.Text) || !string.IsNullOrWhiteSpace(txtSetor.Text) || !string.IsNullOrWhiteSpace(txtCargo.Text))
                {
                    Funcionarios funcionario = new Funcionarios();
                    funcionario.Nome = txtNome.Text;
                    funcionario.Email = txtEmail.Text;
                    funcionario.Setor = txtSetor.Text;
                    funcionario.Cargo = txtCargo.Text;

                    if (funcionario.CadastrarFuncionario())
                    {
                        funcionario.ListarFuncionarios(DataGrideLista);
                        MessageBox.Show("Funcionário: " + txtNome.Text + " cadastrado com sucesso!", "Sucesso - cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar", "Erro - cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimparCampos();
                    }
                }

                else
                {
                    MessageBox.Show("Favor preencher corretamente os campos!", "Erro - campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar o cadastro: " + ex.Message, "Erro - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCampos();
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------//
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("Informe uma linha para excluir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Funcionarios funcionario = new Funcionarios();
                funcionario.Nome = txtNome.Text;
                funcionario.Email = txtEmail.Text;
                funcionario.Setor = txtSetor.Text;
                funcionario.Cargo = txtCargo.Text;

                if (funcionario.ExcluirFuncionario())
                {
                    funcionario.ListarFuncionarios(DataGrideLista);
                    MessageBox.Show("Funcionário: " + txtNome.Text + " excluído com sucesso!", "Sucesso - Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir", "Erro - Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimparCampos();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a exclusão: " + ex.Message, "Erro - Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCampos();
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------//
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("Informe uma linha para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Funcionarios funcionario = new Funcionarios();
                funcionario.Nome = txtNome.Text;
                funcionario.Email = txtEmail.Text;
                funcionario.Setor = txtSetor.Text;
                funcionario.Cargo = txtCargo.Text;

                if (funcionario.EditarFuncionario())
                {
                    funcionario.ListarFuncionarios(DataGrideLista);
                    MessageBox.Show("Funcionário: " + txtNome.Text + " editado com sucesso!", "Sucesso - Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Não foi possível editar", "Erro - Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimparCampos();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a exclusão: " + ex.Message, "Erro - Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCampos();
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------//
        private void GestaoProd_Load(object sender, EventArgs e)
        {
            DataGrideLista.Columns.Clear();

            DataGrideLista.ColumnCount = 5;
            DataGrideLista.Columns[0].Name = "ID";
            DataGrideLista.Columns[1].Name = "Nome";
            DataGrideLista.Columns[2].Name = "Email";
            DataGrideLista.Columns[3].Name = "Setor";
            DataGrideLista.Columns[4].Name = "Cargo";

            Funcionarios funcionario = new Funcionarios();
            funcionario.ListarFuncionarios(DataGrideLista);
        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSetor.Clear();
            txtCargo.Clear();
        }

        private void DataGrideLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = DataGrideLista.Rows[e.RowIndex];
                string id = row.Cells["id"].Value.ToString();
                string nome = row.Cells["nome"].Value.ToString();
                string email = row.Cells["email"].Value.ToString();
                string setor = row.Cells["setor"].Value.ToString();
                string cargo = row.Cells["cargo"].Value.ToString();

                txtID.Text = id;
                txtNome.Text = nome;
                txtEmail.Text = email;
                txtSetor.Text = setor;
                txtCargo.Text = cargo;
            }
        }

        private void Gestao_Load(object sender, EventArgs e)
        {
            DataGrideLista.Columns.Clear();
            DataGrideLista.ColumnCount = 5;
            DataGrideLista.Columns[0].Name = "ID";
            DataGrideLista.Columns[1].Name = "Nome";
            DataGrideLista.Columns[2].Name = "Email";
            DataGrideLista.Columns[3].Name = "Setor";
            DataGrideLista.Columns[4].Name = "Cargo";
        }

        
    }
}
