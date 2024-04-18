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

    namespace ChamadosTecnicosTec55
    {
        public partial class frm_AlterarCliente : Form
        {
            string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;
            public frm_AlterarCliente(int codigo)
            {
                InitializeComponent();

                if (codigo > 0)
                {
                    Cliente cliente = new Cliente();
                    ClienteDao clienteDao = new ClienteDao(_conexao);

                    cliente = clienteDao.ObtemCliente(codigo);

                    if(cliente == null)
                    {
                        MessageBox.Show("Cliente não encontrado");
                        this.Close();
                    }

                    txb_Cod.Text = cliente.ToString();
                    txtNome.Text = cliente.Nome.ToString();
                    txbProfissao.Text = cliente.Profissao.ToString();
                    txbSetor.Text = cliente.Setor.ToString();
                    txbOBS.Text = cliente.Obs.ToString();

                }
            }
        }
    }
