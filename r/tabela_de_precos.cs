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
    public partial class tabela_de_precos : Form
    {
        public tabela_de_precos()
        {
            InitializeComponent();
        }

        private void tabela_de_precos_Load(object sender, EventArgs e)
        {
            int n = dgv_tabela_de_precos.RowCount;
            label_quantidade.Text = n.ToString();
            dgv_tabela_de_precos.DataSource = Cl_geral.obtertodosservicos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dgv_tabela_de_precos.Width;
            int t = n / 3;
            dgv_tabela_de_precos.Columns[0].Width = t;
            dgv_tabela_de_precos.Columns[1].Width = t;
            dgv_tabela_de_precos.Columns[2].Width = t;
        }
    }
}
