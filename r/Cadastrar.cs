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
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();

        }
        int ok = 0, ok1 = 0, permissao;

        private void pb_verificar_senha_Click(object sender, EventArgs e)
        {
            string sen = tb_cadastro_senha.Text;
            if (sen.Length > 7)
            {
                MessageBox.Show("Senha boa");
                ok = 1;
            }
            else { MessageBox.Show("Senha fraca"); ok = 0; }
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {
            if (dados.nivel == 1){ label1.Visible = false; } else {  label1.Visible = true;}
           
        }

        private void pb_verificar_idade_Click(object sender, EventArgs e)
        {
            int ano = DateTime.Now.Year;
            int usoano = int.Parse(tb_idade_ano.Text);
            int mes = int.Parse(tb_idade_mes.Text);
            int dia = int.Parse(tb_idade_dia.Text);
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
        private void cadastro_Click(object sender, EventArgs e)
        {
            if (dados.nivel == 2)
            {
                if ((tb_cadastro_nome_completo.Text == "") || (tb_cadastro_nome_usuario.Text == "") || (tb_cadastro_senha.Text == "") || (tb_idade_ano.Text == "") || (tb_idade_dia.Text == "") || (tb_idade_mes.Text == "")) { MessageBox.Show("Preencha os liugares vazios"); }
                if (ok == 1 && ok1 == 1)
                {
                    dados Usuario = new dados();
                    Usuario.NOMEUSUARIO = tb_cadastro_nome_completo.Text;
                    Usuario.USERNAME = tb_cadastro_nome_usuario.Text;
                    Usuario.SENHAUSUARIO = tb_cadastro_senha.Text;
                    Usuario.idade = permissao.ToString();
                    Usuario.mes = tb_idade_mes.Text;
                    Usuario.dia = tb_idade_dia.Text;
                    Usuario.ano = tb_idade_ano.Text;
                    Usuario.NIVELUSUARIO = Convert.ToInt64(Math.Round(numericUpDown_nivel.Value, 0));

                    Cl_geral.novo_usuario(Usuario);
                    tb_cadastro_nome_completo.Text = "";
                    tb_cadastro_nome_usuario.Text = "";
                    tb_cadastro_senha.Text = "";
                    tb_idade_ano.Text = "";
                    tb_idade_dia.Text = "";
                    tb_idade_mes.Text = "";
                }
            }
            else if(dados.nivel==1)
            {
                
                if ((tb_cadastro_nome_completo.Text == "") || (tb_cadastro_nome_usuario.Text == "") || (tb_cadastro_senha.Text == "") || (tb_idade_ano.Text == "") || (tb_idade_dia.Text == "") || (tb_idade_mes.Text == "")) { MessageBox.Show("Preencha os liugares vazios"); }
                if (ok == 1 && ok1 == 1)
                {
                    Int64 n= Convert.ToInt64(Math.Round(numericUpDown_nivel.Value, 0));
                    if (n > 2) { MessageBox.Show("Não possivel prosseguir devido ao nivel escolhido"); }
                    else
                    {
                        dados Usuario = new dados();
                        Usuario.NOMEUSUARIO = tb_cadastro_nome_completo.Text;
                        Usuario.USERNAME = tb_cadastro_nome_usuario.Text;
                        Usuario.SENHAUSUARIO = tb_cadastro_senha.Text;
                        Usuario.idade = permissao.ToString();
                        Usuario.mes = tb_idade_mes.Text;
                        Usuario.dia = tb_idade_dia.Text;
                        Usuario.ano = tb_idade_ano.Text;
                        Usuario.NIVELUSUARIO = Convert.ToInt64(Math.Round(numericUpDown_nivel.Value, 0));

                    Cl_geral.novo_usuario(Usuario);
                    tb_cadastro_nome_completo.Text = "";
                    tb_cadastro_nome_usuario.Text = "";
                    tb_cadastro_senha.Text = "";
                    tb_idade_ano.Text = "";
                    tb_idade_dia.Text = "";
                    tb_idade_mes.Text = "";
                    }

                }
            }
        }
    }
}
