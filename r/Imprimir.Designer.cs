namespace r
{
    partial class Imprimir
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label39 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.tb_preço_selecionado = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.b_imprimir = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.dgv_servicos = new System.Windows.Forms.DataGridView();
            this.panel21 = new System.Windows.Forms.Panel();
            this.tb_ser_selecionado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.t_curso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.t_area = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.t_turma = new System.Windows.Forms.TextBox();
            this.b_ok = new System.Windows.Forms.Button();
            this.document = new System.Drawing.Printing.PrintDocument();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicos)).BeginInit();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label39
            // 
            this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label39.Location = new System.Drawing.Point(372, 59);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(41, 18);
            this.label39.TabIndex = 129;
            this.label39.Text = "Preço";
            // 
            // panel22
            // 
            this.panel22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel22.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel22.Controls.Add(this.tb_preço_selecionado);
            this.panel22.Location = new System.Drawing.Point(375, 80);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(162, 26);
            this.panel22.TabIndex = 128;
            // 
            // tb_preço_selecionado
            // 
            this.tb_preço_selecionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_preço_selecionado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_preço_selecionado.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_preço_selecionado.ForeColor = System.Drawing.Color.SteelBlue;
            this.tb_preço_selecionado.Location = new System.Drawing.Point(0, 0);
            this.tb_preço_selecionado.Multiline = true;
            this.tb_preço_selecionado.Name = "tb_preço_selecionado";
            this.tb_preço_selecionado.Size = new System.Drawing.Size(162, 24);
            this.tb_preço_selecionado.TabIndex = 0;
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label36.Location = new System.Drawing.Point(372, 9);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(123, 18);
            this.label36.TabIndex = 127;
            this.label36.Text = "serviço selecionado";
            // 
            // dgv_dados
            // 
            this.dgv_dados.AllowUserToAddRows = false;
            this.dgv_dados.AllowUserToDeleteRows = false;
            this.dgv_dados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_dados.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.EnableHeadersVisualStyles = false;
            this.dgv_dados.Location = new System.Drawing.Point(12, 294);
            this.dgv_dados.MultiSelect = false;
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.ReadOnly = true;
            this.dgv_dados.RowHeadersVisible = false;
            this.dgv_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dados.Size = new System.Drawing.Size(525, 221);
            this.dgv_dados.TabIndex = 126;
            // 
            // b_imprimir
            // 
            this.b_imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_imprimir.BackColor = System.Drawing.Color.DodgerBlue;
            this.b_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_imprimir.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_imprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_imprimir.Location = new System.Drawing.Point(466, 516);
            this.b_imprimir.Name = "b_imprimir";
            this.b_imprimir.Size = new System.Drawing.Size(81, 24);
            this.b_imprimir.TabIndex = 125;
            this.b_imprimir.Text = "Imprimir";
            this.b_imprimir.UseVisualStyleBackColor = false;
            this.b_imprimir.Click += new System.EventHandler(this.b_imprimir_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label35.Location = new System.Drawing.Point(12, 9);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(57, 18);
            this.label35.TabIndex = 124;
            this.label35.Text = "serviços";
            // 
            // dgv_servicos
            // 
            this.dgv_servicos.AllowUserToAddRows = false;
            this.dgv_servicos.AllowUserToDeleteRows = false;
            this.dgv_servicos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_servicos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_servicos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_servicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_servicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_servicos.EnableHeadersVisualStyles = false;
            this.dgv_servicos.Location = new System.Drawing.Point(12, 30);
            this.dgv_servicos.MultiSelect = false;
            this.dgv_servicos.Name = "dgv_servicos";
            this.dgv_servicos.ReadOnly = true;
            this.dgv_servicos.RowHeadersVisible = false;
            this.dgv_servicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_servicos.Size = new System.Drawing.Size(354, 75);
            this.dgv_servicos.TabIndex = 123;
            this.dgv_servicos.SelectionChanged += new System.EventHandler(this.dgv_servicos_SelectionChanged);
            // 
            // panel21
            // 
            this.panel21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel21.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel21.Controls.Add(this.tb_ser_selecionado);
            this.panel21.Location = new System.Drawing.Point(375, 30);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(162, 26);
            this.panel21.TabIndex = 122;
            // 
            // tb_ser_selecionado
            // 
            this.tb_ser_selecionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ser_selecionado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ser_selecionado.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ser_selecionado.ForeColor = System.Drawing.Color.SteelBlue;
            this.tb_ser_selecionado.Location = new System.Drawing.Point(0, 0);
            this.tb_ser_selecionado.Multiline = true;
            this.tb_ser_selecionado.Name = "tb_ser_selecionado";
            this.tb_ser_selecionado.Size = new System.Drawing.Size(162, 24);
            this.tb_ser_selecionado.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(12, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 133;
            this.button1.Text = "Ajustar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(12, 129);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(525, 91);
            this.dataGridView.TabIndex = 134;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(180, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 138;
            this.label1.Text = "Curso";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.t_curso);
            this.panel1.Location = new System.Drawing.Point(183, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 26);
            this.panel1.TabIndex = 137;
            // 
            // t_curso
            // 
            this.t_curso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_curso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_curso.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_curso.ForeColor = System.Drawing.Color.SteelBlue;
            this.t_curso.Location = new System.Drawing.Point(0, 0);
            this.t_curso.Multiline = true;
            this.t_curso.Name = "t_curso";
            this.t_curso.Size = new System.Drawing.Size(162, 24);
            this.t_curso.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(6, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 136;
            this.label2.Text = "Dados selecionados";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.t_area);
            this.panel2.Location = new System.Drawing.Point(12, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 26);
            this.panel2.TabIndex = 135;
            // 
            // t_area
            // 
            this.t_area.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_area.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_area.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_area.ForeColor = System.Drawing.Color.SteelBlue;
            this.t_area.Location = new System.Drawing.Point(0, 0);
            this.t_area.Multiline = true;
            this.t_area.Name = "t_area";
            this.t_area.Size = new System.Drawing.Size(162, 24);
            this.t_area.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(9, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 139;
            this.label3.Text = "Dados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(9, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 140;
            this.label4.Text = "Area de formação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(351, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 142;
            this.label5.Text = "Turma";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.t_turma);
            this.panel3.Location = new System.Drawing.Point(354, 262);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 26);
            this.panel3.TabIndex = 141;
            // 
            // t_turma
            // 
            this.t_turma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_turma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_turma.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_turma.ForeColor = System.Drawing.Color.SteelBlue;
            this.t_turma.Location = new System.Drawing.Point(0, 0);
            this.t_turma.Multiline = true;
            this.t_turma.Name = "t_turma";
            this.t_turma.Size = new System.Drawing.Size(104, 24);
            this.t_turma.TabIndex = 0;
            // 
            // b_ok
            // 
            this.b_ok.BackColor = System.Drawing.Color.DodgerBlue;
            this.b_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_ok.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_ok.Location = new System.Drawing.Point(466, 264);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(71, 24);
            this.b_ok.TabIndex = 143;
            this.b_ok.Text = "Ok";
            this.b_ok.UseVisualStyleBackColor = false;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // document
            // 
            this.document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.document_PrintPage);
            // 
            // Imprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 542);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.panel22);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.dgv_dados);
            this.Controls.Add(this.b_imprimir);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.dgv_servicos);
            this.Controls.Add(this.panel21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Imprimir";
            this.Text = "Imprimir";
            this.Load += new System.EventHandler(this.Imprimir_Load);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicos)).EndInit();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TextBox tb_preço_selecionado;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.Button b_imprimir;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DataGridView dgv_servicos;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.TextBox tb_ser_selecionado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox t_curso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox t_area;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox t_turma;
        private System.Windows.Forms.Button b_ok;
        private System.Drawing.Printing.PrintDocument document;
    }
}