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
    public partial class Dados_geral : Form
    {
        public Dados_geral()
        {
            InitializeComponent();
        }

        private void Dados_geral_Load(object sender, EventArgs e)
        {
            dgv_dados.DataSource = Cl_geral.Obter_Dados1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n= dgv_dados.Width;
            int t = n / 5;
            dgv_dados.Columns[0].Width = t;
            dgv_dados.Columns[1].Width = t;
            dgv_dados.Columns[2].Width = t;
            dgv_dados.Columns[3].Width = t;
            dgv_dados.Columns[4].Width = t;

        }
    }
}
