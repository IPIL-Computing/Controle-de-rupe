using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace r
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
        }
        private void Form_principal_Load(object sender, EventArgs e)
        {
            hidesu();
            if (dados.nivel == 0)
            {
                b_Usuarios.Visible = false;
                b_instituicao.Visible = false;
                b_Rupes.Visible = false;
            }
        }
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg,int wParam,int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        //=====================funcoes privadas==================
        private void abrir_formulario(object form)
        {
                if (this.panel_displaye.Controls.Count > 0)
                    this.panel_displaye.Controls.RemoveAt(0);
                    Form fm2 = form as Form;
                    fm2.TopLevel = false;
                    fm2.Dock = DockStyle.Fill;
                    this.panel_displaye.Controls.Add(fm2);
                    this.panel_displaye.Tag = fm2;
                    fm2.Show();
        }
        private void hidesu()
        {
            panel_servico.Visible = false;
            panel_usuario.Visible = false;
            panel_instituicao.Visible = false;
            panel_logar.Visible = false;
        }
        //=====================funcoes privadas==================


        //====================botões da barra de cima============
        private void pb_fechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void pb_minizar_Click_1(object sender, EventArgs e)
        {
this.WindowState = FormWindowState.Minimized;
        }
        private void pb_restaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pb_maximizar.Visible = true;
            pb_restaurar.Visible = false;
        }
        private void pb_maximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pb_maximizar.Visible = false;
            pb_restaurar.Visible = true;
        }
        //====================botões da barra de cima============


        //======================botões da barra menu=============
        DataTable dt = new DataTable();
        private void b_conta_Click(object sender, EventArgs e)
        {
            if (dados.logado == false)
            {
                if (MessageBox.Show("É necessário ter uma conta logada", "Logar", MessageBoxButtons.OK) == DialogResult.OK)
                { return;  }else { return; }
            }
            else {
                string username =dados.user;
                string senha = dados.senh;
                string sql = "SELECT * FROM usuario WHERE username='" + username + "' AND senha='" + senha + "'";
                dt = Cl_geral.consulta(sql);
                abrir_formulario(new conta(dt.Rows[0].ItemArray[1].ToString(), dt.Rows[0].ItemArray[3].ToString(), dt.Rows[0].ItemArray[4].ToString(), Cl_geral.meses(dt.Rows[0].ItemArray[5].ToString()), dt.Rows[0].ItemArray[6].ToString(), senha));
            }
           
        }
        private void b_Usuarios_Click(object sender, EventArgs e)
        {
            if (panel_usuario.Visible == true){ panel_usuario.Visible = false; }
            else { panel_usuario.Visible = true; }
        }
        private void b_servico_Click(object sender, EventArgs e)
        {
            if (dados.logado == false)
            {
                if (MessageBox.Show("É necessário ter uma conta logada", "Logar", MessageBoxButtons.OK) == DialogResult.OK)
                { return; }
                else { return; }
            }
            else
            {
                if (panel_servico.Visible == true) { panel_servico.Visible = false; }
                else { panel_servico.Visible = true; }
            }
        }
        private void b_instituicao_Click(object sender, EventArgs e)
        {
            if (panel_instituicao.Visible == true) { panel_instituicao.Visible = false; }
            else { panel_instituicao.Visible = true; }
        }
        private void b_Rupes_Click(object sender, EventArgs e)
        {
            abrir_formulario(new Rupes());
        }
        private void b_logar_Click(object sender, EventArgs e)
        {
            if (panel_logar.Visible == true) { panel_logar.Visible = false; }
            else { panel_logar.Visible = true; }
        }

        //======================botões da barra menu==============


        //======================botões da barra sub-menu==============
        private void b_Gestao_de_usuarios_Click(object sender, EventArgs e)
        {
            abrir_formulario(new Gestao_usuario());
        }
        private void b_Tabela_de_preco_Click(object sender, EventArgs e)
        {
            abrir_formulario(new tabela_de_precos());
        }
        private void b_imprimir_Click(object sender, EventArgs e)
        {
            if (dados.nivel == 0) { abrir_formulario(new Imprimir1()); }
            else { abrir_formulario(new Imprimir()); }
        }
        private void b_gestao_de_servicos_Click(object sender, EventArgs e)
        {
            abrir_formulario(new Gestao_de_servicos());
        }
        private void b_Dados_geral_Click(object sender, EventArgs e)
        {
            abrir_formulario(new Dados_geral());
        }
        private void b_gestao_de_turmas_Click(object sender, EventArgs e)
        {
            abrir_formulario(new Gestao_de_turmas());
        }
        private void b_Cadastrar_Click(object sender, EventArgs e)
        {
            abrir_formulario(new Cadastrar());
        }
        private void b_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            login f = new login();
            f.ShowDialog();
        }

        private void b_logaut_Click(object sender, EventArgs e)
        {
            dados.nivel = 0;
            dados.logado = false;
            panel_displaye.Controls.RemoveAt(0);
            panel_displaye.Visible = true;
            panel_logar.Visible = false;
            if (dados.nivel == 0)
            {
                b_Usuarios.Visible = false;
                b_Tabela_de_preco.Visible = false;
                b_gestao_de_servicos.Visible = false;
                b_instituicao.Visible = false;
                b_Rupes.Visible = false;
                conta f = new conta("", "", "", "", "", "");
                    }
        }

        private void b_Lista_de_usuarios_Click(object sender, EventArgs e)
        {
            abrir_formulario(new lista_de_usuarios());
        }



        //======================botões da barra sub-menu==============
    }
}
