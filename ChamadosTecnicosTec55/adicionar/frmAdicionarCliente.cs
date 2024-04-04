using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace ChamadosTecnicosTec55.adicionar
{
    public partial class frmAdicionarCliente : Form
    {   
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;

        public frmAdicionarCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();
            txbOBS.Clear();
            txbProfissao.Clear();
            txbSetor.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteDao clienteDao = new ClienteDao(_conexao);

            if (string.IsNullOrEmpty(txbNome.Text) || string.IsNullOrEmpty(txbOBS.Text) || string.IsNullOrEmpty(txbProfissao.Text) || string.IsNullOrEmpty(txbSetor.Text))
            {
                MessageBox.Show("Cadê os dados??");
                    
            }

            else
            {   
                // TODA VEZ QUE MEXER COM BD USAR TRY
                try
                {
                    // Preenche o Objeto Cliente 
                    cliente.Nome = txbNome.Text;
                    cliente.Profissao = txbProfissao.Text;
                    cliente.Obs = txbOBS.Text;
                    cliente.Setor = txbSetor.Text;

                    clienteDao.IncluiCliente(cliente);

                }catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Cadastrar","Atenção",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                }
                finally
                {
                    MessageBox.Show("Cadastrado com sucesso!");

                    this.Close();
                }

            }

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbProfissao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbSetor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
