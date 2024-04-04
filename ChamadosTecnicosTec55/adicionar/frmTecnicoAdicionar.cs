using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace ChamadosTecnicosTec55.adicionar
{
    public partial class frmTecnicoAdicionar : Form
    {
        string _conexao = ChamadosTecnicosTec55.Properties.Settings.Default.Conexao;

        public frmTecnicoAdicionar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_Eps.Clear();
            txt_senha.Clear();
            txt_email.Clear();
            txt_obs.Clear();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Tecnico tecnico = new Tecnico();
            TecnicoDao tecnicoDao = new TecnicoDao(_conexao);

            if (string.IsNullOrEmpty(txt_nome.Text) || string.IsNullOrEmpty(txt_Eps.Text) || string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(txt_senha.Text) || string.IsNullOrEmpty(txt_obs.Text)) 
            {
                MessageBox.Show("Cadê os dados??"); 
            
            }



            else
            {
                // TODA VEZ QUE MEXER COM BD USAR TRY
                try
                {
                    // Preenche o Objeto Cliente 
                    tecnico.Nome = txt_nome.Text;
                    tecnico.Especialidade = txt_Eps.Text;
                    tecnico.Obs = txt_obs.Text;
                    tecnico.Senha = txt_senha.Text;
                    tecnico.Email = txt_email.Text;

                    tecnicoDao.IncluiTecnico(tecnico);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Cadastrar", "Atenção",
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
    }
}
