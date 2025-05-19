namespace DS_Projeto02
{
    partial class TelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnFechar = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUsuarioLogin = new TextBox();
            txtLoginSenha = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            MostrarSenha = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BtnFechar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MostrarSenha).BeginInit();
            SuspendLayout();
            // 
            // BtnFechar
            // 
            BtnFechar.Cursor = Cursors.Hand;
            BtnFechar.ErrorImage = Properties.Resources.x;
            BtnFechar.Image = Properties.Resources.x;
            BtnFechar.InitialImage = null;
            BtnFechar.Location = new Point(785, 0);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(15, 15);
            BtnFechar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnFechar.TabIndex = 0;
            BtnFechar.TabStop = false;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(BtnFechar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 16);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.ErrorImage = Properties.Resources.x;
            pictureBox1.Image = Properties.Resources.menos;
            pictureBox1.Location = new Point(764, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(15, 15);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(371, 61);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(276, 126);
            label2.Name = "label2";
            label2.Size = new Size(119, 19);
            label2.TabIndex = 2;
            label2.Text = "E-mail ou usuário:";
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Location = new Point(276, 148);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(273, 23);
            txtUsuarioLogin.TabIndex = 4;
            // 
            // txtLoginSenha
            // 
            txtLoginSenha.Location = new Point(276, 231);
            txtLoginSenha.Name = "txtLoginSenha";
            txtLoginSenha.Size = new Size(273, 23);
            txtLoginSenha.TabIndex = 6;
            txtLoginSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(276, 209);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 5;
            label3.Text = "Senha:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(374, 326);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // MostrarSenha
            // 
            MostrarSenha.BackColor = SystemColors.Window;
            MostrarSenha.BorderStyle = BorderStyle.FixedSingle;
            MostrarSenha.Cursor = Cursors.Hand;
            MostrarSenha.ErrorImage = Properties.Resources.x;
            MostrarSenha.Image = Properties.Resources.view;
            MostrarSenha.Location = new Point(527, 231);
            MostrarSenha.Name = "MostrarSenha";
            MostrarSenha.Size = new Size(22, 23);
            MostrarSenha.SizeMode = PictureBoxSizeMode.Zoom;
            MostrarSenha.TabIndex = 9;
            MostrarSenha.TabStop = false;
            MostrarSenha.Click += MostrarSenha_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MostrarSenha);
            Controls.Add(btnLogin);
            Controls.Add(txtLoginSenha);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtUsuarioLogin);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)BtnFechar).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MostrarSenha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BtnFechar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUsuarioLogin;
        private TextBox txtLoginSenha;
        private Label label3;
        private Button btnLogin;
        private PictureBox MostrarSenha;
    }
}
