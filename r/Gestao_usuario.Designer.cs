namespace r
{
    partial class Gestao_usuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lb_ID = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.dgv_ID = new System.Windows.Forms.DataGridView();
            this.b_excluir = new System.Windows.Forms.Button();
            this.b_salvar = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.NUD_nivel = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.tb_nome_usuario = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tb_idade = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_nivel)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel12.Controls.Add(this.lb_ID);
            this.panel12.Location = new System.Drawing.Point(48, 296);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(64, 26);
            this.panel12.TabIndex = 109;
            // 
            // lb_ID
            // 
            this.lb_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ID.BackColor = System.Drawing.Color.White;
            this.lb_ID.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.lb_ID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_ID.Location = new System.Drawing.Point(-2, 0);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(67, 24);
            this.lb_ID.TabIndex = 1;
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label29.Location = new System.Drawing.Point(13, 304);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(27, 18);
            this.label29.TabIndex = 108;
            this.label29.Text = "ID :";
            // 
            // dgv_ID
            // 
            this.dgv_ID.AllowUserToAddRows = false;
            this.dgv_ID.AllowUserToDeleteRows = false;
            this.dgv_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ID.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ID.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ID.EnableHeadersVisualStyles = false;
            this.dgv_ID.Location = new System.Drawing.Point(240, 39);
            this.dgv_ID.MultiSelect = false;
            this.dgv_ID.Name = "dgv_ID";
            this.dgv_ID.ReadOnly = true;
            this.dgv_ID.RowHeadersVisible = false;
            this.dgv_ID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ID.Size = new System.Drawing.Size(122, 312);
            this.dgv_ID.TabIndex = 107;
            this.dgv_ID.SelectionChanged += new System.EventHandler(this.dgv_ID_SelectionChanged);
            // 
            // b_excluir
            // 
            this.b_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_excluir.BackColor = System.Drawing.Color.DodgerBlue;
            this.b_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_excluir.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_excluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_excluir.Location = new System.Drawing.Point(145, 357);
            this.b_excluir.Name = "b_excluir";
            this.b_excluir.Size = new System.Drawing.Size(111, 24);
            this.b_excluir.TabIndex = 106;
            this.b_excluir.Text = "Excluir usuario";
            this.b_excluir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_excluir.UseVisualStyleBackColor = false;
            this.b_excluir.Click += new System.EventHandler(this.b_excluir_Click);
            // 
            // b_salvar
            // 
            this.b_salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_salvar.BackColor = System.Drawing.Color.DodgerBlue;
            this.b_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_salvar.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_salvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_salvar.Location = new System.Drawing.Point(15, 357);
            this.b_salvar.Name = "b_salvar";
            this.b_salvar.Size = new System.Drawing.Size(121, 24);
            this.b_salvar.TabIndex = 105;
            this.b_salvar.Text = "Salvar alterações";
            this.b_salvar.UseVisualStyleBackColor = false;
            this.b_salvar.Click += new System.EventHandler(this.b_salvar_Click);
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label28.Location = new System.Drawing.Point(237, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(137, 18);
            this.label28.TabIndex = 104;
            this.label28.Text = "Lista de ID de usuario";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label21.Location = new System.Drawing.Point(13, 242);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(216, 18);
            this.label21.TabIndex = 103;
            this.label21.Text = "1 significa nivel de Adiministrador";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label22.Location = new System.Drawing.Point(13, 221);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(167, 18);
            this.label22.TabIndex = 102;
            this.label22.Text = "0 significa nivel de usuario";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label23.Location = new System.Drawing.Point(13, 168);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(99, 18);
            this.label23.TabIndex = 101;
            this.label23.Text = "Nivel de acesso";
            // 
            // NUD_nivel
            // 
            this.NUD_nivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUD_nivel.Location = new System.Drawing.Point(15, 189);
            this.NUD_nivel.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUD_nivel.Name = "NUD_nivel";
            this.NUD_nivel.Size = new System.Drawing.Size(99, 20);
            this.NUD_nivel.TabIndex = 100;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label25.Location = new System.Drawing.Point(12, 107);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(110, 18);
            this.label25.TabIndex = 99;
            this.label25.Text = "Nome de usuário";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel11.Controls.Add(this.tb_nome_usuario);
            this.panel11.Location = new System.Drawing.Point(16, 128);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(176, 26);
            this.panel11.TabIndex = 98;
            // 
            // tb_nome_usuario
            // 
            this.tb_nome_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_nome_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_nome_usuario.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome_usuario.ForeColor = System.Drawing.Color.SteelBlue;
            this.tb_nome_usuario.Location = new System.Drawing.Point(0, 0);
            this.tb_nome_usuario.Multiline = true;
            this.tb_nome_usuario.Name = "tb_nome_usuario";
            this.tb_nome_usuario.Size = new System.Drawing.Size(176, 24);
            this.tb_nome_usuario.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel14.Controls.Add(this.tb_idade);
            this.panel14.Location = new System.Drawing.Point(58, 75);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(24, 26);
            this.panel14.TabIndex = 95;
            // 
            // tb_idade
            // 
            this.tb_idade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_idade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_idade.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idade.ForeColor = System.Drawing.Color.SteelBlue;
            this.tb_idade.Location = new System.Drawing.Point(0, 0);
            this.tb_idade.Multiline = true;
            this.tb_idade.Name = "tb_idade";
            this.tb_idade.Size = new System.Drawing.Size(24, 24);
            this.tb_idade.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label26.Location = new System.Drawing.Point(12, 83);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 18);
            this.label26.TabIndex = 96;
            this.label26.Text = "Idade :";
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label27.Location = new System.Drawing.Point(12, 9);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(102, 18);
            this.label27.TabIndex = 97;
            this.label27.Text = "Nome completo";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel15.Controls.Add(this.tb_nome);
            this.panel15.Location = new System.Drawing.Point(15, 39);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(179, 26);
            this.panel15.TabIndex = 94;
            // 
            // tb_nome
            // 
            this.tb_nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_nome.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.ForeColor = System.Drawing.Color.SteelBlue;
            this.tb_nome.Location = new System.Drawing.Point(0, 0);
            this.tb_nome.Multiline = true;
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(185, 24);
            this.tb_nome.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(16, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 134;
            this.button1.Text = "Ajustar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(13, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 18);
            this.label1.TabIndex = 135;
            this.label1.Text = "2 significa nivel de Adiministrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(13, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 136;
            this.label2.Text = "master";
            // 
            // Gestao_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(367, 393);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.dgv_ID);
            this.Controls.Add(this.b_excluir);
            this.Controls.Add(this.b_salvar);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.NUD_nivel);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.panel15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestao_usuario";
            this.Text = "Gestao_usuario";
            this.Load += new System.EventHandler(this.Gestao_usuario_Load);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_nivel)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridView dgv_ID;
        private System.Windows.Forms.Button b_excluir;
        private System.Windows.Forms.Button b_salvar;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown NUD_nivel;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox tb_nome_usuario;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox tb_idade;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}