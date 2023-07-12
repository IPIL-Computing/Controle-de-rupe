using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace r
{
    class Cl_geral
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection conexaobanco()
        {
            conexao = new SQLiteConnection("Data Source=C:\\Users\\DELL\\Documents\\Visual Studio 2015\\Projects\\r\\base\\BASE");
            conexao.Open();
            return conexao;
        }

        public static void delectaruarios(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaobanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM usuario WHERE ID=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex) { throw ex; }
        }
        public static void delectarservicos(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaobanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_servico WHERE ID=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex) { throw ex; }
        }
        public static DataTable obterusuariosIDnomes()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaobanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT ID FROM usuario";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex) { throw ex; }
        }
        public static DataTable obtertodosusuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaobanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM usuario";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex) { throw ex; }
        }
        public static DataTable obtertodosRupes()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaobanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM Rupe";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex) { throw ex; }
        }
        public static DataTable obtertodosservicos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaobanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_servico";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex) { throw ex; }
        }
        public static DataTable obterusuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaobanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT nome as'Nome',username as'Nome de usuario',dia as'Dia',mes as'Mes',ano as'Ano',nivel as'Nivel' FROM usuario";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex) { throw ex; }
        }
        public static DataTable Obter_Dados1()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaobanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM insti ";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex) { throw ex; }
        }

        public static DataTable Obter_Dados2()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaobanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT Area ,Turmas,curso,ID FROM insti";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex) { throw ex; }
        }
        public static DataTable Obter_Dados22(string a, string c, string t)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaobanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM insti WHERE Area='"+a+"' AND curso='"+c+"' AND Turmas='"+t+"'";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex) { throw ex; }
        }
        public static DataTable Obter_Dados(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaobanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM insti WHERE Area='" + id + "'";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex) { throw ex; }
        }
        public static DataTable ObterDadosUsuarios(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaobanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM usuario WHERE ID=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex) { throw ex; }
        }
        public static DataTable obtertodoservicos(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaobanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_servico WHERE ID='" + id+"'";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex) { throw ex; }
        }
        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaobanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show("!"); throw ex; }
        }
        public static void atualizaruarios(dados u)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conexaobanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE  usuario SET nome='" + u.NOMEUSUARIO + "',username='" + u.USERNAME + "',senha='" + u.SENHAUSUARIO + "',nivel=" + u.NIVELUSUARIO + " WHERE ID=" + u.ID;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex) { throw ex; }
        }
        public static void novo_usuario(dados U)
        {

            if (existeUsername(U) || existesenha(U))
            {
                System.Windows.Forms.MessageBox.Show("username ou senha já usados");
                return;
            }
            try
            {
                var cmd = conexaobanco().CreateCommand();
                cmd.CommandText = "INSERT INTO usuario (nome, senha,username ,dia,mes,ano,idade, nivel) VALUES (@nome,@senha,@username,@dia,@mes,@ano,@idade,@nivel)";
                cmd.Parameters.AddWithValue("@nome", U.NOMEUSUARIO);
                cmd.Parameters.AddWithValue("@username", U.USERNAME);
                cmd.Parameters.AddWithValue("@senha", U.SENHAUSUARIO);
                cmd.Parameters.AddWithValue("@nivel", U.NIVELUSUARIO);
                cmd.Parameters.AddWithValue("@dia", U.dia);
                cmd.Parameters.AddWithValue("@mes", U.mes);
                cmd.Parameters.AddWithValue("@ano", U.ano);
                cmd.Parameters.AddWithValue("@idade", U.idade);
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Cadastro feito com sucesso");
                conexaobanco().Close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show("Erro ao insirir dados"); conexaobanco().Close(); }

        }
        public static void novo_serevico(dados U)
        {
            try
            {
                var cmd = conexaobanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_servico (Serviços, Preço) VALUES (@Serviços,@Preço)";
                cmd.Parameters.AddWithValue("@Serviços", U.servico);
                cmd.Parameters.AddWithValue("@Preço", U.preco);
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Servico adicionado com sucesso");
                conexaobanco().Close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show("Erro ao insirir dados"); conexaobanco().Close(); }

        }
        public static void novo_dado(dados U)
        {
            try
            {
                var cmd = conexaobanco().CreateCommand();
                cmd.CommandText = "INSERT INTO insti (Area,Turmas,nome,numero,curso) VALUES (@Area,@Turmas,@nome,@numero,@curso)";
                cmd.Parameters.AddWithValue("@Area", U.area);
                cmd.Parameters.AddWithValue("@Turmas", U.turma);
                cmd.Parameters.AddWithValue("@nome", U.nome);
                cmd.Parameters.AddWithValue("@numero", U.n);
                cmd.Parameters.AddWithValue("@numero", U.curso);
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Servico adicionado com sucesso");
                conexaobanco().Close();
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show("Erro ao insirir dados"); conexaobanco().Close(); }

        }
        public static bool existesenha(dados U)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = conexaobanco().CreateCommand();
            cmd.CommandText = "SELECT Username FROM usuario WHERE senha='" + U.SENHAUSUARIO + "' ";
            da = new SQLiteDataAdapter(cmd.CommandText, conexaobanco());
            da.Fill(dt);
            if (dt.Rows.Count > 0) { res = true; }
            else { res = false; }
            return res;
        }
        public static bool existeUsername(dados U)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            var vcon = conexaobanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT Username FROM usuario WHERE username='" + U.USERNAME + "' ";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0) { res = true; }
            else { res = false; }
            vcon.Close();
            return res;
        }
        //==============funcoes=========
        //===============adicionar no com===

        //===============adicionar no com===

        //rotinas gerais
        public static string meses(string mes)
        {
            string m = mes;
            if (m == "1") { m = "Janeiro"; }
            else if (m == "2") { m = "Fevereiro"; }
            else if (m == "3") { m = "Março"; }
            else if (m == "4") { m = "Abril"; }
            else if (m == "5") { m = "Maio"; }
            else if (m == "6") { m = "Junho"; }
            else if (m == "7") { m = "Julho"; }
            else if (m == "8") { m = "Agosto"; }
            else if (m == "9") { m = "Setembro"; }
            else if (m == "10") { m = "Outubro"; }
            else if (m == "11") { m = "Novembro"; }
            else if (m == "12") { m = "Dezembro"; }
            return m;
        }

    }
}
