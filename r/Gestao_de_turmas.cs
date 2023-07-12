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
    public partial class Gestao_de_turmas : Form
    {
        public Gestao_de_turmas()
        {
            InitializeComponent();
        }

        private void b_salvar_Click(object sender, EventArgs e)
        {
            if (tb_area.Text == "" || tb_nome.Text == "" || tb_turma.Text == "" || tb_numero.Text == "") { MessageBox.Show("Preencha os liugares vazios"); }
            else
            {
                dados ints = new dados();
                ints.area = tb_area.Text;
                ints.turma = tb_turma.Text;
                ints.nome = tb_nome.Text;
                ints.n = tb_numero.Text;
                ints.curso = tb_curso.Text;
                //ints.curso=tex
                Cl_geral.novo_dado(ints);
                dvg_instituto.DataSource = Cl_geral.Obter_Dados(tb_area.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = dvg_instituto.RowCount;
            if (a>0)
            {
             int n = dvg_instituto.Width;
            int t = n / 5;
            dvg_instituto.Columns[0].Width = t;
            dvg_instituto.Columns[1].Width = t;
            dvg_instituto.Columns[2].Width = t;
            dvg_instituto.Columns[3].Width = t;
            dvg_instituto.Columns[4].Width = t;
            }
            else { MessageBox.Show("Não há presença de nenhuma turma alistada"); }
           
        }
    }
}
