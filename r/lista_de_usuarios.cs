using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r
{
    public partial class lista_de_usuarios : Form
    {
        public lista_de_usuarios()
        {
            InitializeComponent();
        }

        private void lista_de_usuarios_Load(object sender, EventArgs e)
        {
            if (dados.nivel ==2) {dgv_lista_usuario.DataSource = Cl_geral.obtertodosusuarios();
            int n = dgv_lista_usuario.RowCount;
            label_quantidade.Text = n.ToString(); }
            else if(dados.nivel==1) {
                dgv_lista_usuario.DataSource = Cl_geral.obterusuarios();
                int n = dgv_lista_usuario.RowCount;
                label_quantidade.Text = n.ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dados.nivel == 2)
            {
                int n = dgv_lista_usuario.Width;
                int t = n / 7;
                dgv_lista_usuario.Columns[0].Width = t;
                dgv_lista_usuario.Columns[1].Width = t;
                dgv_lista_usuario.Columns[2].Width = t;
                dgv_lista_usuario.Columns[3].Width = t;
                dgv_lista_usuario.Columns[4].Width = t;
                dgv_lista_usuario.Columns[5].Width = t;
                dgv_lista_usuario.Columns[6].Width = t;
            }
            else if (dados.nivel == 1)
            {
                int n = dgv_lista_usuario.Width;
                int t = n / 6;
                dgv_lista_usuario.Columns[0].Width = t;
                dgv_lista_usuario.Columns[1].Width = t;
                dgv_lista_usuario.Columns[2].Width = t;
                dgv_lista_usuario.Columns[3].Width = t;
                dgv_lista_usuario.Columns[4].Width = t;
                dgv_lista_usuario.Columns[5].Width = t;
            }
            
        }
    }
}
