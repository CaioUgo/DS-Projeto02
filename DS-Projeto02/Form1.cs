namespace DS_Projeto02
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool VerSenha = false;
        private void MostrarSenha_Click(object sender, EventArgs e)
        {
            VerSenha = !VerSenha;

            if (VerSenha)
            {
                txtLoginSenha.UseSystemPasswordChar = true;
            }
            else
            {
                txtLoginSenha.UseSystemPasswordChar = false;
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtLoginSenha.Text == "1234" && txtUsuarioLogin.Text == "Admin")
                {
                    MessageBox.Show("Login realizado com suceso", "Sucesso - Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Gestao gestao = new Gestao();
                    gestao.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Senha ou usuário inválidos!", "Erro - Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar o login: " + ex.Message, "Erro - Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       }
}

