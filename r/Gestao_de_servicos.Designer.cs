namespace r
{
    partial class Gestao_de_servicos
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
            this.b_importar = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.tb_ide = new System.Windows.Forms.TextBox();
            this.b_novo = new System.Windows.Forms.Button();
            this.b_salvar = new System.Windows.Forms.Button();
            this.b_excluir = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.tb_servico = new System.Windows.Forms.TextBox();
            this.label_quantidade = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.dgv_servico = new System.Windows.Forms.DataGridView();
            this.label32 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servico)).BeginInit();
            this.SuspendLayout();
            // 
            // b_importar
            // 
            this.b_importar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_importar.BackColor = System.Drawing.Color.DodgerBlue;
            this.b_importar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_importar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_importar.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_importar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_importar.Location = new System.Drawing.Point(9, 325);
            this.b_importar.Name = "b_importar";
            this.b_importar.Size = new System.Drawing.Size(121, 24);
            this.b_importar.TabIndex = 125;
            this.b_importar.Text = "Importar serviço";
            this.b_importar.UseVisualStyleBackColor = false;
            this.b_importar.Click += new System.EventHandler(this.b_importar_Click);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel17.Controls.Add(this.tb_ide);
            this.panel17.Location = new System.Drawing.Point(38, 131);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(42, 26);
            this.panel17.TabIndex = 124;
            // 
            // tb_ide
            // 
            this.tb_ide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ide.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ide.ForeColor = System.Drawing.Color.SteelBlue;
            this.tb_ide.Location = new System.Drawing.Point(0, 0);
            this.tb_ide.Multiline = true;
            this.tb_ide.Name = "tb_ide";
            this.tb_ide.Size = new System.Drawing.Size(42, 24);
            this.tb_ide.TabIndex = 0;
            // 
            // b_novo
            // 
            this.b_novo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_novo.BackColor = System.Drawing.Color.DodgerBlue;
            this.b_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_novo.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_novo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_novo.Location = new System.Drawing.Point(9, 273);
            this.b_novo.Name = "b_novo";
            this.b_novo.Size = new System.Drawing.Size(121, 24);
            this.b_novo.TabIndex = 123;
            this.b_novo.Text = "Novo serviço";
            this.b_novo.UseVisualStyleBackColor = false;
            this.b_novo.Click += new System.EventHandler(this.b_novo_Click);
            // 
            // b_salvar
            // 
            this.b_salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_salvar.BackColor = System.Drawing.Color.DodgerBlue;
            this.b_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_salvar.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_salvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_salvar.Location = new System.Drawing.Point(10, 244);
            this.b_salvar.Name = "b_salvar";
            this.b_salvar.Size = new System.Drawing.Size(121, 24);
            this.b_salvar.TabIndex = 122;
            this.b_salvar.Text = "Salvar alterações";
            this.b_salvar.UseVisualStyleBackColor = false;
            this.b_salvar.Click += new System.EventHandler(this.b_salvar_Click);
            // 
            // b_excluir
            // 
            this.b_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_excluir.BackColor = System.Drawing.Color.DodgerBlue;
            this.b_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_excluir.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_excluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_excluir.Location = new System.Drawing.Point(9, 299);
            this.b_excluir.Name = "b_excluir";
            this.b_excluir.Size = new System.Drawing.Size(121, 24);
            this.b_excluir.TabIndex = 121;
            this.b_excluir.Text = "Excluir serviço";
            this.b_excluir.UseVisualStyleBackColor = false;
            this.b_excluir.Click += new System.EventHandler(this.b_excluir_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label45.Location = new System.Drawing.Point(9, 80);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(41, 18);
            this.label45.TabIndex = 120;
            this.label45.Text = "Preço";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel18.Controls.Add(this.tb_preco);
            this.panel18.Location = new System.Drawing.Point(13, 101);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(150, 26);
            this.panel18.TabIndex = 119;
            // 
            // tb_preco
            // 
            this.tb_preco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_preco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_preco.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_preco.ForeColor = System.Drawing.Color.SteelBlue;
            this.tb_preco.Location = new System.Drawing.Point(0, 0);
            this.tb_preco.Multiline = true;
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(150, 24);
            this.tb_preco.TabIndex = 0;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label46.Location = new System.Drawing.Point(9, 34);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(52, 18);
            this.label46.TabIndex = 118;
            this.label46.Text = "Serviço";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel19.Controls.Add(this.tb_servico);
            this.panel19.Location = new System.Drawing.Point(10, 50);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(153, 26);
            this.panel19.TabIndex = 117;
            // 
            // tb_servico
            // 
            this.tb_servico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_servico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_servico.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_servico.ForeColor = System.Drawing.Color.SteelBlue;
            this.tb_servico.Location = new System.Drawing.Point(0, 0);
            this.tb_servico.Multiline = true;
            this.tb_servico.Name = "tb_servico";
            this.tb_servico.Size = new System.Drawing.Size(153, 24);
            this.tb_servico.TabIndex = 0;
            // 
            // label_quantidade
            // 
            this.label_quantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_quantidade.AutoSize = true;
            this.label_quantidade.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantidade.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_quantidade.Location = new System.Drawing.Point(166, 362);
            this.label_quantidade.Name = "label_quantidade";
            this.label_quantidade.Size = new System.Drawing.Size(15, 18);
            this.label_quantidade.TabIndex = 116;
            this.label_quantidade.Text = "0";
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label33.Location = new System.Drawing.Point(13, 359);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(151, 18);
            this.label33.TabIndex = 115;
            this.label33.Text = "Quantidade de serviços:";
            this.label33.Click += new System.EventHandler(this.label33_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label34.Location = new System.Drawing.Point(12, 9);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(155, 18);
            this.label34.TabIndex = 114;
            this.label34.Text = "Lista de Servços e preços";
            // 
            // dgv_servico
            // 
            this.dgv_servico.AllowUserToAddRows = false;
            this.dgv_servico.AllowUserToDeleteRows = false;
            this.dgv_servico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_servico.BackgroundColor = System.Drawing.Color.White;
            this.dgv_servico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_servico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_servico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_servico.EnableHeadersVisualStyles = false;
            this.dgv_servico.Location = new System.Drawing.Point(169, 31);
            this.dgv_servico.MultiSelect = false;
            this.dgv_servico.Name = "dgv_servico";
            this.dgv_servico.ReadOnly = true;
            this.dgv_servico.RowHeadersVisible = false;
            this.dgv_servico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_servico.Size = new System.Drawing.Size(265, 318);
            this.dgv_servico.TabIndex = 113;
            this.dgv_servico.SelectionChanged += new System.EventHandler(this.dgv_servico_SelectionChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label32.Location = new System.Drawing.Point(12, 139);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(21, 18);
            this.label32.TabIndex = 127;
            this.label32.Text = "ID";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(359, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 128;
            this.button1.Text = "Ajustar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gestao_de_servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.b_importar);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.b_novo);
            this.Controls.Add(this.b_salvar);
            this.Controls.Add(this.b_excluir);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.label_quantidade);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.dgv_servico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestao_de_servicos";
            this.Text = "Gestao_de_servicos";
            this.Load += new System.EventHandler(this.Gestao_de_servicos_Load);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_importar;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox tb_ide;
        private System.Windows.Forms.Button b_novo;
        private System.Windows.Forms.Button b_salvar;
        private System.Windows.Forms.Button b_excluir;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.TextBox tb_servico;
        private System.Windows.Forms.Label label_quantidade;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.DataGridView dgv_servico;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button button1;
    }
}