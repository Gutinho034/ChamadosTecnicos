using ChamadosTecnicosTec55.adicionar;
using ChamadosTecnicosTec55.Alterar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void gestotrToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fecharSoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msgBox = MessageBox.Show("Deseja realmente sair??", "Sistema de Chamados", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (msgBox == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void documentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = @"https://sp.senac.br",
                UseShellExecute = true,

            });
                
                
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formcliente = new frmAdicionarCliente();
            //  Define o Formulario pai
            formcliente.MdiParent = this;
            formcliente.Show();
        }

        private void tecnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formtecnico = new frmTecnicoAdicionar();
            formtecnico.MdiParent = this;
            formtecnico.Show();
        }

        private void gestorDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formgerircliente = new frmGerirClientes();
            formgerircliente.MdiParent = this;
            formgerircliente.Show();

        }
    }
}
