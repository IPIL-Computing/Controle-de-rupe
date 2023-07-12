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
    public partial class Gestao_usuario : Form
    {
        public Gestao_usuario()
        {
            InitializeComponent();
        }
        private void b_salvar_Click(object sender, EventArgs e)
        {
            if (dados.nivel == 2)
            {
                int linha = dgv_ID.SelectedRows[0].Index;
                dados u1 = new dados();
                u1.ID = lb_ID.Text;
                u1.NIVELUSUARIO = Convert.ToInt32(Math.Round(NUD_nivel.Value));
                u1.NOMEUSUARIO = tb_nome.Text;
                u1.USERNAME = tb_nome_usuario.Text;
                Cl_geral.atualizaruarios(u1);
                dgv_ID.DataSource = Cl_geral.obterusuariosIDnomes();
                dgv_ID.CurrentCell = dgv_ID[0, linha];
            }
            else if (dados.nivel == 1)
            {
                int linha = dgv_ID.SelectedRows[0].Index;
                Int64 n= Convert.ToInt32(Math.Round(NUD_nivel.Value));
                if (n == 2) { MessageBox.Show("Impossivel de promover esta conta"); }
                else
                {
                    dados u1 = new dados();
                    u1.ID = lb_ID.Text;
                    u1.NIVELUSUARIO = Convert.ToInt32(Math.Round(NUD_nivel.Value));
                    u1.NOMEUSUARIO = tb_nome.Text;
                    u1.USERNAME = tb_nome_usuario.Text;
                    Cl_geral.atualizaruarios(u1);
                    dgv_ID.DataSource = Cl_geral.obterusuariosIDnomes();
                    dgv_ID.CurrentCell = dgv_ID[0, linha];
                }
            }
        }
        private void b_excluir_Click(object sender, EventArgs e)
        {
            if (dados.nivel == 1)
            {
                if (NUD_nivel.Value >= 2)
                {
                    MessageBox.Show("Impossivel deletar esta conta", "Atenção");
                }
                else
                {
                    DialogResult res = MessageBox.Show("Confirma exclusão", "Excluir", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        Cl_geral.delectaruarios(lb_ID.Text);
                        dgv_ID.DataSource = Cl_geral.obterusuariosIDnomes();
                    }
                }
            }
            else if (dados.nivel == 2)
            {
                DialogResult res = MessageBox.Show("Confirma exclusão", "Excluir", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Cl_geral.delectaruarios(lb_ID.Text);
                    dgv_ID.DataSource = Cl_geral.obterusuariosIDnomes();
                }
            }
        }
        private void dgv_ID_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dvg = (DataGridView)sender;
            int contlinha = dvg.SelectedRows.Count;
            if (contlinha > 0)
            {
                DataTable dt = new DataTable();
                string vid = dvg.SelectedRows[0].Cells[0].Value.ToString();
                dt = Cl_geral.ObterDadosUsuarios(vid);
                tb_nome.Text = dt.Rows[0].Field<string>("nome").ToString();
                tb_idade.Text = dt.Rows[0].Field<string>("idade").ToString();
                tb_nome_usuario.Text = dt.Rows[0].Field<string>("username").ToString();
                lb_ID.Text = dt.Rows[0].Field<Int64>("ID").ToString();
                NUD_nivel.Text = dt.Rows[0].Field<Int64>("nivel").ToString();
            }
        }
        private void Gestao_usuario_Load(object sender, EventArgs e)
        {
            dgv_ID.DataSource = Cl_geral.obterusuariosIDnomes();
            if (dados.nivel == 1){ label1.Visible = false; label2.Visible = false; } else { label1.Visible = true; label1.Visible = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dgv_ID.Width;
            dgv_ID.Columns[0].Width = n;
        }
    }
}
