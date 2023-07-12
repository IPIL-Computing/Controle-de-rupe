namespace r
{
    partial class Rupes
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
            this.dgv_rupe = new System.Windows.Forms.DataGridView();
            this.b_importar = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rupe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_rupe
            // 
            this.dgv_rupe.AllowUserToAddRows = false;
            this.dgv_rupe.AllowUserToDeleteRows = false;
            this.dgv_rupe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_rupe.BackgroundColor = System.Drawing.Color.White;
            this.dgv_rupe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_rupe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_rupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rupe.EnableHeadersVisualStyles = false;
            this.dgv_rupe.Location = new System.Drawing.Point(12, 30);
            this.dgv_rupe.MultiSelect = false;
            this.dgv_rupe.Name = "dgv_rupe";
            this.dgv_rupe.ReadOnly = true;
            this.dgv_rupe.RowHeadersVisible = false;
            this.dgv_rupe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_rupe.Size = new System.Drawing.Size(366, 318);
            this.dgv_rupe.TabIndex = 95;
            // 
            // b_importar
            // 
            this.b_importar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_importar.BackColor = System.Drawing.Color.DodgerBlue;
            this.b_importar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_importar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_importar.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_importar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_importar.Location = new System.Drawing.Point(12, 354);
            this.b_importar.Name = "b_importar";
            this.b_importar.Size = new System.Drawing.Size(152, 24);
            this.b_importar.TabIndex = 94;
            this.b_importar.Text = "Importar";
            this.b_importar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_importar.UseVisualStyleBackColor = false;
            this.b_importar.Click += new System.EventHandler(this.b_importar_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label37.Location = new System.Drawing.Point(2, 9);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(89, 18);
            this.label37.TabIndex = 92;
            this.label37.Text = "Lista de Rupe";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(304, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 107;
            this.button1.Text = "Ajustar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rupes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_rupe);
            this.Controls.Add(this.b_importar);
            this.Controls.Add(this.label37);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rupes";
            this.Text = "Rupes";
            this.Load += new System.EventHandler(this.Rupes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rupe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_rupe;
        private System.Windows.Forms.Button b_importar;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button button1;
    }
}