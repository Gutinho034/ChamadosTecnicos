using ChamadosTecnicosTec55.adicionar;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamadosTecnicosTec55.Alterar
{
    public partial class frmGerirClientes : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;

        public frmGerirClientes()
        {
            InitializeComponent();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            txt_buscar.Text = "";
        }

        private void ListarCliente()
        {
            ClienteDao clientedao = new ClienteDao(_conexao);

            string busca = txt_buscar.Text.ToString();

            DataSet ds = new DataSet();
            ds = clientedao.BuscaCliente(busca);

            dgvCliente.DataSource = ds;

            dgvCliente.DataMember = "Clientes";
        }

        private void frmGerirClientes_Load(object sender, EventArgs e)
        {
           ListarCliente();
        }

        private void btn_incluircliente_Click(object sender, EventArgs e)
        {
            var frmaddCliente = new frmAdicionarCliente();
            frmaddCliente.Show();          
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            ListarCliente();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if(dgvCliente.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);

                var frm_AlterarCliente = new frm_AlterarCliente(codigo);
                frm_AlterarCliente.ShowDialog();

                //Listar Clientes apos fechar tela
                ListarCliente();
            }

            else
            {
                MessageBox.Show("Selecione um registro para alteração");

            }
        }
    }
}
