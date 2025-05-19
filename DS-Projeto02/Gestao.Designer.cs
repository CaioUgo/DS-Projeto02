namespace DS_Projeto02
{
    partial class Gestao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnVoltar = new PictureBox();
            panel1 = new Panel();
            BtnMinimizar = new PictureBox();
            BtnFechar = new PictureBox();
            DataGrideLista = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtSetor = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtCargo = new TextBox();
            btnEditar = new Button();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)BtnVoltar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGrideLista).BeginInit();
            SuspendLayout();
            // 
            // BtnVoltar
            // 
            BtnVoltar.BackColor = Color.MidnightBlue;
            BtnVoltar.Image = Properties.Resources.seta_esquerda;
            BtnVoltar.Location = new Point(0, 0);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(23, 16);
            BtnVoltar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnVoltar.TabIndex = 7;
            BtnVoltar.TabStop = false;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(BtnVoltar);
            panel1.Controls.Add(BtnMinimizar);
            panel1.Controls.Add(BtnFechar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 16);
            panel1.TabIndex = 6;
            // 
            // BtnMinimizar
            // 
            BtnMinimizar.Cursor = Cursors.Hand;
            BtnMinimizar.ErrorImage = Properties.Resources.x;
            BtnMinimizar.Image = Properties.Resources.menos;
            BtnMinimizar.Location = new Point(782, 1);
            BtnMinimizar.Name = "BtnMinimizar";
            BtnMinimizar.Size = new Size(15, 15);
            BtnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMinimizar.TabIndex = 2;
            BtnMinimizar.TabStop = false;
            BtnMinimizar.Click += BtnMinimizar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Cursor = Cursors.Hand;
            BtnFechar.ErrorImage = Properties.Resources.x;
            BtnFechar.Image = Properties.Resources.x;
            BtnFechar.InitialImage = null;
            BtnFechar.Location = new Point(803, 1);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(15, 15);
            BtnFechar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnFechar.TabIndex = 0;
            BtnFechar.TabStop = false;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // DataGrideLista
            // 
            DataGrideLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGrideLista.BackgroundColor = Color.CornflowerBlue;
            DataGrideLista.BorderStyle = BorderStyle.None;
            DataGrideLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrideLista.GridColor = Color.Lavender;
            DataGrideLista.Location = new Point(12, 51);
            DataGrideLista.Name = "DataGrideLista";
            DataGrideLista.Size = new Size(785, 219);
            DataGrideLista.TabIndex = 7;
            DataGrideLista.CellContentClick += DataGrideLista_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(357, 16);
            label1.Name = "label1";
            label1.Size = new Size(92, 32);
            label1.TabIndex = 8;
            label1.Text = "Gestão";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(33, 292);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 12;
            label2.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(33, 314);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(292, 23);
            txtNome.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(471, 292);
            label3.Name = "label3";
            label3.Size = new Size(44, 19);
            label3.TabIndex = 14;
            label3.Text = "Setor:";
            // 
            // txtSetor
            // 
            txtSetor.Location = new Point(471, 314);
            txtSetor.Name = "txtSetor";
            txtSetor.Size = new Size(292, 23);
            txtSetor.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(33, 357);
            label4.Name = "label4";
            label4.Size = new Size(44, 19);
            label4.TabIndex = 16;
            label4.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(33, 379);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(292, 23);
            txtEmail.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(471, 357);
            label5.Name = "label5";
            label5.Size = new Size(49, 19);
            label5.TabIndex = 18;
            label5.Text = "Cargo:";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(471, 379);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(292, 23);
            txtCargo.TabIndex = 17;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(33, 440);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(357, 440);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 20;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(688, 440);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 21;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(214, 203);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 22;
            // 
            // Gestao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 497);
            Controls.Add(btnExcluir);
            Controls.Add(btnCadastrar);
            Controls.Add(btnEditar);
            Controls.Add(label5);
            Controls.Add(txtCargo);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtSetor);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(DataGrideLista);
            Controls.Add(panel1);
            Controls.Add(txtID);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Gestao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestao";
            Load += Gestao_Load;
            ((System.ComponentModel.ISupportInitialize)BtnVoltar).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGrideLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BtnVoltar;
        private Panel panel1;
        private PictureBox BtnMinimizar;
        private PictureBox BtnFechar;
        private DataGridView DataGrideLista;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtSetor;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtCargo;
        private Button btnEditar;
        private Button btnCadastrar;
        private Button btnExcluir;
        private TextBox txtID;
    }
}