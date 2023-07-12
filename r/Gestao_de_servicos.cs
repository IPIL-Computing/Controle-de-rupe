using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r
{
    public partial class Gestao_de_servicos : Form
    {
        public Gestao_de_servicos()
        {
            InitializeComponent();
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }
        string a;
        private void Gestao_de_servicos_Load(object sender, EventArgs e)
        {
            if (dados.nivel == 1) { b_importar.Visible = false; }else if (dados.nivel == 2) { b_importar.Visible = true; }
            int n = dgv_servico.RowCount;
            label_quantidade.Text = n.ToString();
            dgv_servico.DataSource = Cl_geral.obtertodosservicos();

        }

        private void dgv_servico_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dvg = (DataGridView)sender;
            int contlinha = dvg.SelectedRows.Count;
            if (contlinha > 0)
            {
                DataTable dt = new DataTable();
                string vid = dvg.SelectedRows[0].Cells[2].Value.ToString();
                dt = Cl_geral.obtertodoservicos(vid);
                tb_servico.Text = dt.Rows[0].Field<string>("Serviços").ToString();
                tb_preco.Text = dt.Rows[0].Field<string>("Preço").ToString();
                tb_ide.Text = dt.Rows[0].Field<Int64>("ID").ToString();
            }
        }

        private void b_importar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "select file";
            fdlg.FileName = a;
            fdlg.Filter = "Excel sheet (*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK) { a = fdlg.FileName; }
            try
            {
                var dt = new DataTable();
                using (OleDbConnection theconection = new OleDbConnection(/*string.Format(@*/"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + a + "';Extended Properties=Excel 8.0; HDR = YES"))
                {
                    using (OleDbDataAdapter thedata = new OleDbDataAdapter("select *from[sheet1$]", theconection))
                    {
                        thedata.Fill(dt);
                        dgv_servico.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void b_novo_Click(object sender, EventArgs e)
        {
            if (tb_servico.Text == "" || tb_preco.Text == "") { MessageBox.Show("Preencha os liugares vazios"); }
            else
            {
                dados servicos = new dados();
                servicos.preco = tb_preco.Text;
                servicos.servico = tb_servico.Text;
                Cl_geral.novo_serevico(servicos);
                int n = dgv_servico.RowCount;
                label_quantidade.Text = n.ToString();
                dgv_servico.DataSource = Cl_geral.obtertodosservicos();
            }
        }

        private void b_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Cl_geral.delectarservicos(tb_ide.Text);
                dgv_servico.DataSource = Cl_geral.obtertodosservicos();
                tb_servico.Text = "";
                tb_preco.Text = "";
                tb_ide.Text = "";
            }
        }

        private void b_salvar_Click(object sender, EventArgs e)
        {
            int linha = dgv_servico.SelectedRows[0].Index;
            dados u1 = new dados();
            u1.ID = tb_ide.Text;
            u1.servico = tb_servico.Text;
            u1.preco = tb_preco.Text;
            Cl_geral.atualizaruarios(u1);
            dgv_servico.DataSource = Cl_geral.obtertodosservicos();
            dgv_servico.CurrentCell = dgv_servico[0, linha];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dgv_servico.Width;
            int t = n / 3;
            dgv_servico.Columns[0].Width = t;
            dgv_servico.Columns[1].Width = t;
            dgv_servico.Columns[2].Width = t;
        }
    }
}
