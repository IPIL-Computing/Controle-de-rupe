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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        int ok = 0, ok1 = 0;
        int permissao;

        private void pictureBox_verificar_idade_Click(object sender, EventArgs e)
        {

            int ano = DateTime.Now.Year;
            int usoano = int.Parse(textBox_idade_ano.Text);
            int mes = int.Parse(textBox_idade_mes.Text);
            int dia = int.Parse(textBox_idade_dia.Text);
            permissao = ano - usoano;
            if ((permissao < 18 || mes > 12 || dia > 31))
            {
                MessageBox.Show("Idade negada");
                ok1 = 0;
            }
            else
            {
                ok1 = 1; MessageBox.Show("Idade aceite");
            }
        }

        private void pictureBox_verificar_senha_Click(object sender, EventArgs e)
        {
            string sen = textBox_cadastro_senha.Text;
            if (sen.Length > 7)
            {
                MessageBox.Show("Senha boa");
                ok = 1;
            }
            else { MessageBox.Show("Senha fraca"); ok = 0; }
        }

        private void label_limpa_Click(object sender, EventArgs e)
        {
            textBox_cadastro_nome_completo.Text = "";
            textBox_cadastro_nome_usuario.Text = "";
            textBox_cadastro_senha.Text = "";
            textBox_idade_ano.Text = "";
            textBox_idade_dia.Text = "";
            textBox_idade_mes.Text = "";
        }

        private void voltar_cadastro_Click(object sender, EventArgs e)
        {
            textBox_cadastro_nome_completo.Text = "";
            textBox_cadastro_nome_usuario.Text = "";
            textBox_cadastro_senha.Text = "";
            textBox_idade_ano.Text = "";
            textBox_idade_dia.Text = "";
            textBox_idade_mes.Text = "";
            panel_login.Show();
            panel_fndo_login.Show();
        }


        private void cadastro_Click(object sender, EventArgs e)
        {

            if ((textBox_cadastro_nome_completo.Text == "") || (textBox_cadastro_nome_usuario.Text == "") || (textBox_cadastro_senha.Text == "") || (textBox_idade_ano.Text == "") || (textBox_idade_dia.Text == "") || (textBox_idade_mes.Text == "")) { MessageBox.Show("Preencha os liugares vazios"); }
            if (ok == 1 && ok1 == 1)
            {
                dados Usuario = new dados();
                Usuario.NOMEUSUARIO = textBox_cadastro_nome_completo.Text;
                Usuario.USERNAME = textBox_cadastro_nome_usuario.Text;
                Usuario.SENHAUSUARIO = textBox_cadastro_senha.Text;
                Usuario.NIVELUSUARIO = 0;
                Usuario.idade = permissao.ToString();
                Usuario.mes = textBox_idade_mes.Text;
                Usuario.dia = textBox_idade_dia.Text;
                Usuario.ano = textBox_idade_ano.Text;
                Cl_geral.novo_usuario(Usuario);
                textBox_cadastro_nome_completo.Text = "";
                textBox_cadastro_nome_usuario.Text = "";
                textBox_cadastro_senha.Text = "";
                textBox_idade_ano.Text = "";
                textBox_idade_dia.Text = "";
                textBox_idade_mes.Text = "";
            }
        }

        private void nao_tenho_conta_Click(object sender, EventArgs e)
        {
            panel_login.Hide();
            panel_fndo_login.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //====================================================

        private void iniciar_Click(object sender, EventArgs e)
        {
            string username = textBox_login_nomeusuario.Text;
            string senha = textBox_login_senha.Text;
            if (username == "" || senha == "")
            {
                MessageBox.Show("usuario ou senha invalidos");
                textBox_login_nomeusuario.Focus();
                return;
            }

            string sql = "SELECT * FROM usuario WHERE username='" + username + "' AND senha='" + senha + "'";
            dt = Cl_geral.consulta(sql);
            if (dt.Rows.Count == 1)
            {
                int acesso;
                acesso = int.Parse(dt.Rows[0].Field<Int64>("nivel").ToString());
                dados.nivel= int.Parse(dt.Rows[0].Field<Int64>("nivel").ToString());
                dados.logado = true;
                if (acesso == 0)
                {
                    conta fm2 = new conta(dt.Rows[0].ItemArray[1].ToString(), dt.Rows[0].ItemArray[3].ToString(), dt.Rows[0].ItemArray[4].ToString(), Cl_geral.meses(dt.Rows[0].ItemArray[5].ToString()), dt.Rows[0].ItemArray[6].ToString(), senha);
                    Form_principal f = new Form_principal();
                    f.Show();
                    this.Hide();
                }
                if (acesso == 1)
                {
                    conta fm2 = new conta(dt.Rows[0].ItemArray[1].ToString(), dt.Rows[0].ItemArray[3].ToString(), dt.Rows[0].ItemArray[4].ToString(), Cl_geral.meses(dt.Rows[0].ItemArray[5].ToString()), dt.Rows[0].ItemArray[6].ToString(), senha);
                    Form_principal f = new Form_principal();
                    f.Show();
                    this.Hide();
                }
                if (acesso == 2)
                {
                    conta fm2 = new conta(dt.Rows[0].ItemArray[1].ToString(), dt.Rows[0].ItemArray[3].ToString(), dt.Rows[0].ItemArray[4].ToString(), Cl_geral.meses(dt.Rows[0].ItemArray[5].ToString()), dt.Rows[0].ItemArray[6].ToString(), senha);
                    Form_principal f = new Form_principal();
                    f.Show();
                    this.Hide();
                }
            }
            else { MessageBox.Show("usuario não enconrado"); }
        }
    }
}
