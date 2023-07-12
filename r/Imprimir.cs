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
    public partial class Imprimir : Form
    {
        public Imprimir()
        {
            InitializeComponent();
            

        }
        private void dgv_servicos_SelectionChanged(object sender, EventArgs e)
        {
        DataGridView dvg = (DataGridView)sender;
            int contlinha = dvg.SelectedRows.Count;
        if (contlinha > 0)
        {
            DataTable dt = new DataTable();
            string vid = dvg.SelectedRows[0].Cells[2].Value.ToString();
                dt = Cl_geral.obtertodoservicos(vid);
            tb_ser_selecionado.Text = dt.Rows[0].Field<string>("Serviços").ToString();
            tb_preço_selecionado.Text = dt.Rows[0].Field<string>("Preço").ToString();

        }
        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
        //    DataGridView dvg = (DataGridView)sender;
        //    int contlinha = dvg.SelectedRows.Count; ;
        //    if (contlinha > 0)
        //    {
        //        DataTable dt = new DataTable();
        //        string vid = dvg.SelectedRows[0].Cells[5].Value.ToString();
        //        dt = Cl_geral.Obter_Dados22(vid);
        //        t_area.Text = dt.Rows[0].Field<string>("Area").ToString();
        //        t_turma.Text = dt.Rows[0].Field<string>("Turmas").ToString();
        //        t_curso.Text = dt.Rows[0].Field<string>("curso").ToString();
        //    }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = dgv_servicos.Width;
            int t = n / 3;
            dgv_servicos.Columns[0].Width = t;
            dgv_servicos.Columns[1].Width = t;
            dgv_servicos.Columns[2].Width = t;

            int n1 = dataGridView.Width;
            int t1=n1 / 4;
            dataGridView.Columns[0].Width = t1;
            dataGridView.Columns[1].Width = t1;
            dataGridView.Columns[2].Width = t1;
            dataGridView.Columns[3].Width = t1;
        }

        private void Imprimir_Load(object sender, EventArgs e)
        {
            dgv_servicos.DataSource = Cl_geral.obtertodosservicos();
            dataGridView.DataSource = Cl_geral.Obter_Dados2();
        
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            if (t_area.Text == "" || t_turma.Text == "" || t_curso.Text == "") { MessageBox.Show("Preencha os liugares vazios"); }
            else
            {
                dgv_dados.DataSource = Cl_geral.Obter_Dados22(t_area.Text,t_curso.Text,t_turma.Text);
            }
        }
        int larg;
        int alt;
        private void b_imprimir_Click(object sender, EventArgs e)
        {
        //    lectra = new Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel);
        //    cor = new SolidBrush(Color.Black);
        //    larg = document.DefaultPageSettings.Bounds.Width;
        //    alt = document.DefaultPageSettings.Bounds.Width;
        //    document.Print();
        }
        Font lectra;
        SolidBrush cor;
        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int n = dgv_dados.RowCount;
            MessageBox.Show(n.ToString());
            DataTable dt = new DataTable();
            for (int i = 0; i < n; i++)
            {
                StringFormat aliamento = new StringFormat();
                aliamento.Alignment = StringAlignment.Near;
                aliamento.LineAlignment = StringAlignment.Near;
                Image cartao = Image.FromFile(@"C:\Users\DELL\Documents\Visual Studio 2015\Projects\r\base\png.jpg");
                e.Graphics.DrawImage(cartao, new Rectangle(40,50, larg, alt));
                e.Graphics.DrawString(dt.Rows[i].Field<string>("Area").ToString(), new Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), cor, new Rectangle(10, 30, 160,100));
                e.Graphics.DrawString(dt.Rows[i].Field<string>("Turmas").ToString(), new Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), cor, new Rectangle(10, 30, 160, 100));
                e.Graphics.DrawString(dt.Rows[i].Field<string>("numero").ToString(), new Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), cor, new Rectangle(10, 30, 160, 100));
                e.Graphics.DrawString(tb_ser_selecionado.Text, new Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), cor, new Rectangle(10, 30, 160, 100));
                e.Graphics.DrawString(tb_preço_selecionado.Text, new Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Pixel), cor, new Rectangle(10, 30, 160, 100));
            }
        }
    }
}
