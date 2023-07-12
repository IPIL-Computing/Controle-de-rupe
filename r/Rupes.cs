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
    public partial class Rupes : Form
    {
        public Rupes()
        {
            InitializeComponent();
        }
        string a;
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
                        dgv_rupe.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Rupes_Load(object sender, EventArgs e)
        {
            dgv_rupe.DataSource = Cl_geral.obtertodosRupes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dgv_rupe.Width;
            int t = n / 2;
            dgv_rupe.Columns[0].Width = t;
            dgv_rupe.Columns[1].Width = t;
        }
    }
}
