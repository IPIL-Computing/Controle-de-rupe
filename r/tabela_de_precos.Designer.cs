namespace r
{
    partial class tabela_de_precos
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
            this.label_quantidade = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.dgv_tabela_de_precos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabela_de_precos)).BeginInit();
            this.SuspendLayout();
            // 
            // label_quantidade
            // 
            this.label_quantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_quantidade.AutoSize = true;
            this.label_quantidade.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantidade.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_quantidade.Location = new System.Drawing.Point(165, 388);
            this.label_quantidade.Name = "label_quantidade";
            this.label_quantidade.Size = new System.Drawing.Size(15, 18);
            this.label_quantidade.TabIndex = 105;
            this.label_quantidade.Text = "0";
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label31.Location = new System.Drawing.Point(12, 386);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(151, 18);
            this.label31.TabIndex = 104;
            this.label31.Text = "Quantidade de serviços:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label30.Location = new System.Drawing.Point(14, -2);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(106, 18);
            this.label30.TabIndex = 103;
            this.label30.Text = "Tabela de preços";
            // 
            // dgv_tabela_de_precos
            // 
            this.dgv_tabela_de_precos.AllowUserToAddRows = false;
            this.dgv_tabela_de_precos.AllowUserToDeleteRows = false;
            this.dgv_tabela_de_precos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_tabela_de_precos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_tabela_de_precos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tabela_de_precos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tabela_de_precos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabela_de_precos.EnableHeadersVisualStyles = false;
            this.dgv_tabela_de_precos.Location = new System.Drawing.Point(15, 19);
            this.dgv_tabela_de_precos.MultiSelect = false;
            this.dgv_tabela_de_precos.Name = "dgv_tabela_de_precos";
            this.dgv_tabela_de_precos.ReadOnly = true;
            this.dgv_tabela_de_precos.RowHeadersVisible = false;
            this.dgv_tabela_de_precos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabela_de_precos.Size = new System.Drawing.Size(402, 355);
            this.dgv_tabela_de_precos.TabIndex = 102;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(342, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 106;
            this.button1.Text = "Ajustar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabela_de_precos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_quantidade);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.dgv_tabela_de_precos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tabela_de_precos";
            this.Text = "tabela_de_precos";
            this.Load += new System.EventHandler(this.tabela_de_precos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabela_de_precos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_quantidade;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataGridView dgv_tabela_de_precos;
        private System.Windows.Forms.Button button1;
    }
}