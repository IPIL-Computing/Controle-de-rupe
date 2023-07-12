namespace r
{
    partial class Form_principal
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
            this.panel_displaye = new System.Windows.Forms.Panel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_logar = new System.Windows.Forms.Panel();
            this.b_logaut = new System.Windows.Forms.Button();
            this.b_login = new System.Windows.Forms.Button();
            this.b_logar = new System.Windows.Forms.Button();
            this.panel_instituicao = new System.Windows.Forms.Panel();
            this.b_gestao_de_turmas = new System.Windows.Forms.Button();
            this.b_Dados_geral = new System.Windows.Forms.Button();
            this.b_instituicao = new System.Windows.Forms.Button();
            this.panel_servico = new System.Windows.Forms.Panel();
            this.b_gestao_de_servicos = new System.Windows.Forms.Button();
            this.b_imprimir = new System.Windows.Forms.Button();
            this.b_Tabela_de_preco = new System.Windows.Forms.Button();
            this.b_servico = new System.Windows.Forms.Button();
            this.b_Rupes = new System.Windows.Forms.Button();
            this.panel_usuario = new System.Windows.Forms.Panel();
            this.b_Lista_de_usuarios = new System.Windows.Forms.Button();
            this.b_Cadastrar = new System.Windows.Forms.Button();
            this.b_Gestao_de_usuarios = new System.Windows.Forms.Button();
            this.b_Usuarios = new System.Windows.Forms.Button();
            this.b_conta = new System.Windows.Forms.Button();
            this.pb_logotipo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_minizar = new System.Windows.Forms.Button();
            this.pb_fechar = new System.Windows.Forms.Button();
            this.pb_maximizar = new System.Windows.Forms.PictureBox();
            this.pb_restaurar = new System.Windows.Forms.PictureBox();
            this.panel_menu.SuspendLayout();
            this.panel_logar.SuspendLayout();
            this.panel_instituicao.SuspendLayout();
            this.panel_servico.SuspendLayout();
            this.panel_usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logotipo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_restaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_displaye
            // 
            this.panel_displaye.BackColor = System.Drawing.Color.White;
            this.panel_displaye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_displaye.Location = new System.Drawing.Point(183, 30);
            this.panel_displaye.Name = "panel_displaye";
            this.panel_displaye.Size = new System.Drawing.Size(558, 465);
            this.panel_displaye.TabIndex = 2;
            // 
            // panel_menu
            // 
            this.panel_menu.AutoScroll = true;
            this.panel_menu.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_menu.Controls.Add(this.panel_logar);
            this.panel_menu.Controls.Add(this.b_logar);
            this.panel_menu.Controls.Add(this.panel_instituicao);
            this.panel_menu.Controls.Add(this.b_instituicao);
            this.panel_menu.Controls.Add(this.panel_servico);
            this.panel_menu.Controls.Add(this.b_servico);
            this.panel_menu.Controls.Add(this.b_Rupes);
            this.panel_menu.Controls.Add(this.panel_usuario);
            this.panel_menu.Controls.Add(this.b_Usuarios);
            this.panel_menu.Controls.Add(this.b_conta);
            this.panel_menu.Controls.Add(this.pb_logotipo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 30);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(183, 465);
            this.panel_menu.TabIndex = 4;
            // 
            // panel_logar
            // 
            this.panel_logar.Controls.Add(this.b_logaut);
            this.panel_logar.Controls.Add(this.b_login);
            this.panel_logar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logar.Location = new System.Drawing.Point(0, 509);
            this.panel_logar.Name = "panel_logar";
            this.panel_logar.Size = new System.Drawing.Size(166, 58);
            this.panel_logar.TabIndex = 65;
            // 
            // b_logaut
            // 
            this.b_logaut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_logaut.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_logaut.FlatAppearance.BorderSize = 0;
            this.b_logaut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.b_logaut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_logaut.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_logaut.ForeColor = System.Drawing.Color.White;
            this.b_logaut.Location = new System.Drawing.Point(0, 24);
            this.b_logaut.Name = "b_logaut";
            this.b_logaut.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.b_logaut.Size = new System.Drawing.Size(166, 24);
            this.b_logaut.TabIndex = 58;
            this.b_logaut.Text = "Logout";
            this.b_logaut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_logaut.UseVisualStyleBackColor = true;
            this.b_logaut.Click += new System.EventHandler(this.b_logaut_Click);
            // 
            // b_login
            // 
            this.b_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_login.FlatAppearance.BorderSize = 0;
            this.b_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.b_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_login.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_login.ForeColor = System.Drawing.Color.White;
            this.b_login.Location = new System.Drawing.Point(0, 0);
            this.b_login.Name = "b_login";
            this.b_login.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.b_login.Size = new System.Drawing.Size(166, 24);
            this.b_login.TabIndex = 56;
            this.b_login.Text = "Login";
            this.b_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // b_logar
            // 
            this.b_logar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_logar.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_logar.FlatAppearance.BorderSize = 0;
            this.b_logar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.b_logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_logar.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_logar.ForeColor = System.Drawing.Color.White;
            this.b_logar.Location = new System.Drawing.Point(0, 477);
            this.b_logar.Name = "b_logar";
            this.b_logar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.b_logar.Size = new System.Drawing.Size(166, 32);
            this.b_logar.TabIndex = 64;
            this.b_logar.Text = "Logar";
            this.b_logar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_logar.UseVisualStyleBackColor = true;
            this.b_logar.Click += new System.EventHandler(this.b_logar_Click);
            // 
            // panel_instituicao
            // 
            this.panel_instituicao.Controls.Add(this.b_gestao_de_turmas);
            this.panel_instituicao.Controls.Add(this.b_Dados_geral);
            this.panel_instituicao.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_instituicao.Location = new System.Drawing.Point(0, 419);
            this.panel_instituicao.Name = "panel_instituicao";
            this.panel_instituicao.Size = new System.Drawing.Size(166, 58);
            this.panel_instituicao.TabIndex = 63;
            // 
            // b_gestao_de_turmas
            // 
            this.b_gestao_de_turmas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_gestao_de_turmas.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_gestao_de_turmas.FlatAppearance.BorderSize = 0;
            this.b_gestao_de_turmas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.b_gestao_de_turmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_gestao_de_turmas.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_gestao_de_turmas.ForeColor = System.Drawing.Color.White;
            this.b_gestao_de_turmas.Location = new System.Drawing.Point(0, 24);
            this.b_gestao_de_turmas.Name = "b_gestao_de_turmas";
            this.b_gestao_de_turmas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.b_gestao_de_turmas.Size = new System.Drawing.Size(166, 24);
            this.b_gestao_de_turmas.TabIndex = 58;
            this.b_gestao_de_turmas.Text = "Gestão de turmas";
            this.b_gestao_de_turmas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_gestao_de_turmas.UseVisualStyleBackColor = true;
            this.b_gestao_de_turmas.Click += new System.EventHandler(this.b_gestao_de_turmas_Click);
            // 
            // b_Dados_geral
            // 
            this.b_Dados_geral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Dados_geral.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_Dados_geral.FlatAppearance.BorderSize = 0;
            this.b_Dados_geral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.b_Dados_geral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Dados_geral.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Dados_geral.ForeColor = System.Drawing.Color.White;
            this.b_Dados_geral.Location = new System.Drawing.Point(0, 0);
            this.b_Dados_geral.Name = "b_Dados_geral";
            this.b_Dados_geral.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.b_Dados_geral.Size = new System.Drawing.Size(166, 24);
            this.b_Dados_geral.TabIndex = 56;
            this.b_Dados_geral.Text = "Dados geral";
            this.b_Dados_geral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_Dados_geral.UseVisualStyleBackColor = true;
            this.b_Dados_geral.Click += new System.EventHandler(this.b_Dados_geral_Click);
            // 
            // b_instituicao
            // 
            this.b_instituicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_instituicao.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_instituicao.FlatAppearance.BorderSize = 0;
            this.b_instituicao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.b_instituicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_instituicao.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_instituicao.ForeColor = System.Drawing.Color.White;
            this.b_instituicao.Location = new System.Drawing.Point(0, 387);
            this.b_instituicao.Name = "b_instituicao";
            this.b_instituicao.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.b_instituicao.Size = new System.Drawing.Size(166, 32);
            this.b_instituicao.TabIndex = 62;
            this.b_instituicao.Text = "Instituição";
            this.b_instituicao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_instituicao.UseVisualStyleBackColor = true;
            this.b_instituicao.Click += new System.EventHandler(this.b_instituicao_Click);
            // 
            // panel_servico
            // 
            this.panel_servico.Controls.Add(this.b_gestao_de_servicos);
            this.panel_servico.Controls.Add(this.b_imprimir);
            this.panel_servico.Controls.Add(this.b_Tabela_de_preco);
            this.panel_servico.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_servico.Location = new System.Drawing.Point(0, 309);
            this.panel_servico.Name = "panel_servico";
            this.panel_servico.Size = new System.Drawing.Size(166, 78);
            this.panel_servico.TabIndex = 61;
            // 
            // b_gestao_de_servicos
            // 
            this.b_gestao_de_servicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_gestao_de_servicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_gestao_de_servicos.FlatAppearance.BorderSize = 0;
            this.b_gestao_de_servicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.b_gestao_de_servicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_gestao_de_servicos.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_gestao_de_servicos.ForeColor = System.Drawing.Color.White;
            this.b_gestao_de_servicos.Location = new System.Drawing.Point(0, 48);
            this.b_gestao_de_servicos.Name = "b_gestao_de_servicos";
            this.b_gestao_de_servicos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.b_gestao_de_servicos.Size = new System.Drawing.Size(166, 24);
            this.b_gestao_de_servicos.TabIndex = 59;
            this.b_gestao_de_servicos.Text = "Gestão de serviços";
            this.b_gestao_de_servicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_gestao_de_servicos.UseVisualStyleBackColor = true;
            this.b_gestao_de_servicos.Click += new System.EventHandler(this.b_gestao_de_servicos_Click);
            // 
            // b_imprimir
            // 
            this.b_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_imprimir.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_imprimir.FlatAppearance.BorderSize = 0;
            this.b_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.b_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_imprimir.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_imprimir.ForeColor = System.Drawing.Color.White;
            this.b_imprimir.Location = new System.Drawing.Point(0, 24);
            this.b_imprimir.Name = "b_imprimir";
            this.b_imprimir.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.b_imprimir.Size = new System.Drawing.Size(166, 24);
            this.b_imprimir.TabIndex = 58;
            this.b_imprimir.Text = "Imprimir";
            this.b_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_imprimir.UseVisualStyleBackColor = true;
            this.b_imprimir.Click += new System.EventHandler(this.b_imprimir_Click);
            // 
            // b_Tabela_de_preco
            // 
            this.b_Tabela_de_preco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Tabela_de_preco.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_Tabela_de_preco.FlatAppearance.BorderSize = 0;
            this.b_Tabela_de_preco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.b_Tabela_de_preco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Tabela_de_preco.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Tabela_de_preco.ForeColor = System.Drawing.Color.White;
            this.b_Tabela_de_preco.Location = new System.Drawing.Point(0, 0);
            this.b_Tabela_de_preco.Name = "b_Tabela_de_preco";
            this.b_Tabela_de_preco.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.b_Tabela_de_preco.Size = new System.Drawing.Size(166, 24);
            this.b_Tabela_de_preco.TabIndex = 56;
            this.b_Tabela_de_preco.Text = "Tabela de preços";
            this.b_Tabela_de_preco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_Tabela_de_preco.UseVisualStyleBackColor = true;
            this.b_Tabela_de_preco.Click += new System.EventHandler(this.b_Tabela_de_preco_Click);
            // 
            // b_servico
            // 
            this.b_servico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_servico.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_servico.FlatAppearance.BorderSize = 0;
            this.b_servico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.b_servico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_servico.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_servico.ForeColor = System.Drawing.Color.White;
            this.b_servico.Location = new System.Drawing.Point(0, 277);
            this.b_servico.Name = "b_servico";
            this.b_servico.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.b_servico.Size = new System.Drawing.Size(166, 32);
            this.b_servico.TabIndex = 60;
            this.b_servico.Text = "Serviços";
            this.b_servico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_servico.UseVisualStyleBackColor = true;
            this.b_servico.Click += new System.EventHandler(this.b_servico_Click);
            // 
            // b_Rupes
            // 
            this.b_Rupes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Rupes.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_Rupes.FlatAppearance.BorderSize = 0;
            this.b_Rupes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.b_Rupes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Rupes.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Rupes.ForeColor = System.Drawing.Color.White;
            this.b_Rupes.Location = new System.Drawing.Point(0, 245);
            this.b_Rupes.Name = "b_Rupes";
            this.b_Rupes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.b_Rupes.Size = new System.Drawing.Size(166, 32);
            this.b_Rupes.TabIndex = 59;
            this.b_Rupes.Text = "Rupes";
            this.b_Rupes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_Rupes.UseVisualStyleBackColor = true;
            this.b_Rupes.Click += new System.EventHandler(this.b_Rupes_Click);
            // 
            // panel_usuario
            // 
            this.panel_usuario.Controls.Add(this.b_Lista_de_usuarios);
            this.panel_usuario.Controls.Add(this.b_Cadastrar);
            this.panel_usuario.Controls.Add(this.b_Gestao_de_usuarios);
            this.panel_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_usuario.Location = new System.Drawing.Point(0, 167);
            this.panel_usuario.Name = "panel_usuario";
            this.panel_usuario.Size = new System.Drawing.Size(166, 78);
            this.panel_usuario.TabIndex = 58;
            // 
            // b_Lista_de_usuarios
            // 
            this.b_Lista_de_usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Lista_de_usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_Lista_de_usuarios.FlatAppearance.BorderSize = 0;
            this.b_Lista_de_usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.b_Lista_de_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Lista_de_usuarios.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Lista_de_usuarios.ForeColor = System.Drawing.Color.White;
            this.b_Lista_de_usuarios.Location = new System.Drawing.Point(0, 48);
            this.b_Lista_de_usuarios.Name = "b_Lista_de_usuarios";
            this.b_Lista_de_usuarios.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.b_Lista_de_usuarios.Size = new System.Drawing.Size(166, 24);
            this.b_Lista_de_usuarios.TabIndex = 59;
            this.b_Lista_de_usuarios.Text = "Lista de usuarios";
            this.b_Lista_de_usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_Lista_de_usuarios.UseVisualStyleBackColor = true;
            this.b_Lista_de_usuarios.Click += new System.EventHandler(this.b_Lista_de_usuarios_Click);
            // 
            // b_Cadastrar
            // 
            this.b_Cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Cadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_Cadastrar.FlatAppearance.BorderSize = 0;
            this.b_Cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.b_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Cadastrar.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Cadastrar.ForeColor = System.Drawing.Color.White;
            this.b_Cadastrar.Location = new System.Drawing.Point(0, 24);
            this.b_Cadastrar.Name = "b_Cadastrar";
            this.b_Cadastrar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.b_Cadastrar.Size = new System.Drawing.Size(166, 24);
            this.b_Cadastrar.TabIndex = 58;
            this.b_Cadastrar.Text = "Cadastrar";
            this.b_Cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_Cadastrar.UseVisualStyleBackColor = true;
            this.b_Cadastrar.Click += new System.EventHandler(this.b_Cadastrar_Click);
            // 
            // b_Gestao_de_usuarios
            // 
            this.b_Gestao_de_usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Gestao_de_usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_Gestao_de_usuarios.FlatAppearance.BorderSize = 0;
            this.b_Gestao_de_usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.b_Gestao_de_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Gestao_de_usuarios.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Gestao_de_usuarios.ForeColor = System.Drawing.Color.White;
            this.b_Gestao_de_usuarios.Location = new System.Drawing.Point(0, 0);
            this.b_Gestao_de_usuarios.Name = "b_Gestao_de_usuarios";
            this.b_Gestao_de_usuarios.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.b_Gestao_de_usuarios.Size = new System.Drawing.Size(166, 24);
            this.b_Gestao_de_usuarios.TabIndex = 56;
            this.b_Gestao_de_usuarios.Text = "Gestão de usuarios";
            this.b_Gestao_de_usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_Gestao_de_usuarios.UseVisualStyleBackColor = true;
            this.b_Gestao_de_usuarios.Click += new System.EventHandler(this.b_Gestao_de_usuarios_Click);
            // 
            // b_Usuarios
            // 
            this.b_Usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_Usuarios.FlatAppearance.BorderSize = 0;
            this.b_Usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.b_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Usuarios.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Usuarios.ForeColor = System.Drawing.Color.White;
            this.b_Usuarios.Location = new System.Drawing.Point(0, 135);
            this.b_Usuarios.Name = "b_Usuarios";
            this.b_Usuarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.b_Usuarios.Size = new System.Drawing.Size(166, 32);
            this.b_Usuarios.TabIndex = 9;
            this.b_Usuarios.Text = "Usuarios";
            this.b_Usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_Usuarios.UseVisualStyleBackColor = true;
            this.b_Usuarios.Click += new System.EventHandler(this.b_Usuarios_Click);
            // 
            // b_conta
            // 
            this.b_conta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_conta.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_conta.FlatAppearance.BorderSize = 0;
            this.b_conta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.b_conta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_conta.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_conta.ForeColor = System.Drawing.Color.White;
            this.b_conta.Location = new System.Drawing.Point(0, 103);
            this.b_conta.Name = "b_conta";
            this.b_conta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.b_conta.Size = new System.Drawing.Size(166, 32);
            this.b_conta.TabIndex = 8;
            this.b_conta.Text = "Conta";
            this.b_conta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_conta.UseVisualStyleBackColor = true;
            this.b_conta.Click += new System.EventHandler(this.b_conta_Click);
            // 
            // pb_logotipo
            // 
            this.pb_logotipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_logotipo.Image = global::r.Properties.Resources._16855635565481;
            this.pb_logotipo.Location = new System.Drawing.Point(0, 0);
            this.pb_logotipo.Name = "pb_logotipo";
            this.pb_logotipo.Size = new System.Drawing.Size(166, 103);
            this.pb_logotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logotipo.TabIndex = 7;
            this.pb_logotipo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pb_minizar);
            this.panel1.Controls.Add(this.pb_fechar);
            this.panel1.Controls.Add(this.pb_maximizar);
            this.panel1.Controls.Add(this.pb_restaurar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 30);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pb_minizar
            // 
            this.pb_minizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_minizar.FlatAppearance.BorderSize = 0;
            this.pb_minizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pb_minizar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pb_minizar.ForeColor = System.Drawing.Color.White;
            this.pb_minizar.Location = new System.Drawing.Point(649, 4);
            this.pb_minizar.Name = "pb_minizar";
            this.pb_minizar.Size = new System.Drawing.Size(25, 25);
            this.pb_minizar.TabIndex = 8;
            this.pb_minizar.Text = "-";
            this.pb_minizar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.pb_minizar.UseVisualStyleBackColor = true;
            this.pb_minizar.Click += new System.EventHandler(this.pb_minizar_Click_1);
            // 
            // pb_fechar
            // 
            this.pb_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_fechar.FlatAppearance.BorderSize = 0;
            this.pb_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pb_fechar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pb_fechar.ForeColor = System.Drawing.Color.White;
            this.pb_fechar.Location = new System.Drawing.Point(711, 3);
            this.pb_fechar.Name = "pb_fechar";
            this.pb_fechar.Size = new System.Drawing.Size(25, 25);
            this.pb_fechar.TabIndex = 7;
            this.pb_fechar.Text = "x";
            this.pb_fechar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.pb_fechar.UseVisualStyleBackColor = true;
            this.pb_fechar.Click += new System.EventHandler(this.pb_fechar_Click_1);
            // 
            // pb_maximizar
            // 
            this.pb_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_maximizar.Image = global::r.Properties.Resources.icon1;
            this.pb_maximizar.Location = new System.Drawing.Point(680, 4);
            this.pb_maximizar.Name = "pb_maximizar";
            this.pb_maximizar.Size = new System.Drawing.Size(25, 25);
            this.pb_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_maximizar.TabIndex = 6;
            this.pb_maximizar.TabStop = false;
            this.pb_maximizar.Click += new System.EventHandler(this.pb_maximizar_Click_1);
            // 
            // pb_restaurar
            // 
            this.pb_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_restaurar.Image = global::r.Properties.Resources.icon;
            this.pb_restaurar.Location = new System.Drawing.Point(680, 4);
            this.pb_restaurar.Name = "pb_restaurar";
            this.pb_restaurar.Size = new System.Drawing.Size(25, 25);
            this.pb_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_restaurar.TabIndex = 5;
            this.pb_restaurar.TabStop = false;
            this.pb_restaurar.Click += new System.EventHandler(this.pb_restaurar_Click_1);
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 495);
            this.Controls.Add(this.panel_displaye);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(741, 493);
            this.Name = "Form_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_principal";
            this.Load += new System.EventHandler(this.Form_principal_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_logar.ResumeLayout(false);
            this.panel_instituicao.ResumeLayout(false);
            this.panel_servico.ResumeLayout(false);
            this.panel_usuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logotipo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_restaurar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_displaye;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_restaurar;
        private System.Windows.Forms.PictureBox pb_maximizar;
        private System.Windows.Forms.Button b_conta;
        private System.Windows.Forms.PictureBox pb_logotipo;
        private System.Windows.Forms.Panel panel_instituicao;
        private System.Windows.Forms.Button b_gestao_de_turmas;
        private System.Windows.Forms.Button b_Dados_geral;
        private System.Windows.Forms.Button b_instituicao;
        private System.Windows.Forms.Panel panel_servico;
        private System.Windows.Forms.Button b_gestao_de_servicos;
        private System.Windows.Forms.Button b_imprimir;
        private System.Windows.Forms.Button b_Tabela_de_preco;
        private System.Windows.Forms.Button b_servico;
        private System.Windows.Forms.Button b_Rupes;
        private System.Windows.Forms.Panel panel_usuario;
        private System.Windows.Forms.Button b_Cadastrar;
        private System.Windows.Forms.Button b_Gestao_de_usuarios;
        private System.Windows.Forms.Button b_Usuarios;
        private System.Windows.Forms.Panel panel_logar;
        private System.Windows.Forms.Button b_logaut;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.Button b_logar;
        private System.Windows.Forms.Button b_Lista_de_usuarios;
        private System.Windows.Forms.Button pb_minizar;
        private System.Windows.Forms.Button pb_fechar;
    }
}