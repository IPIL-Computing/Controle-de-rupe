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
    public partial class conta : Form
    {
        public conta(string nome, string username, string dia, string mes, string ano,string senha)
        {
            InitializeComponent();
            label_nomeco_PCO.Text = nome;
            label_usuario_PCO.Text = username;
            label_dia.Text = dia;
            label_ano.Text = ano;
            label_mes.Text = mes;
            label_senha.Text = senha;
            dados.senh = label_senha.Text;
            dados.user = label_usuario_PCO.Text;
        }

        private void l_terminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente terminar a sua sessão", "Terminar sessão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                login fm2 = new login();
                fm2.Show();
                this.Hide();
            }
        }

        private void conta_Load(object sender, EventArgs e)
        {

        }
    }
}
